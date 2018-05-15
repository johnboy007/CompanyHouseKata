using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyHouseApp.Services
{
    public class CompanyHouse
    {
        private string Name { get; }
        public CompanyHouse(string name)
        {
            this.Name = name;
        }

        public List<Models.CompanyHouse> GetList()
        {
            var lstCompanyHouse = new List<Models.CompanyHouse>();
            return lstCompanyHouse;
        }
    }
}