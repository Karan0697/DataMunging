using DataMungingConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMungingConsole.Common
{
    internal abstract class BaseService
    {
        public string GetSmallestDifference(string fileName, int minIndex, int maxIndex, int displayIndex, string[] skipWords)
        {
            var fileRead = new FileRead();
            char[] delimiterChars = { ' ', '\t' };
            var skipFirst = 0;
            var minSpreadWeather = new Model
            {
                Max = int.MaxValue
            };

            foreach (var item in FileRead.Read(fileName))
            {
                if (skipFirst == 0)
                {
                    skipFirst = 1;
                    continue;
                }
                if (item.Trim().Length == 0 || item.Trim().Contains("---"))
                {
                    continue;
                }

                var row = item.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

                if (row.Length > 0)
                {
                    var weather = new Model(row,maxIndex,minIndex,displayIndex);

                    if (skipWords.Any(x =>  weather.Display?.Trim().ToLower() == x.Trim().ToLower()))
                    {
                        continue;
                    }

                    if (minSpreadWeather.Difference > weather.Difference)
                    {
                        minSpreadWeather = weather;
                    }
                }
            }

            return minSpreadWeather.Display ?? string.Empty;
        }
    }
}
