using SQLite;

public class User
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Fullname { get; set; }

    public string Username { get; set; }

    // New: store hashed password
    public string PasswordHash { get; set; }
}
