using System;

class Program
{
    // Function to process each item 
    static int ProcessItem(string itemName, int stock) 
    { 
        Console.WriteLine("\nHow many " + itemName + "s have been sold today? (Stock: " + stock + ")"); 
        int sold;

        // Validate user input
        while(!int.TryParse(Console.ReadLine(), out sold) || sold < 0) 
        { 
            Console.WriteLine("❌ Invalid input! Please enter a valid non-negative number."); 
        }

        // Check if sold quantity exceeds stock
        if (sold > stock) 
        { 
            Console.WriteLine("❌ Too high! Only " + stock + " " + itemName + "s in stock."); 
        } 
        else 
        { 
            stock -= sold; 
            Console.WriteLine("✅ Remaining " + itemName + " stock: " + stock); 
        }
        return stock; 
    }
    
    static void Main()
    {
        int stock = 100; // example starting stock
        string itemName = "Item"; // example item name
        stock = ProcessItem(itemName, stock); // call the function
    }
}
