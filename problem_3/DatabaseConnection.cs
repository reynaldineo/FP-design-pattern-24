using System;

public class DatabaseConnection
{
    public string ConnectionString { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public DatabaseConnection(string connectionString, string username, string password)
    {
        ConnectionString = connectionString;
        Username = username;
        Password = password;
    }

    public void Connect()
    {
        Console.WriteLine("Connecting to database...");
    }

    public void Query(string query)
    {
        Console.WriteLine("Executing query: " + query);
    }
}
