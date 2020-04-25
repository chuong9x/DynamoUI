Training DynamoDS Node Model:
This project provides a Visual Studio template for advanced Dynamo package development using ZeroTouch Node Models.

### UI
- Button
- Slider
- Dropdown
### Create Dynamo Folder

C:\Users\"UserName"\AppData\Roaming\Dynamo\Dynamo Core\2.1\packages\DynamoUI\bin

### License
DynamoNodeModelsEssentials is licensed under the MIT license.(http://opensource.org/licenses/MIT)
### Build Event

xcopy /Y "$(TargetDir)DynamoUI.dll" "$(AppData)\Dynamo\Dynamo Core\2.1\packages\$(ProjectName)\bin\"

xcopy /Y "$(ProjectDir)pkg.json" "$(AppData)\Dynamo\Dynamo Core\2.1\packages\$(ProjectName)"

Many thanks <a href="https://github.com/nonoesp" target="_blank">nonoesp</a> 