using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompanyHouseApp.Models
{
    public class CompanyHouse
    {
        public string companyName { get; set; }
        public string companyNumber { get; set; }
        public string poBox { get; set; }
        public string addressOne { get; set; }
        public string addressTwo { get; set; }
        public string town { get; set; }
        public string county { get; set; }
        public string country { get; set; }
        public string postCode { get; set; }
        public string category { get; set; }
        public string status { get; set; }
    }
}