// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose Pty Ltd" file="ImageCreateAttachmentPagesCacheRequest.cs">
//  Copyright (c) 2003-2017 Aspose Pty Ltd
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GroupDocs.Viewer.Cloud.Sdk.Model.Requests 
{
  using GroupDocs.Viewer.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="GroupDocs.Viewer.Cloud.Sdk.Api.ViewerApi.ImageCreateAttachmentPagesCache" /> operation.
  /// </summary>  
  public class ImageCreateAttachmentPagesCacheRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCreateAttachmentPagesCacheRequest"/> class.
        /// </summary>        
        public ImageCreateAttachmentPagesCacheRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageCreateAttachmentPagesCacheRequest"/> class.
        /// </summary>
        /// <param name="fileName">The file name.</param>
        /// <param name="attachmentName">The attachment name.</param>
        /// <param name="imageOptions">The image rendering options.</param>
        /// <param name="fontsFolder">The folder with custom fonts in storage.</param>
        /// <param name="folder">The folder which contains specified file in storage.</param>
        /// <param name="storage">The file storage which have to be used.</param>
        public ImageCreateAttachmentPagesCacheRequest(string fileName, string attachmentName, ImageOptions imageOptions = null, string fontsFolder = null, string folder = null, string storage = null)             
        {
            this.FileName = fileName;
            this.AttachmentName = attachmentName;
            this.ImageOptions = imageOptions;
            this.FontsFolder = fontsFolder;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// The file name.
        /// </summary>  
        public string FileName { get; set; }

        /// <summary>
        /// The attachment name.
        /// </summary>  
        public string AttachmentName { get; set; }

        /// <summary>
        /// The image rendering options.
        /// </summary>  
        public ImageOptions ImageOptions { get; set; }

        /// <summary>
        /// The folder with custom fonts in storage.
        /// </summary>  
        public string FontsFolder { get; set; }

        /// <summary>
        /// The folder which contains specified file in storage.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// The file storage which have to be used.
        /// </summary>  
        public string Storage { get; set; }
  }
}
