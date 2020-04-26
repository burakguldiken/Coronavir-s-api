using coronastatistic.Entity;
using coronastatistic.Interfaces;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coronastatistic.Services
{
    public class SCorona : ICorona
    {
        public string totalGlobalData()
        {
            var client = new RestClient("https://thevirustracker.com/free-api?global=stats");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "__cfduid=d8454acd5f95ccaa4ee3f29ac8b47a47e1587901321");
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        public string allTimeData()
        {
            var client = new RestClient("https://thevirustracker.com/timeline/map-data.json");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Cookie", "__cfduid=d8454acd5f95ccaa4ee3f29ac8b47a47e1587901321");
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
