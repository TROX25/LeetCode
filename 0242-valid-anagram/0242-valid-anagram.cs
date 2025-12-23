public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        /*List <char> match = new();
        int matchS = 0;
        int matchT = 0;
        for (int i=0; i<s.Length; i++)
        {
            if (t.Contains(s[i]))
            {
                match.Add(s[i]);
                matchS += (int)s[i];
            }
        }
        for (int i=0; i<t.Length; i++)
        {
            matchT += (int)t[i];
        }
        if (matchT == matchS && match.Count == s.Length && s.Length == t.Length)
        {
            return true;
        }
        return false; */
        
        Dictionary<char,int> matchS = new();
        Dictionary<char,int> matchT = new();
        if (s.Length != t.Length)
        {
            return false;
        }
        for (int i=0; i<s.Length; i++)
        {
            if (matchS.ContainsKey(s[i]))
            {
                //.Value only for keyValue Pair (used when using foreach for dict)
                //match.Value += 1
                matchS[s[i]] += 1;
            }
            else
            {
                matchS.Add(s[i],1);
            }

            if (matchT.ContainsKey(t[i]))
            {
                matchT[t[i]] += 1;
            }
            else
            {
                matchT.Add(t[i],1);
            }
            
        }
            SortedDictionary<char, int> sortedDictS = new SortedDictionary<char, int>(matchS);
            SortedDictionary<char, int> sortedDictT = new SortedDictionary<char, int>(matchT);
            var listS = sortedDictS.ToList();
            var listT = sortedDictT.ToList();
            
            for (int i = 0; i < listS.Count; i++)
            {
                if (listS[i].Key != listT[i].Key || listS[i].Value != listT[i].Value)
                {
                    return false;
                }
            }
            return true;
        
    }
}