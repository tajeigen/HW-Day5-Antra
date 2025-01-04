namespace Ass02_PracticeArrayString;

public class StringPractice
{
    public void ReverseString(string method)
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();
        if (method == "stack")
        {
            Stack<char> st = new Stack<char>(str);
            string result = "";
            while (st.Count > 0)
            {
                char top = st.Peek();
                result += top;
                st.Pop();
            }
            Console.WriteLine(result);
            
        } else if (method == "stackEz")
        {
            Stack<char> st = new Stack<char>(str);
            Console.WriteLine(string.Join("", st));
        }
        else if (method == "reverseString")
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }
           
    }

    public void ReversePunctuatedSentence(string text)
    {
        char[] separators = { ' ', '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?' };
        var words = new List<string>();
        var positions = new List<string>();
        var currentWord = string.Empty;

        for (int i = 0; i < text.Length; i++)
        {
            if (separators.Contains(text[i]))
            {
                if (currentWord.Length > 0)
                {
                    words.Add(currentWord);
                    currentWord = string.Empty;
                }
                positions.Add(text[i].ToString());
            }
            else
                currentWord += text[i];
        }

        words.Reverse();
        var result = string.Empty;
        int wordIndex = 0;

        for (int i = 0; i < positions.Count; i++)
        {
            if (i < words.Count)
                result += words[wordIndex++];
            result += positions[i];
        }

        Console.WriteLine(result);
    }

    bool IsPalindrome(string str)
    {
        str = str.ToLower();
        return str == new string(str.Reverse().ToArray());
    }
    
    public void PalindromeSentence(string text)
    {
        HashSet<string> palindromes = new HashSet<string>();
        string[] words = text.Split(new[] { ' ', ',', '?', '!', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            if (IsPalindrome(word))
                palindromes.Add(word);
        }

        Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
    }
    public void ParseUrl(string url)
    {
        string[] parts = url.Split(new[] { "://" }, StringSplitOptions.None);
        string protocol = parts.Length >1 ? parts[0] : "";
        string serverAndResources = parts.Length > 1 ? parts[1] : parts[0];
        
        int slashIndex = serverAndResources.IndexOf('/');
        string server = slashIndex>= 0 ? serverAndResources.Substring(0, slashIndex): serverAndResources;
        string resources = slashIndex >= 0 ? serverAndResources.Substring(slashIndex+1) : "";
        
        Console.WriteLine($"[protocol] = \"{protocol}\"\n[server] = \"{server}\"\n[resource] = \"{resources}\"");
    }
}