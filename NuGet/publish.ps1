$version = "6.0.0"

if (![System.IO.File]::Exists("nuget.exe")) {
    Invoke-WebRequest -Uri "https://dist.nuget.org/win-x86-commandline/latest/nuget.exe" -OutFile "nuget.exe"
}

Write-Output ("Push NodeNetworkJH " + $version + " to NuGet? (Didn't forget version bump?)")
Read-Host
./nuget.exe push ("../NodeNetworkJH/bin/Release/NodeNetworkJH." + $version + ".nupkg") $args[0] -Source https://api.nuget.org/v3/index.json
./nuget.exe push ("../NodeNetworkJHToolkit/bin/Release/NodeNetworkJHToolkit." + $version + ".nupkg") $args[0] -Source https://api.nuget.org/v3/index.json
./nuget.exe push ("../NodeNetworkJH/bin/Release/NodeNetworkJH." + $version + ".symbols.nupkg") $args[0] -source https://nuget.smbsrc.net/
./nuget.exe push ("../NodeNetworkJHToolkit/bin/Release/NodeNetworkJHToolkit." + $version + ".symbols.nupkg") $args[0] -source https://nuget.smbsrc.net/
