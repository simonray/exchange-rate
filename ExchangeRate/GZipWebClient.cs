// Copyright ©2017 Simonray (http://github.com/simonray). All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

//http://stackoverflow.com/questions/4567313/uncompressing-gzip-response-from-webclient
namespace System.Net
{
    /// <exclude/>
    public class GZipWebClient : WebClient
    {
        /// <exclude/>
        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);
            request.Proxy = null;
            if (request.GetType() == typeof(HttpWebRequest))
                ((HttpWebRequest)request).AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            return request;
        }
    }
}
