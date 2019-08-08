# Directories
$BinDirectory = "bin"
if (-Not (Test-Path $BinDirectory)) {
	New-Item $BinDirectory -type directory
}

# NuGet
$NuGetPath = "$BinDirectory/nuget.exe"

# Get NuGet command line if it doesn't already exist
if (-Not (Test-Path $NuGetPath)) {
	Invoke-WebRequest -Uri "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe" -OutFile $NuGetPath
}

# Build
$version = '0.0.1'
dotnet pack --configuration Release /p:Version=$version

# Push
# 2019-07-26T14:09:49.4724766Z [command]/usr/bin/mono /opt/hostedtoolcache/NuGet/4.1.0/x64/nuget.exe push /home/vsts/work/1/a/Marqeta.Core.Abstractions.0.1.12.nupkg -NonInteractive -Source https://www.nuget.org/packages/Marqeta.Core.Abstractions/ -ApiKey *** -ConfigFile /home/vsts/work/1/Nuget/tempNuGet_73.config -Verbosity Detailed
# -Verbosity Detailed
# $Args = "push .\src\Marqeta.Core.Abstractions\bin\Release\Marqeta.Core.Abstractions.0.0.2.nupkg -NonInteractive -Source https://www.nuget.org/packages/Marqeta.Core.Abstractions/ -ApiKey oy2dobe5utzohvr3bn5q5cut6yo6jpbuzk5tsw4siitdd4 -Verbosity Detailed"
# $Args = "push .\src\Marqeta.Core.Abstractions\bin\Release\Marqeta.Core.Abstractions.$($version).nupkg -NonInteractive -Source https://api.nuget.org/v3/index.json -ApiKey oy2dobe5utzohvr3bn5q5cut6yo6jpbuzk5tsw4siitdd4 -Verbosity Detailed"

# $Cmd="$NuGetPath $Args"
# Invoke-Expression $Cmd