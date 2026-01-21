namespace Mission2;

public class Calculate
{
    // created a method called Simulate that returns an array
    public int[] Simulate(int n)
    {
        int[] results = new int[11];  // Index 0-10 represents sums 2-12
        Random random = new Random(); 

        for (int i = 0; i < n; i++)
        {
            int die1 = random.Next(1, 7);  // random rolls 1-6 inclusive
            int die2 = random.Next(1, 7);  // random rolls 1-6 inclusive
            int sum = die1 + die2;  // Sum will be 2-12
            
            results[sum - 2]++; // since the dice rolls from 2-12 we take the sum - 2 to get the correct location in the list then add 1
            // to it signifying the number of times that number was rolled
        }   
        
        return results;  // Send the array back
    }
}