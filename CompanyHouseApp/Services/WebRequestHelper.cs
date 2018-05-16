using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;

namespace CompanyHouseApp.Services
{
    public static class WebRequestHelper
    {
        public static string ExecuteGetWebRequest(string Url, string UserName, string Password)
        {
            try
            {
                var credentials = $"{UserName}:{Password}";
                var bytes = Encoding.ASCII.GetBytes(credentials);
                var base64 = Convert.ToBase64String(bytes);
                var authorization = string.Concat("Basic ", base64);
                var httpWebRequest = (HttpWebRequest) WebRequest.Create(Url);
                httpWebRequest.UseDefaultCredentials = true;
                httpWebRequest.Headers.Add("Authorization", authorization);
                httpWebRequest.Method = "GET";
                var httpWebResponse = (HttpWebResponse) httpWebRequest.GetResponse();
                var streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.UTF8);
                var response = streamReader.ReadToEnd();
                streamReader.Close();
                return response;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}