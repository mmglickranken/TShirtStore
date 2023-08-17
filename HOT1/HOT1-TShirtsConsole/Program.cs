using System;
using System.Xml.Linq;
using System.Xml.Schema;
using static System.Console;

namespace HOT1_ConverterGUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string street = "";
            string city = "";
            string state = "";
            string zip = "";
            int quantity = 0;
            const decimal TSHIRT = 14.99m;
            const decimal TAXRATE = 0.08m;
    

            Write("Enter your name: ");
            name = Console.ReadLine().ToString();

            Write("Street adress: ");
            street = Console.ReadLine().ToString();

            Write("City: ");
            city = Console.ReadLine().ToString();

            Write("State: ");
            state = Console.ReadLine().ToString();

            Write("Zip: ");
            zip = Console.ReadLine().ToString();

            Write("How many T-Shirts did you want to order? ");
            quantity = Convert.ToInt32(Console.ReadLine());

            Write("\n\nReceipt for:");
            Write("\n" + name);
            Write("\n" + street);
            Write("\n" + city + ", " + state + " " + zip + "\n");

            Write(quantity.ToString() + " T-Shirts ordered @ " 
            + TSHIRT.ToString() + " each \n");

            decimal total = TSHIRT * quantity;
            decimal taxTotal = TAXRATE * total;
            Write("\nTotal:\t" + total.ToString("c"));
            Write("\nTax:\t" + taxTotal.ToString("c"));
            Write("\n-----------------------------");

            decimal subtotal = total + taxTotal;
            Write("\nDue:\t" + subtotal.ToString("c"));
            Write("\nPress enter to exit");
            ReadLine();
        }
    }
}
