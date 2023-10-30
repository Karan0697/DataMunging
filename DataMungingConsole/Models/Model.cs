using DataMungingConsole.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMungingConsole.Models
{
    internal class Model
    {
        public Model()
        {

        }
        public Model(string[] row, int maxIndex, int minIndex, int displayIndex)
        {
            Display = row[displayIndex];
            Max = row[maxIndex].ToInt();
            Min = row[minIndex].ToInt();
        }

        public string? Display { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public int Difference { get { return Math.Abs(Max - Min); } }
    }
}
