public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagrams = new();

        foreach (string word in strs)
        {
            // Tworze tablice do zliczania wystapien liter ktora wyglada tak: [a:0, b:0, c:0, ..., z:0]
            int[] charCount = new int[26];

            foreach (char c in word)
            {
                // Dzieki temu, dla kaÅ¼dej wystepujacej litery w stringu, zwiekszam odpowiednia pozycje w tablicy o 1
                charCount[c - 'a'] += 1;
                // dla slowa "tak", tablica bedzie wygladac tak: [a:1, b:0, c:0, ..., k:1, t:1, ..., z:0]
                // tak na prawde wyglada raczej tak: [1,0,0,0,1,1...], poniewaz w tablicy nie znajduja sie litery
            }

            //WAÅ»NE: jako Å¼e suma ad i bc jest taka sama
            //W zwiazku z tym z charCount musze zrobic stringa, zeby moc go uzyc jako klucz w slowniku

            StringBuilder keyBuilder = new();
            for (int i = 0; i < charCount.Length; i++)
            {
                keyBuilder.Append('#'); // separator
                keyBuilder.Append(charCount[i]);
                // Koncowo dostaje: #1#0#2#1...#3#0
            }
            string key = keyBuilder.ToString();

            if (!anagrams.ContainsKey(key))
            {
                anagrams[key] = new List<string>();
                //przyklad: "#1#0#0#0#0#0#0#0#0#0#1#0#0#0#0#0#0#0#0#1#0#0#0#0#0#0": []
            }
            anagrams[key].Add(word);
            //przyklad: "#1#0#0#0#0#0#0#0#0#0#1#0#0#0#0#0#0#0#0#1#0#0#0#0#0#0": ["tak"]
        
        }
        return new List<IList<string>>(anagrams.Values);

    }
}