using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Web;

namespace CompanyHouseApp.Services
{
    public static class WebRequestHelper
    {

        public static string GetHttpWebRequestJson(string strPostUrl, WebHeaderCollection objWebHeaderCollection = null)
        {
            return ExecuteHttpWebRequest(strPostUrl, null, null, null, "GET", "application/json", objWebHeaderCollection);
        }
        

        private static bool AcceptAllCertifications(object sender, X509Certificate certification, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
        private static string ExecuteHttpWebRequest(string strPostUrl, string strRequest, string strCredentialsUsername, string strCredentialsPassword, string strMethod, string strContentType, NameValueCollection objWebHeaderCollection = null)
        {
            try
            {
                if (strRequest == null) strRequest = "";

                ServicePointManager.ServerCertificateValidationCallback = AcceptAllCertifications;
                var objHttpWebRequest = (HttpWebRequest)WebRequest.Create(strPostUrl);
                if (!string.IsNullOrEmpty(strCredentialsUsername) && !string.IsNullOrEmpty(strCredentialsPassword)) objHttpWebRequest.Credentials = new NetworkCredential(strCredentialsUsername, strCredentialsPassword);
                objHttpWebRequest.Method = strMethod;

                if (strMethod != "GET")
                {
                    objHttpWebRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                    objHttpWebRequest.ContentType = strContentType;
                    objHttpWebRequest.Accept = strContentType;
                    objHttpWebRequest.ContentLength = strRequest.Length;
                    objHttpWebRequest.GetRequestStream().Write(Encoding.UTF8.GetBytes(strRequest), 0, strRequest.Length);
                    objHttpWebRequest.GetRequestStream().Close();
                }
                if (objWebHeaderCollection != null) objHttpWebRequest.Headers.Add(objWebHeaderCollection);
                var objHttpWebResponse = (HttpWebResponse)objHttpWebRequest.GetResponse();
                var objStreamReader = new StreamReader(objHttpWebResponse.GetResponseStream(), Encoding.UTF8);
                var strResponse = objStreamReader.ReadToEnd();
                objStreamReader.Close();
                return strResponse;
            }
            catch (Exception objException)
            {return null;
            }
        }
    }
}