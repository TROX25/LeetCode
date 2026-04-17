public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        int[] mostFrequent = 
        nums
            .GroupBy(x => x) // Grupuje takie same elementy razem (coÅ jak dict ale jest to IEnumerable<IGrouping<TKey, TElement>>)
            .OrderByDescending(g => g.Count()) // sortuje grupy zaczynajac od tej ktÃ³ra ma najwiecej values w sobie 
            .Select(group => group.Key) // wybiera same liczby. Poza .Key jest jeszcze .ToList() wtedy zwraca wszystkie wystapienia [[1,1,1], [2,2]] albo .Count() wtedy zwara iloÅÄ wystÄpien w kaÅ¼dej grupie [3,2,1] dla nums[1,1,1,2,2,3,3], 
            .Take(k) // take wybiera pierwsze k elementÃ³w
            .ToArray(); // zmienia z Ienumerable na Array. Moze byc jeszcze: ToList(), ToHashSet(), First() zwraca int, Last() zwraca int, Count() Liczba elementÃ³w, Sum() suma elementÃ³w, Min() minimum, Max() maximum
            
       return mostFrequent; 
    }
}
