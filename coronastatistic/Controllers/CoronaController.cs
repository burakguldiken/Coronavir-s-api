using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coronastatistic.Entity;
using coronastatistic.Interfaces;
using coronastatistic.Services;
using Microsoft.AspNetCore.Mvc;
using static coronastatistic.Entity.AllTimeData;
using static coronastatistic.Entity.TotalData;

namespace coronastatistic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoronaController : ControllerBase
    {

        ICorona _SCorona;
        public CoronaController()
        {
            this._SCorona = _SCorona;
        }
        /// <summary>
        /// Get total corona statistics
        /// </summary>
        /// <returns></returns>
        [HttpGet("gettotaldata")]
        public IActionResult Get_Total_Data()
        {
            SCorona corona = new SCorona();
            string result = corona.totalGlobalData();
            Tempetures tempetures = Newtonsoft.Json.JsonConvert.DeserializeObject<Tempetures>(result);
            return new JsonResult(tempetures);
        }

        /// <summary>
        /// Get all time statistics
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("alltimedata")]
        public IActionResult Get_All_Time()
        {
            SCorona corona = new SCorona();
            string result = corona.allTimeData();
            AllData allData = Newtonsoft.Json.JsonConvert.DeserializeObject<AllData>(result);
            return new JsonResult(allData);
        }
    }
}
