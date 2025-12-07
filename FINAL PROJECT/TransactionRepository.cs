using System.Collections.Generic;
using System.Linq;
using SQLite;

public class TransactionRepository
{
    private SQLiteConnection db = Database.GetConnection();

    public int Add(Transaction tx)
    {
        db.Insert(tx);
        return tx.Id;
    }

    public List<Transaction> GetByUser(int userId)
    {
        return db.Table<Transaction>()
                 .Where(t => t.UserId == userId)
                 .OrderByDescending(t => t.CreatedAt)
                 .ToList();
    }

    public List<Transaction> GetByAccount(int accountId)
    {
        return db.Table<Transaction>()
                 .Where(t => t.AccountId == accountId)
                 .OrderByDescending(t => t.CreatedAt)
                 .ToList();
    }

    public void DeleteByAccount(int accountId)
    {
        var items = db.Table<Transaction>().Where(t => t.AccountId == accountId).ToList();
        foreach (var it in items) db.Delete(it);
    }

    public void DeleteByUser(int userId)
    {
        var items = db.Table<Transaction>().Where(t => t.UserId == userId).ToList();
        foreach (var it in items) db.Delete(it);
    }
}
