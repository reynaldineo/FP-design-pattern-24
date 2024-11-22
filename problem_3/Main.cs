using System;

public class MainClass
{
    public static void Main(string[] args)
    {
        UserProduct myUser = new UserProduct("Dahyun", "dahyun@gmail.com", null, null);
        UserProduct myProduct = new UserProduct(null, null, "Ice Cream", 10);

        myUser.AddToDatabase("user");
        myProduct.AddToDatabase("product");

        Console.WriteLine("My user: " + myUser.Name + " with email: " + myUser.Email);
        Console.WriteLine("My product: " + myProduct.ProductName + " with quantity: " + myProduct.Quantity + '\n');

        // TODO: need to add Order to database
    }
}

public class UserProduct
{
    public string Name { get; set; }
    public string Email { get; set; }
    
    public string ProductName { get; set; }
    public int Quantity { get; set; }

    public UserProduct(string name, string email, string productName, int? quantity)
    {
        Name = name;
        Email = email;
        ProductName = productName;
        Quantity = quantity ?? 0;  // Default to 0 if quantity is null
    }

    public void AddToDatabase(string type)
    {
        var connection = new DatabaseConnection("jdbc:mysql://localhost:3306/mydatabase", "admin", "rahasia");
        connection.Connect();

        if (type == "user")
        {
            connection.Query($"INSERT INTO users (name, email) VALUES ('{Name}', '{Email}')");
        }
        else
        {
            connection.Query($"INSERT INTO products (name, quantity) VALUES ('{ProductName}', {Quantity})");
        }
    }
}
