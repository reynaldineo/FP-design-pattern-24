using System;

public class Program
{
    public static void Main(string[] args)
    {
        InventoryService inventoryService = new InventoryService();
        PaymentService paymentService = new PaymentService();
        ShippingService shippingService = new ShippingService();
    
        string productId = "BY0N3";
        int quantity = 4;

        string accountNumber = "ACC123";
        int remainingBalance = 450000;
        int amount = 300000;
        
        string shippingAddress = "Indonesia, Surabaya, Sukolilo, Jl. Bumi Marina Perunggu No. 99";

        if (inventoryService.CheckStock(productId, quantity))
        {
            if (paymentService.ProcessPayment(accountNumber, remainingBalance, amount))
            {
                inventoryService.UpdateStock(productId, quantity);
                shippingService.ArrangeShipping(productId, shippingAddress);
                Console.WriteLine("✅ Order placed successfully!");
            }
            else
            {
                Console.WriteLine("❌ Payment failed. Order not placed.");
            }
        }
        else
        {
            Console.WriteLine("❌ Product out of stock. Order not placed.");
        }
    }
}

public class InventoryService
{
    private int stock = 10;

    public bool CheckStock(string productId, int quantity)
    {
        Console.WriteLine($"📋 Checking stock for product: {productId}\n");

        if (stock < quantity)
            return false;

        return true;
    }

    public void UpdateStock(string productId, int quantity)
    {
        Console.WriteLine($"📈 Updating stock for product: {productId} by quantity: {quantity}\n");
    }
}

// TODO: need to add product health checking

public class PaymentService
{
    public bool ProcessPayment(string accountNumber, int remainingBalance, int amount)
    {
        if (remainingBalance < amount)
        {
            Console.WriteLine("Insufficient balance.");
            return false;
        }

        Console.WriteLine($"💲 Processing payment of ${amount} from account: {accountNumber}\n");
        return true;
    }
}

public class ShippingService
{
    public void ArrangeShipping(string productId, string shippingAddress)
    {
        Console.WriteLine($"🎁 Arranging shipping for product: {productId} to address: {shippingAddress}\n");
    }
}
