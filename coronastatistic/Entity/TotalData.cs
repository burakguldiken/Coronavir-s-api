using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coronastatistic.Entity
{
    public class TotalData
    {
        public class Tempetures
        {
            [JsonProperty("results")]
            public Result[] Results { get; set; }

            [JsonProperty("stat")]
            public string Stat { get; set; }
        }

        public class Result
        {
            [JsonProperty("total_cases")]
            public long TotalCases { get; set; }

            [JsonProperty("total_recovered")]
            public long TotalRecovered { get; set; }

            [JsonProperty("total_unresolved")]
            public long TotalUnresolved { get; set; }

            [JsonProperty("total_deaths")]
            public long TotalDeaths { get; set; }

            [JsonProperty("total_new_cases_today")]
            public long TotalNewCasesToday { get; set; }

            [JsonProperty("total_new_deaths_today")]
            public long TotalNewDeathsToday { get; set; }

            [JsonProperty("total_active_cases")]
            public long TotalActiveCases { get; set; }

            [JsonProperty("total_serious_cases")]
            public long TotalSeriousCases { get; set; }

            [JsonProperty("total_affected_countries")]
            public long TotalAffectedCountries { get; set; }

            [JsonProperty("source")]
            public Source Source { get; set; }
        }

        public class Source
        {
            [JsonProperty("url")]
            public Uri Url { get; set; }
        }
    }
}
