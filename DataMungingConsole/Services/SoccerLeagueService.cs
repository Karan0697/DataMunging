using DataMungingConsole.Common;

namespace DataMungingConsole.Services
{
    internal class SoccerLeagueService : BaseService
    {
            public string GetSmallestDifferenceInGoal()
            {
                return GetSmallestDifference("DatFiles/football.dat", 6, 8, 1, Array.Empty<string>()); 

            }
        } 
}
