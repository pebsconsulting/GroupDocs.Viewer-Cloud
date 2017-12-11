# GroupDocs.Viewer for Cloud SDKs
This folder contains SDKs for [GroupDocs.Viewer for Cloud](https://products.groupdocs.cloud/viewer/cloud) for various platforms.

# Currently Available SDKs

Directory | Description
--------- | -----------
[.NET SDK](SDKs/NET) | GroupDocs.Viewer for Cloud .NET SDK

To use these SDKs, you will need App SID and App Key which can be looked up at [GroupDocs Cloud Dashboard](https://dashboard.groupdocs.cloud) (free registration in GroupDocs Cloud is required for this).

## Getting Started

```csharp
using System;
using System.Diagnostics;
using GroupDocs.Viewer.Cloud.Sdk;
using GroupDocs.Viewer.Cloud.Sdk.Api;
using GroupDocs.Viewer.Cloud.Sdk.Model.Requests;

namespace Example
{
    public class Example
    {
        public void Main()
        {
            //TODO: Get your AppSID and AppKey at https://dashboard.groupdocs.cloud/ (free registration is requited).
            var configuration = new Configuration
            {
                AppSid = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX",
                AppKey = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
            };

            var apiInstance = new ViewerApi(configuration);

            try
            {
                var request = new GetSupportedFileFormatsRequest();

                // Get supported file formats
                var response = apiInstance.GetSupportedFileFormats(request);

                foreach (var format in response.Formats)
                {
                    Debug.Print(format.ToString());
                }
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewerApi.DeleteFontsCache: " + e.Message);
            }

        }
    }
}
```

# Licensing
All GroupDocs.Viewer for Cloud SDKs are licensed under [MIT License](LICENSE).

# Resources
+ [**Website**](https://www.groupdocs.cloud)
+ [**Product Home**](https://products.groupdocs.cloud/viewer/cloud)
+ [**Documentation**](https://docs.groupdocs.cloud/display/viewercloud/Home)
+ [**Free Support Forum**](https://forum.groupdocs.cloud/c/viewer)
+ [**Paid Support Helpdesk**](https://helpdesk.groupdocs.cloud)
+ [**Blog**](https://blog.groupdocs.cloud/category/groupdocs-products/groupdocs-viewer-product-family)