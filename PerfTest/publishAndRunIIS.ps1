iisreset
# restart-webappPool perf.west-wind.com
# \utl\recycleApplicationPool perf.west-wind.com

remove-item bin\release\netcoreapp2.2\publish -recurse -force

dotnet publish -c Release

start "http://perf.west-wind.com/api/helloworldjson"