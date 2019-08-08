[CmdletBinding()]
param(
    [switch] $Toggle,
    [ValidateSet('NuGet', 'Local')]
    [string] $Source,
    [string] $CsProjPath
)

# 
# Helper function to get the latest version of a NuGet package
# 
# Credit https://gist.github.com/staxmanade/1009729
# 
function Get-Latest-NuGet-Version($nuGetPackageId) {
    Write-Verbose "Getting the latest version of NuGet package '$nuGetPackageId'."
    $feeedUrl = "http://packages.nuget.org/v1/FeedService.svc/Packages()?`$filter=Id%20eq%20'$nuGetPackageId'"
    $webClient = new-object System.Net.WebClient
    $queryResults = [xml]($webClient.DownloadString($feeedUrl))
    $version = $queryResults.feed.entry | ForEach-Object { $_.properties.version } | sort-object | Select-Object -Last 1
    if (!$version) { $version = "0.0" }
    $version
}

# Check inputs
if ($false -eq $Toggle) {
    Write-Error 'Source is required if Toggle switch is not set.'
    return
}

# Get XML
if (!$CsProjPath) {
    $CsProjPath = (Get-ChildItem -Path "$PSScriptRoot\..\" -Recurse -Include "*Marqeta.Core.Sdk.csproj" | Select-Object -First 1).FullName
}
$xml = [xml] (Get-Content $CsProjPath -Raw)

# Get relevant nodes for manipulation
$localReferenceItemGroup = $xml | Select-Xml -XPath "//ItemGroup[Reference[@Include='Marqeta.Core.Abstractions']]"
$packageReferenceItemGroup = $xml | Select-Xml -XPath "//ItemGroup[PackageReference[@Include='Marqeta.Core.Abstractions']]"
if ($null -eq $packageReferenceItemGroup) { $packageReferenceItemGroup = $xml | Select-Xml -XPath "//ItemGroup[PackageReference]" }
$packageReference = $xml | Select-Xml -XPath "//ItemGroup/PackageReference[@Include='Marqeta.Core.Abstractions']"


# Sanity check xml
if ($null -eq $localReferenceItemGroup -and $null -eq $packageReference) {
    Write-Error 'Cannot find either a NuGet or Local reference.'
    return
}
if ($localReferenceItemGroup -and $packageReference) {
    Write-Error 'Found both a NuGet or Local reference.'
    return
}

# Determine current state
$currentSource = 'NuGet'
if ($localReferenceItemGroup) { $currentSource = 'Local' }
Write-Verbose "Current source is '$($currentSource)'."

# Determine desired state
if ($Toggle) {
    $Source = switch ($currentSource) {
        'NuGet' { 'Local' }
        'Local' { 'NuGet' }
    }
    Write-Verbose "Toggle switch present, setting Source to '$Source'."
}

# Check desired state
if ($currentSource -eq $Source) {
    Write-Host "NuGet references are already set to '$Source'."
    return
}

# Change XML
Write-Host "Setting NuGet references to '$Source'."
switch ($Source) {
    'NuGet' {
        # Remove Local reference to Marqeta.Core.Abstractions
        $xml.Project.RemoveChild($localReferenceItemGroup.Node) | Out-Null

        # Remove NuGet reference to Newtonsoft.Json
        $newtonsoftJsonPackageReference = $xml | Select-Xml -XPath "//ItemGroup/PackageReference[@Include='Newtonsoft.Json']"
        $packageReferenceItemGroup.Node.RemoveChild($newtonsoftJsonPackageReference.Node) | Out-Null

        # Add NuGet reference for Marqeta.Core.Abstractions
        $latestNuGetVersion = Get-Latest-NuGet-Version('Marqeta.Core.Abstractions')
        $newNode = [xml]"<PackageReference Include=""Marqeta.Core.Abstractions"" Version=""$latestNuGetVersion"" />"
        $newNode = $xml.ImportNode($newNode.PackageReference, $true) 
        $packageReferenceItemGroup.Node.AppendChild($newNode) | Out-Null
    }
    'Local' {
        # Remove NuGet reference to Marqeta.Core.Abstractions
        $packageReferenceItemGroup.Node.RemoveChild($packageReference.Node) | Out-Null

        # Add NuGet reference for Newtonsoft.Json
        $latestNuGetVersion = Get-Latest-NuGet-Version('Newtonsoft.Json')
        $newNode = [xml]"<PackageReference Include=""Newtonsoft.Json"" Version=""$latestNuGetVersion"" />"
        $newNode = $xml.ImportNode($newNode.PackageReference, $true) 
        $packageReferenceItemGroup.Node.AppendChild($newNode) | Out-Null

        # Add Local reference to Marqeta.Core.Abstractions
        $newNode = [xml]"
        <ItemGroup>
            <Reference Include=""Marqeta.Core.Abstractions"">
                <HintPath>..\..\marqeta-csharp-core-abstractions\src\Marqeta.Core.Abstractions\bin\Debug\netstandard2.0\Marqeta.Core.Abstractions.dll</HintPath>
            </Reference>
        </ItemGroup>
        "
        $newNode = $xml.ImportNode($newNode.ItemGroup, $true)
        $xml.Project.AppendChild($newNode) | Out-Null
    }
}

$xml.Save($CsProjPath)
