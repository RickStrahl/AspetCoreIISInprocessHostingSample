iisreset

dotnet publish -c Release

$curFolder = "$PSScriptRoot" 

cd bin\release\netcoreapp2.2\publish
dotnet perftest.dll

cd "$curFolder"