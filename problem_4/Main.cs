using System;

public class Program
{
    public static void Main(string[] args)
    {
        OrderMeal dahyunOrder = new OrderMeal("Kim Dahyun", "specialBundle", "🍷", null, 1);
        OrderMeal yunusOrder = new OrderMeal("Muhammad Dahyunus", "happyBundle", null, "🍰", 2);
        OrderMeal windikOrder = new OrderMeal("Windik Pambudhi", "reguler", null, null, 3);

        dahyunOrder.ProcessOrder();
        yunusOrder.ProcessOrder();
        windikOrder.ProcessOrder();
    }
}

public class OrderMeal
{
    public string Buyer { get; set; }
    public string Type { get; set; }
    public string Drink { get; set; }
    public string Dessert { get; set; }
    public int Amount { get; set; }

    public OrderMeal(string buyer, string type, string drink, string dessert, int amount)
    {
        Buyer = buyer;
        Type = type;
        Drink = drink;
        Dessert = dessert;
        Amount = amount;
    }

    public void ProcessOrder()
    {
        if (Type == "specialBundle")
        {
            Console.WriteLine($"[ Order for mr./mrs. {Buyer} ]");
            // Drink can be selected by the buyer
            Console.WriteLine($"| Meal: {Drink} + 🍚🍔 + 🍨");
            Console.WriteLine("----------------------");
            Console.WriteLine($"{Amount} * Rp12000");
            Console.WriteLine("| Price: 12000");
            Console.WriteLine("=====================");
            
            int total = Amount * 12000;
            Console.WriteLine($"| TOTAL: Rp{total}\n\n");

        }
        else if (Type == "happyBundle")
        {
            Console.WriteLine($"[ Order for mr./mrs. {Buyer} ]");
            // Dessert can be selected by the buyer
            Console.WriteLine($"| Meal: 🍵 + 🍜 + {Dessert}");
            Console.WriteLine("----------------------");
            Console.WriteLine($"{Amount} * Rp10000");
            Console.WriteLine("| Price: 10000");
            Console.WriteLine("=====================");
            
            int total = Amount * 10000;
            Console.WriteLine($"| TOTAL: Rp{total}\n\n");
        }
        else
        {
            Console.WriteLine($"[ Order for mr./mrs. {Buyer} ]");
            // No selection available
            Console.WriteLine("| Drink: 🍵 + 🌭 + 🍮");
            Console.WriteLine("----------------------");
            Console.WriteLine($"{Amount} * Rp8000");
            Console.WriteLine("| Price: 8000");
            Console.WriteLine("=====================");
            
            int total = Amount * 8000;
            Console.WriteLine($"| TOTAL: Rp{total}\n\n");
        }

        // TODO: need new order type (new packet)
    }
}
