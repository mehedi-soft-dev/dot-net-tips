namespace ExtensionMethod;

internal static class StringExtension
{
    public static int WordCount(this string str)
    {
        return str.Split(new char[] { ' ', '.', '?' }, 
            StringSplitOptions.RemoveEmptyEntries).Length;
    }
}
