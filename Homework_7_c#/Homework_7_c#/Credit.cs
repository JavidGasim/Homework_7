namespace Homework_7_c_;

internal class Credit
{
    Guid guid { get; set; }
    public Client client { get; set; }
    public int amount { get; set; }
    public int percent { get; set; }
    public int months { get; set; }

    public Credit()
    {
        
    }

    public Credit(Client client, int amount, int percent, int months)
    {
        this.guid = Guid.NewGuid();
        this.client = client;
        this.amount = amount;
        this.percent = percent;
        this.months = months;
    }
}
