@echo off

set _build=0
IF NOT "%APPVEYOR_BUILD_NUMBER%"=="" (
  set _build=%APPVEYOR_BUILD_NUMBER%
)
IF NOT "%1"=="" (
  set _build=%1
)

set _version=1.7.4-pre-%_build%
set _configuration=Debug

mkdir out\packages

@echo on

nuget pack nuspec\NetOffice.Core.nuspec -outputdirectory out\packages -properties Configuration=%_configuration% -version %_version% -symbols -noninteractive
nuget pack nuspec\NetOffice.Access.nuspec -outputdirectory out\packages -properties Configuration=%_configuration% -version %_version% -symbols -noninteractive
nuget pack nuspec\NetOffice.Excel.nuspec -outputdirectory out\packages -properties Configuration=%_configuration% -version %_version% -symbols -noninteractive
nuget pack nuspec\NetOffice.MSFormsApi.nuspec -outputdirectory out\packages -properties Configuration=%_configuration% -version %_version% -symbols -noninteractive
nuget pack nuspec\NetOffice.MSProject.nuspec -outputdirectory out\packages -properties Configuration=%_configuration% -version %_version% -symbols -noninteractive
nuget pack nuspec\NetOffice.Outlook.nuspec -outputdirectory out\packages -properties Configuration=%_configuration% -version %_version% -symbols -noninteractive
nuget pack nuspec\NetOffice.PowerPoint.nuspec -outputdirectory out\packages -properties Configuration=%_configuration% -version %_version% -symbols -noninteractive
nuget pack nuspec\NetOffice.Visio.nuspec -outputdirectory out\packages -properties Configuration=%_configuration% -version %_version% -symbols -noninteractive
nuget pack nuspec\NetOffice.Word.nuspec -outputdirectory out\packages -properties Configuration=%_configuration% -version %_version% -symbols -noninteractive