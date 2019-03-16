# iisreset

dotnet publish -c Release

$curFolder = "$PSScriptRoot" 

Set-Location bin\release\netcoreapp2.2\publish
dotnet perftest.dll

cd "$curFolder"