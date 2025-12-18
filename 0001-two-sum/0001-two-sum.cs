public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        for (int i=0; i<nums.Length; i++)
        {
            int sub = target - nums[i];
            for(int j = i+1; j<nums.Length ; j++)
            {
                if (sub - nums[j] == 0)
                {
                    return new int[] {i,j};
                }
            }
        }
        return Array.Empty<int>();
        // albo throw new Exception("No solution found");
    }
}