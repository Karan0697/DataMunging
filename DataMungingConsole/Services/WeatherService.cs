using DataMungingConsole.Common;

namespace DataMungingConsole.Services
{
    internal class WeatherService : BaseService
    {      
        public  string GetSmallestTempSpread()
        {
            return GetSmallestDifference("DatFiles/weather.dat", 2, 1, 0, new string[] { "mo" });

        }
    }  
}
