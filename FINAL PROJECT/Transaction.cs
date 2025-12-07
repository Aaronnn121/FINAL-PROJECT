using SQLite;
using System;

public class Transaction
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public int UserId { get; set; }           // owner
    public int AccountId { get; set; }        // bank account id
    public decimal Amount { get; set; }       // positive for deposit, negative for withdraw
    public string Type { get; set; }          // "Deposit" or "Withdraw" or "Transfer"
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Remarks { get; set; }
}
