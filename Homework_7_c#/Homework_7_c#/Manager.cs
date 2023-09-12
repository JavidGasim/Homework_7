namespace Homework_7_c_;

internal class Manager : IOrgaNize
{
    Guid guid { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }

    public Manager()
    {

    }

    public Manager(string name, string surname, int age, string position, double salary)
    {
        this.guid = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Age = age;
        Position = position;
        Salary = salary;
    }

    public void Organize()
    {
        Console.WriteLine("Organize");
    }

    public void CalculateSalaries()
    {
        Console.WriteLine("Calculate Salaries");
    }
}
