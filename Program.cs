using HackathonConsole;

internal class Program
{
    private static void Main(string[] args)
    {
        var sandbox = new Sandbox();

        sandbox.EmulateHackathon(1000);
    }
}