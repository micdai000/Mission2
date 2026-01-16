namespace Mission2;

public class Calculate
{
    public int[] Simulate(int n)
    {
        int[] results = new int[11];  // Index 0-10 represents sums 2-12
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            int die1 = random.Next(1, 7);  // 1-6 inclusive
            int die2 = random.Next(1, 7);  // 1-6 inclusive
            int sum = die1 + die2;  // Sum will be 2-12
            
            results[sum - 2]++;
        }   
        
        return results;  // Send the array back
    }
}