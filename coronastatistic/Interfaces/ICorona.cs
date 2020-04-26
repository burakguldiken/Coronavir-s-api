using coronastatistic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coronastatistic.Interfaces
{
    public interface ICorona
    {   
        string totalGlobalData();
        string allTimeData();
    }
}
