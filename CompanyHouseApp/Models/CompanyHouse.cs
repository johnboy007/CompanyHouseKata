using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Newtonsoft.Json;

namespace CompanyHouseApp.Models
{

    [Serializable]
    [DataContract]
    public class CompanyHouseItems
    {
        [JsonProperty("items")]
        [DataMember]
        public List<CompanyHouse> items { get; set; }
    }

    [Serializable]
    [DataContract]
    public class CompanyHouse
    {
        [JsonProperty("title")] [DataMember] public string title { get; set; }
        [JsonProperty("company_number")] [DataMember] public string company_number { get; set; }
        [JsonProperty("address")] [DataMember] public CompanyHouseAddress address { get; set; }
        [JsonProperty("company_type")] [DataMember] public string company_type { get; set; }
        [JsonProperty("company_status")] [DataMember] public string company_status { get; set; }
    }
    [Serializable]
    [DataContract]
    public class CompanyHouseAddress
    {
        [JsonProperty("address_line_1")] [DataMember] public string address_line_1 { get; set; }
        [JsonProperty("address_line_2")] [DataMember] public string address_line_2 { get; set; }
        [JsonProperty("locality")] [DataMember] public string locality { get; set; }
        [JsonProperty("region")] [DataMember] public string region { get; set; }
        [JsonProperty("country")] [DataMember] public string country { get; set; }
        [JsonProperty("postal_code")] [DataMember] public string postal_code { get; set; }
    }
}