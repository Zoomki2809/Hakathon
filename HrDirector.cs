namespace HackathonConsole;

public class HrDirector
{
    public double CalculateHarmonicMean(
        List<Team> teams, 
        List<EmployeeWishList> teamLeadWishLists,
        List<EmployeeWishList> juniorWishLists)
    {
        var harmonicSum = 0D;
        
        foreach (var team in teams)
        {
            var juniorSatisfactionLevel =
                Hackathon.AmountOfEmployees -
                juniorWishLists.First(x => x.Owner == team.Junior).WishList[team.TeamLead];
            var teamLeadSatisfactionLevel =
                Hackathon.AmountOfEmployees -
                teamLeadWishLists.First(x => x.Owner == team.TeamLead).WishList[team.Junior];

            harmonicSum += 1D / juniorSatisfactionLevel;
            harmonicSum += 1D / teamLeadSatisfactionLevel;
        }
        
        return Hackathon.AmountOfEmployees * 2 / harmonicSum;
    }
}