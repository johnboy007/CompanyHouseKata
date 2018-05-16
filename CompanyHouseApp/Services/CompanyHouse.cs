using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CompanyHouseApp.Services
{
    public class CompanyHouse : ICompanyHouse
    {
        private string Name { get; }

        public CompanyHouse(string name)
        {
            this.Name = name;
        }

        public List<Models.CompanyHouse> GetList()
        {
            try
            {
                //Get json responce from api
                var json = WebRequestHelper.ExecuteGetWebRequest($"{AppSettings.GetAppSetting("CompanyHouseApiUrl")}={Name}", AppSettings.GetAppSetting("CompanyHouseApiKey"), "");
                var companyHouseItems = JsonConvert.DeserializeObject<Models.CompanyHouseItems>(json);
                return companyHouseItems.items;
            }
            catch (Exception exception)
            {
                return new List<Models.CompanyHouse>();
            }
        }
    }
}