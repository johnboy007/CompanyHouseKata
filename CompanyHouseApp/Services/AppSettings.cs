using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyHouseApp.Services
{
    public static class AppSettings
    {
        public static string GetAppSetting(string key)
        {
            return System.Configuration.ConfigurationManager.AppSettings[key];
        }
       
    }
}