namespace HackathonConsole;

public class EmployeeWishList
{
    public required Employee Owner { get; set; }

    public required Dictionary<Employee, int> WishList { get; set; }
}