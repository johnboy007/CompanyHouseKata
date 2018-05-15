using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CompanyHouseApp.Services
{
    public static class Csv
    {
        public static string Read()
        {
            try
            {
                return File.ReadAllText("https://s3-eu-west-1.amazonaws.com/stageu/abstag/ch.csv");
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}