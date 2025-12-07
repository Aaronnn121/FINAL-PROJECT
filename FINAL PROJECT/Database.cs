using SQLite;
using System;
using System.IO;

public static class Database
{
    private static SQLiteConnection _connection;

    public static SQLiteConnection GetConnection()
    {
        if (_connection == null)
        {
            string path = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "bank_database.db"
            );

            _connection = new SQLiteConnection(path);

            // Create tables if they don't exist
            _connection.CreateTable<User>();
            _connection.CreateTable<BankAccount>();
            _connection.CreateTable<Transaction>();
        }

        return _connection;
    }
}
