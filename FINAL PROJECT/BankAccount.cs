using SQLite;

public class BankAccount
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public int UserId { get; set; }

    public decimal Balance { get; set; }
}
