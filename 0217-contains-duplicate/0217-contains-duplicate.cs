public class Solution 
{
    public bool ContainsDuplicate(int[] nums) 
    {
        HashSet<int> empty = new();
        for (int i=0; i<nums.Length; i++)
        {
            if (empty.Contains(nums[i]))
            {
                return true;
            }
            empty.Add(nums[i]);
            
        }   
        return false;
    }
}