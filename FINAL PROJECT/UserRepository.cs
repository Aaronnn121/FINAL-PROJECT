using SQLite;
using System.Collections.Generic;

public class UserRepository
{
    private SQLiteConnection db = Database.GetConnection();

    public int Add(User user)
    {
        db.Insert(user);
        return user.Id;
    }

    public List<User> GetAll()
    {
        return db.Table<User>().ToList();
    }

    public User Get(int id)
    {
        return db.Find<User>(id);
    }

    public void Update(User user)
    {
        db.Update(user);
    }

    public void Delete(int id)
    {
        var u = Get(id);
        if (u != null) db.Delete(u);
    }

    public User GetByUsername(string username)
    {
        return db.Table<User>().FirstOrDefault(x => x.Username == username);
    }
}
