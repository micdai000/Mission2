// See https://aka.ms/new-console-template for more information
using Mission2;

public class Program
{
    public static void Main()
    {
        Calculate c = new Calculate();
        
        int num = 0;
        
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate? ");
        num = int.Parse(Console.ReadLine());

        int[] rollResults = c.Simulate(num);  // Get the array back
        
        // Now print the results
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + num);
        
        for (int i = 0; i < 11; i++)
        {
            int diceSum = i + 2;  // Convert index back to dice sum 
            int count = rollResults[i];
            int percentage = (count * 100) / num;
    
                Console.Write(diceSum + ": ");  // Print "7: " for example
    
                for (int j = 0; j < percentage; j++)
                {
                    Console.Write("*");  // Write, not WriteLine (so they're on same line)
                }
                
            Console.WriteLine();  // Move to next line
        }
    }
}