using Builder;

internal class Program
{
    private static void Main()
    {
        Worker worker = new Worker();
        Worker worker1 = new Worker();
        Worker worker2 = new Worker();
        Worker worker3 = new Worker();
        House house = new House();
        TeamLead lead = new TeamLead();
        Team team = new Team();
        team.AddWorker(worker);
        team.AddWorker(worker1);
        team.AddWorker(worker2);
        team.AddWorker(worker3);
        for(int i = 0; i < 12; ++i)
        {
            Console.WriteLine(team.Build(house));
            Console.WriteLine("\nОтчет:");
            Console.WriteLine(lead.Works(house));
        }
    }
}