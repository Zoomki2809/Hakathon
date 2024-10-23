namespace HackathonConsole;

public class Hackathon
{
    public const int AmountOfEmployees = 20;
    
    public (List<EmployeeWishList> teamLeadWishLists, List<EmployeeWishList> juniorWishLists) Start(List<Employee> teamLeads, List<Employee> juniors)
    {
        var teamLeadWishLists = new List<EmployeeWishList>();
        var juniorWishLists = new List<EmployeeWishList>();

        for (var i = 0; i < AmountOfEmployees; i++)
        {
            teamLeadWishLists.Add(teamLeads[i].GetWishList(juniors.ToArray()));
            juniorWishLists.Add(juniors[i].GetWishList(teamLeads.ToArray()));
        }

        return (teamLeadWishLists, juniorWishLists);
    }
}