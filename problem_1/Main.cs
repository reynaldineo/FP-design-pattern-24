using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<object> payments = new List<object>();
        payments.Add(new BankPayment("BanCrud", "12345", 130000));
        payments.Add(new BankPayment("BanCrud Syariah", "12345", 130000));
        payments.Add(new EwalletPayment("Copeepay", "081234567890", 200000));
        payments.Add(new EwalletPayment("Jopay", "081234567891", 250000));

        for (int i = 0; i < payments.Count; i++)
        {
            Console.WriteLine("Order number " + (i + 1));
            PaymentGateway(payments[i]);
        }
    }

    public static void PaymentGateway(object payment)
    {
        if (payment is BankPayment bankPayment)
        {
            bankPayment.ProcessBankPayment();
        }
        else if (payment is EwalletPayment ewalletPayment)
        {
            ewalletPayment.ProcessEwalletPayment();
        }
    }
}

public class BankPayment
{
    private string BankName { get; set; }
    private string BankNumber { get; set; }
    private int Amount { get; set; }

    public BankPayment(string bankName, string bankNumber, int amount)
    {
        BankName = bankName;
        BankNumber = bankNumber;
        Amount = amount;
    }

    public void ProcessBankPayment()
    {
        Console.WriteLine("Using Bank payment!");
        Console.WriteLine($"Bank name: {BankName}\nBank number: {BankNumber}\nAmount: {Amount}\n");
    }
}

public class EwalletPayment
{
    private string EwalletName { get; set; }
    private string PhoneNumber { get; set; }
    private int Amount { get; set; }

    public EwalletPayment(string ewalletName, string phoneNumber, int amount)
    {
        EwalletName = ewalletName;
        PhoneNumber = phoneNumber;
        Amount = amount;
    }

    public void ProcessEwalletPayment()
    {
        Console.WriteLine("Using Ewallet payment!");
        Console.WriteLine($"Provider: {EwalletName}\nPhone Number: {PhoneNumber}\nAmount: {Amount}\n");
    }
}

// TODO: need emoney payment