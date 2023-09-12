namespace Homework_7_c_;

internal class Worker
{
    Guid guid { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }
    public DateOnly startTime { get; set; }
    public DateOnly endTime { get; set; }
    public Operation[] operations;

    public Worker()
    {

    }

    public Worker(string name, string surname, int age, string position, double salary, DateOnly startTime, DateOnly endTime, Operation[] operations)
    {
        this.guid = Guid.NewGuid();
        Name = name;
        Surname = surname;
        Age = age;
        Position = position;
        Salary = salary;
        this.startTime = startTime;
        this.endTime = endTime;
        this.operations = operations;
    }

    public void AddOperation()
    {
        Array.Resize(ref operations, operations.Length+1);
        Operation operation = new();
        operations[operations.Length-1] = operation;
    }
}
