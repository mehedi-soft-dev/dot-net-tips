using System.Text.RegularExpressions;

string text = "This is an example sentence";
string pattern = @"\b\w+\b"; // Match individual words

MatchCollection matches = Regex.Matches(text, pattern);

Console.WriteLine("Words found:");
foreach (Match match in matches)
{
    Console.WriteLine(match.Value);
}