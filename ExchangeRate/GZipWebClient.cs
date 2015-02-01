using System;
using System.Net;

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
