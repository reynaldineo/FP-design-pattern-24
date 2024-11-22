using System;

public class Program
{
    public static void Main(string[] args)
    {
        User user1 = new User("Kim Dahyun", "dahyun@gmail.com", "rahasia-dahyun", "081234567891");
        User user2 = new User("Muhammad Dahyunus", "yunus@gmail.com", "rahasia-yunus", "081234567892");
        User user3 = new User("Windika Pambudhi", "windi@gmail.com", "rahasia-windi", null);

        GetUserName(user1);
        GetUserName(user2);
        GetUserName(user3);
    }

    public static void GetUserName(User user)
    {
        Console.WriteLine("Nama: " + user.Name);
    }
}

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string NomorTelpon { get; set; }
    // TODO: add age

    public User(string name, string email, string password, string nomorTelpon)
    {
        Name = name;
        Email = email;
        Password = password;
        NomorTelpon = nomorTelpon;
    }
}
