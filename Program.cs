using System;

class Program
{
    // Function to process each item 
    static int ProcessItem(string itemName, int stock) 
    { 
        Console.WriteLine("\nHow many " + itemName + "s have been sold today? (Stock: " + stock + ")"); 
        int sold;

 using System;

public class Program
{
    public static void Main()
    {
        // Initial stock values
        int sodaStock = 100;
        int chipsStock = 40;
        int candyStock = 60;

        // Restock values
        int sodaRestock = 40;
        int chipsRestock = 20;
        int candyRestock = 40;

        // Process Soda
        Console.WriteLine("How many sodas have been sold today? (Stock: 100)");
        int sodasSold;
        
        while (!int.TryParse(Console.ReadLine(), out sodasSold) || sodasSold < 0)
        {
            Console.WriteLine("❌ Invalid input! Please enter a non-negative number.");
        }

        if (sodasSold > sodaStock)
        {
            Console.WriteLine("❌ Too high! Not enough sodas in stock.");
        }
        else
        {
            sodaStock -= sodasSold;
            Console.WriteLine("✅ Remaining soda stock: {sodaStock}");
        }

        // Process Chips
        Console.WriteLine("\nHow many chips have been sold today? (Stock: 40)");
        int chipsSold;
        
        while (!int.TryParse(Console.ReadLine(), out chipsSold) || chipsSold < 0)
        {
            Console.WriteLine("❌ Invalid input! Please enter a non-negative number.");
        }

        if (chipsSold > chipsStock)
        {
            Console.WriteLine("❌ Too high! Not enough chips in stock.");
        }
        else
        {
            chipsStock -= chipsSold;
            Console.WriteLine("✅ Remaining chips stock: {chipsStock}");
        }

        // Process Candy
        Console.WriteLine("\nHow many candies have been sold today? (Stock: 60)");
        int candiesSold;
        
        while (!int.TryParse(Console.ReadLine(), out candiesSold) || candiesSold < 0)
        {
            Console.WriteLine("❌ Invalid input! Please enter a non-negative number.");
        }

        if (candiesSold > candyStock)
        {
            Console.WriteLine("❌ Too high! Not enough candies in stock.");
        }
        else
        {
            candyStock -= candiesSold;
            Console.WriteLine("✅ Remaining candy stock: {candyStock}");
        }

        // Check if restock is needed
        if (sodaStock <= sodaRestock)
        {
            Console.WriteLine("⚠️ Soda needs to be restocked.");
        }
        if (chipsStock <= chipsRestock)
        {
            Console.WriteLine("⚠️ Chips need to be restocked.");
        }
        if (candyStock <= candyRestock)
        {
            Console.WriteLine("⚠️ Candy needs to be restocked.");
        }

        // Compute total remaining stock
        int totalStock = sodaStock + chipsStock + candyStock;
        Console.WriteLine("\n📦 Total Stock Remaining: {totalStock}");
    }
}
