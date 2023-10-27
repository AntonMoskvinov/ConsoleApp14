using System;
using System.Collections.Generic;

public class Labs
{
    readonly Dictionary<string, TeamResult> teams = new Dictionary<string, TeamResult>();

    public void AddGame(string firstTeamName, int firstTeamGoals, string secondTeamName, int secondTeamGoals)
    {
        teams[firstTeamName] = new TeamResult();
        teams[secondTeamName] = new TeamResult();

        for (int i = 0; i < 2; i++)
        {
            if (firstTeamGoals == secondTeamGoals)
            {
                teams[firstTeamName].Draws = teams[firstTeamName].Draws + 1;
                teams[secondTeamName].Draws = teams[secondTeamName].Draws + 1;
            }
            else if (firstTeamGoals > secondTeamGoals)
            {
                teams[firstTeamName].Wins = teams[firstTeamName].Wins + 1;
                teams[secondTeamName].Loses = teams[secondTeamName].Loses + 1;
            }
            else
            {
                teams[firstTeamName].Loses = teams[firstTeamName].Loses + 1;
                teams[secondTeamName].Wins = teams[secondTeamName].Wins + 1;

            }
            teams[firstTeamName].NumberOfGames = teams[firstTeamName].Draws + teams[firstTeamName].Loses + teams[firstTeamName].Wins;
            teams[secondTeamName].NumberOfGames = teams[secondTeamName].Draws + teams[secondTeamName].Loses + teams[secondTeamName].Wins;
            teams[firstTeamName].SumOfPoints = teams[firstTeamName].Wins * 3 + teams[firstTeamName].Draws * 1;
            teams[secondTeamName].SumOfPoints = teams[secondTeamName].Wins * 3 + teams[secondTeamName].Draws * 1;
        }

    }

    public void GetResult()
    {
        foreach (var key in teams)
        {
            Console.WriteLine($"{key.Key};{key.Value.NumberOfGames};{key.Value.Wins};{key.Value.Draws};{key.Value.Loses};{key.Value.SumOfPoints}");
        }
    }



}

public class TeamResult
{
    public int NumberOfGames { get; set; }
    public int Wins { get; set; }
    public int Loses { get; set; }
    public int Draws { get; set; }
    public int SumOfPoints { get; set; }

}


class Program
{

    public static void Main()
    {
        var z = new Labs();
        z.AddGame("Барселона", 3, "Атлетик Бильбао", 1);
        z.AddGame("Атлетик Бильбао", 1, "Реал", 1);
        z.AddGame("Реал", 0, "Барселона", 2);
        z.GetResult();
    }

}