using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyHouseApp.Services
{
    public interface ICompanyHouse
    {
        List<Models.CompanyHouse> GetList();
    }
}