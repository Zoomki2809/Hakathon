using HackathonConsole.Strategies;

namespace HackathonConsole;

public class Sandbox
{
    public void EmulateHackathon(int amountOfExperiments)
    {
        var teamLeads = ReadEmployees("Teamleads20.csv");
        var juniors = ReadEmployees("Juniors20.csv");

        var hackathon = new Hackathon();
        var hrManager = new HrManager(new SimpleTeamBuildingStrategy());
        var hrDirector = new HrDirector();

        double harmonicMeanSum = 0;
        for (var i = 0; i < amountOfExperiments; i++)
        {
            var hackathonResult = hackathon.Start(teamLeads, juniors);
            var teams = hrManager.BuildTeams(hackathonResult.teamLeadWishLists, hackathonResult.juniorWishLists);
            var harmonicMean = hrDirector.CalculateHarmonicMean(teams, hackathonResult.teamLeadWishLists, hackathonResult.juniorWishLists);
            harmonicMeanSum += harmonicMean;
            
            Console.WriteLine($"Среднее гармоническое эксперимента: {harmonicMean}");
        }
        
        Console.WriteLine($"Среднее арифмитическое средних гармонических: {harmonicMeanSum / amountOfExperiments}");
    }

    private List<Employee> ReadEmployees(string fileName)
    {
        var employees = new List<Employee>();
        
        try
        {
            var lines = File.ReadAllLines(fileName);

            for (var i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(';');

                employees.Add(new Employee(int.Parse(parts[0]), parts[1]));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
        }

        return employees;
    }
}