[CmdletBinding()]
param(
    [bool] $CleanUpCode = $false,
    [bool] $BuildAfterGeneration = $true
)

# Timer
$sw = [System.Diagnostics.Stopwatch]::StartNew()

#
# Sanity checks
#

# NSwag
if (!(Get-Command 'nswag' -ErrorAction SilentlyContinue)) {
    # TODO install nswag
    Write-Error "Cannot find command 'nswag' which is required for generation."
    return
}

#
# /Sanity checks
#

# Output settings
$outDir = $PSScriptRoot
Write-Verbose "Using `$outDir: $($outDir)"

# # Purge output directory
# if (Test-Path $outDir) {
#     Write-Verbose "Purging directory '$outDir'."
#     Remove-Item -Recurse -Force $outDir -ErrorAction SilentlyContinue
# }
# Write-Verbose "Creating directory '$outDir'."
# mkdir $outDir -ErrorAction SilentlyContinue | Out-Null

# 
# git clean -xdf .
git clean -xdf src

# Generator arguments
$nswagArgs = @(
    'run', '.\Marqeta.Core.Sdk\nswag.json'
    , '/runtime:NetCore22'
)
Write-Verbose "Using `$nswagArgs: $($nswagArgs)"

Write-Verbose "Running nswag."
nswag $nswagArgs

# 
# Build solution
#
$solutionPath = './Marqeta.Core.Sdk.sln'
if ($BuildAfterGeneration) {
    if (Get-Command 'dotnet' -ErrorAction SilentlyContinue) {
        # Build solution
        dotnet build $solutionPath
    }
    else {
        Write-Host -ForegroundColor Yellow "Warning: dotnet CLI could not be found within the current environment. ReSharper Clean Up Code has not been run."
    }
}

# 
# Clean up code
#
if ($CleanUpCode) {
    # Check for dotnet CLI
    # We need to build the solution before running the ReSharper Clean Up Code to prevent errors in the clean up
    if (Get-Command 'dotnet' -ErrorAction SilentlyContinue) {
        # Build solution
        dotnet build $solutionPath

        # Clean up code
        $reSharperCltUrl = 'https://download-cf.jetbrains.com/resharper/ReSharperUltimate.2019.1.2/JetBrains.ReSharper.CommandLineTools.2019.1.2.zip'
        $reSharperCltDirectory = './JetBrains.ReSharper.CommandLineTools.2019.1.2'
        $reSharperCltZipPath = $reSharperCltDirectory + '.zip'
        $reSharperCleanUpCodePath = $reSharperCltDirectory + '/cleanupcode.exe'
        if (!(Test-Path $reSharperCleanUpCodePath)) {
            Write-Verbose "Downloading 'ReSharper Command Line Tools'."
            Invoke-WebRequest -Uri $reSharperCltUrl -OutFile $reSharperCltZipPath
            Expand-Archive -Path $reSharperCltZipPath -DestinationPath $reSharperCltDirectory
            Remove-Item -Path $reSharperCltZipPath -Force
        }
        . $reSharperCleanUpCodePath $solutionPath
    }
    else {
        Write-Host -ForegroundColor Yellow "Warning: dotnet CLI could not be found within the current environment. ReSharper Clean Up Code has not been run."
    }
}

# Timer
$sw.Stop()
Write-Host "Code generation completed in '$($sw.Elapsed)'." 
