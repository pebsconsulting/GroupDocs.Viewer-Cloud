rd /S /Q "c:\tmp\csharp"

java -jar SDKs\codegen\swagger-codegen-cli-2.3.0.jar generate ^
-i SDKs\spec\groupdocsforcloud_viewer_csharp.json ^
-l csharp ^
-t SDKs\codegen\Templates\csharp ^
-o c:/tmp/csharp/ ^
-c SDKs\codegen\config.json

SDKs\codegen\Tools\SplitCSharpCodeFile.exe ^
C:\tmp\csharp\src\GroupDocs.Viewer.Cloud.Sdk\Api\ViewerApi.cs ^
C:\tmp\csharp\src\GroupDocs.Viewer.Cloud.Sdk\Model\Requests\

xcopy /Y "c:\tmp\csharp\src\GroupDocs.Viewer.Cloud.Sdk\Model" "SDKs\NET\GroupDocs.Viewer.Cloud.Sdk\Model" /E
xcopy /Y "c:\tmp\csharp\src\GroupDocs.Viewer.Cloud.Sdk\Api" "SDKs\NET\GroupDocs.Viewer.Cloud.Sdk\Api" /E

rd /S /Q "c:\tmp\csharp"
