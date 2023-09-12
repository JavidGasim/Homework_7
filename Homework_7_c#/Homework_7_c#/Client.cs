namespace Homework_7_c_;

internal class Client
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Live_adress { get; set; }
    public string Work_adress { get; set; }
    public double Salary { get; set; }

    public Client()
    {
        
    }

    public Client(string Name, string Surname, int Age, string Live_adress, string Work_adress, double Salary)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Age = Age;
        this.Live_adress = Live_adress;
        this.Work_adress = Work_adress;
        this.Salary = Salary;
    }
}
