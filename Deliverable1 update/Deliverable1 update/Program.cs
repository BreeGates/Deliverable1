using System;

class Program
{
    // Function to process each item and return the number of items sold
    static int ProcessItem(string itemName, int stock)
    {
        Console.WriteLine($"\nHow many {itemName}s have been sold today? (Stock: {stock})");
        int sold;

        // Handle invalid inputs
        while (!int.TryParse(Console.ReadLine(), out sold) || sold < 0)
        {
            Console.WriteLine("❌ Invalid input! Please enter a non-negative number.");
        }

        return sold;
    }

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
        int sodasSold = ProcessItem("soda", sodaStock);
        if (sodasSold > sodaStock)
        {
            Console.WriteLine("❌ Too high! Not enough sodas in stock.");
        }
        else
        {
            sodaStock -= sodasSold;
            Console.WriteLine($"✅ Remaining soda stock: {sodaStock}");
        }

        // Process Chips
        int chipsSold = ProcessItem("chips", chipsStock);
        if (chipsSold > chipsStock)
        {
            Console.WriteLine("❌ Too high! Not enough chips in stock.");
        }
        else
        {
            chipsStock -= chipsSold;
            Console.WriteLine($"✅ Remaining chips stock: {chipsStock}");
        }

        // Process Candy
        int candiesSold = ProcessItem("candy", candyStock);
        if (candiesSold > candyStock)
        {
            Console.WriteLine("❌ Too high! Not enough candies in stock.");
        }
        else
        {
            candyStock -= candiesSold;
            Console.WriteLine($"✅ Remaining candy stock: {candyStock}");
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
        Console.WriteLine($"\n📦 Total Stock Remaining: {totalStock}");

        // Ensure correct totals after processing all items
        Console.WriteLine($"\nExact totals:");
        Console.WriteLine($"Soda Remaining: {sodaStock}");
        Console.WriteLine($"Chips Remaining: {chipsStock}");
        Console.WriteLine($"Candy Remaining: {candyStock}");
        Console.WriteLine($"Total Stock Remaining: {totalStock}");
    }
}
