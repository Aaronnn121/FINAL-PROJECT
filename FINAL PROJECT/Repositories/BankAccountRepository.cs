using SQLite;

public class BankAccountRepository
{
    private SQLiteConnection db = Database.GetConnection();

    public void CreateAccountForUser(int userId)
    {
        var existing = GetByUser(userId);
        if (existing != null) return;

        BankAccount acc = new BankAccount
        {
            UserId = userId,
            Balance = 0m
        };
        db.Insert(acc);
    }

    public BankAccount GetByUser(int userId)
    {
        return db.Table<BankAccount>()
                 .Where(a => a.UserId == userId)
                 .FirstOrDefault();
    }

    public BankAccount GetById(int id)
    {
        return db.Find<BankAccount>(id);
    }

    public void Update(BankAccount account)
    {
        db.Update(account);
    }

    public void Delete(int accountId)
    {
        var a = GetById(accountId);
        if (a != null) db.Delete(a);
    }
}
