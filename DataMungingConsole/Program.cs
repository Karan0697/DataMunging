// See https://aka.ms/new-console-template for more information


using DataMungingConsole.Services;

Console.WriteLine("Processing weather...");

var ws = new WeatherService();
Console.WriteLine(ws.GetSmallestTempSpread());

Console.WriteLine("Processing soccer league...");

var sl = new SoccerLeagueService();
Console.WriteLine(sl.GetSmallestDifferenceInGoal());


Console.ReadLine();
