namespace HackathonConsole;

public class Employee
{
    public int Id { get; private set; }

    public string Name { get; private set; }
    
    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public EmployeeWishList GetWishList(Employee[] employees)
    {
        var wishlist = new Dictionary<Employee, int>();

        var random = new Random();
        random.Shuffle(employees);

        for (var i = 0; i < employees.Length; i++)
        {
            wishlist.Add(employees[i], i);
        }

        return new EmployeeWishList()
        {
            Owner = this,
            WishList = wishlist
        };
    }
}