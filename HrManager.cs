using HackathonConsole.Strategies;

namespace HackathonConsole;

public class HrManager
{
   private ITeamBuildingStrategy _strategy;

   public HrManager(ITeamBuildingStrategy strategy)
   {
      _strategy = strategy;
   }

   public List<Team> BuildTeams(
      List<EmployeeWishList> teamLeadWishLists,
      List<EmployeeWishList> juniorWishLists)
   {
      return _strategy.BuildTeams(teamLeadWishLists, juniorWishLists);
   }

   public void ResetStrategy(ITeamBuildingStrategy strategy)
   {
      _strategy = strategy;
   }
}