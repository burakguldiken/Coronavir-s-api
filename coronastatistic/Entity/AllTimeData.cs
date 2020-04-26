using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coronastatistic.Entity
{
    public class AllTimeData
    {
        public class AllData
        {
            [JsonProperty("data")]
            public CountryInfo[] data { get; set; }
        }

        public class CountryInfo
        {
            [JsonProperty("countrycode")]
            public string Countrycode { get; set; }

            [JsonProperty("date")]
            public string Date { get; set; }

            [JsonProperty("cases")]
            public long Cases { get; set; }

            [JsonProperty("deaths")]
            public long Deaths { get; set; }

            [JsonProperty("recovered")]
            public long Recovered { get; set; }
        }
    }
}
