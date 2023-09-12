namespace Homework_7_c_;

internal class BANK
{
    public string Name { get; set; }
    public int Budget { get; set; }
    public CEO[] ceos;
    public Worker[] workers;
    public Manager[] manager;
    public Client[] clients;
    public Credit[] credit;

    public BANK()
    {

    }

    public BANK(string name, int budget, CEO[] ceos, Worker[] workers, Manager[] manager, Client[] clients, Credit[] credit)
    {
        Name = name;
        Budget = budget;
        this.ceos = ceos;
        this.workers = workers;
        this.manager = manager;
        this.clients = clients;
        this.credit = credit;
    }

    public void showClientCredit()
    {
        for (int i = 0; i < clients.Length; i++)
        {
            Console.WriteLine("Name: " + clients[i].Name);
            Console.WriteLine("Surname: " + clients[i].Surname);
            Console.WriteLine("Age: " + clients[i].Age);
            Console.WriteLine("Live Address: " + clients[i].Live_adress);
            Console.WriteLine("Work Address: " + clients[i].Work_adress);
            Console.WriteLine("Salary: " + clients[i].Salary);
        }
    }

    public void payCredit()
    {
        for (int i = 0; i < clients.Length; i++)
        {
            if ((clients[i].Salary / 2) > (credit[i].amount/credit[i].months))
            {
                Console.WriteLine(clients[i].Name + "Kredit dusur");
            }

            else
            {
                Console.WriteLine(clients[i].Name + "Kredit dusmur");
            }
        }
    }
}