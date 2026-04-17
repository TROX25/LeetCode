public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        int[] mostFrequent = 
        nums
            .GroupBy(x => x) 
            .OrderByDescending(g => g.Count())
            .Select(group => group.Key)
            .Take(k)
            .ToArray();
            
       return mostFrequent; 
    }
}
