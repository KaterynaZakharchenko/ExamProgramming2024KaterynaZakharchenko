namespace Utilities;

public static class StringUtilities
{
    public static int LongWordsCount(string str)
    {
        int count = 0;

        foreach (var word in str.Split(" "))
        {
            if word.Length > 2 ) count++;
        }

        return count;
    }

    public static ToSpinalCase(string str)
    {
        var words = str.Split();
        foreach (var word in words)
            word = word.ToLower();

        return string.Join("-", words);
    }

    public static string ToPascalCase(string str)
    {
        string[] words = str.Split(' ');
        foreach (var word in words)
        {
            word = char.ToUpper(word[0]) + word[1..].ToLower();
        }
        return string.Join("", words);
    }
}