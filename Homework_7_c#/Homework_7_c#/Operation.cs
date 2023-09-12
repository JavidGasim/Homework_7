namespace Homework_7_c_;

internal class Operation
{
    Guid guid { get; set; }
    public string process_name { get; set; }
    DateTime operation_time { get; set; }

    public Operation()
    {

    }

    public Operation(string process_name, DateTime operation_time)
    {
        this.guid = Guid.NewGuid();
        this.process_name = process_name;
        this.operation_time = operation_time;
    }
}
