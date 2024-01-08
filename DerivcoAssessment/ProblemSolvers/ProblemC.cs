using System.Text;
using DerivcoAssessment.ProblemSolvers.Abstract;

namespace DerivcoAssessment.ProblemSolvers;

public class ProblemC : ISolveProblems<int>
{
    private static readonly Dictionary<char, string> MorseCodeDictionary = new()
    {
        { 'A', ".-" },
        { 'B', "-..." },
        { 'C', "-.-." },
        { 'D', "-.." },
        { 'E', "." },
        { 'F', "..-." },
        { 'G', "--." },
        { 'H', "...." },
        { 'I', ".." },
        { 'J', ".---" },
        { 'K', "-.-" },
        { 'L', ".-.." },
        { 'M', "--" },
        { 'N', "-." },
        { 'O', "---" },
        { 'P', ".--." },
        { 'Q', "--.-" },
        { 'R', ".-." },
        { 'S', "..." },
        { 'T', "-" },
        { 'U', "..-" },
        { 'V', "...-" },
        { 'W', ".--" },
        { 'X', "-..-" },
        { 'Y', "-.--" },
        { 'Z', "--.." },
        { '0', "-----" },
        { '1', ".----" },
        { '2', "..---" },
        { '3', "...--" },
        { '4', "...-" },
        { '5', "...." },
        { '6', "-...." },
        { '7', "--..." },
        { '8', "---..." },
        { '9', "----." },
    };

    public int Solve(string input)
    {
        if (!Validate(input))
        {
            return 0;
        }

        var morse = ConvertToMorse(input);

        if (!Validate(morse))
        {
            return 0;
        }

        var left = 0;
        var right = (morse.Length - 1);

        while (left < right)
        {
            if (morse[left++] != morse[right--])
            {
                return 0;
            }
        }

        return 1;
    }

    private static bool Validate(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            Console.WriteLine(0);
            return false;
        }

        return true;
    }

    private static string ConvertToMorse(string line)
    {
        return line
            .Trim()
            .Where(char.IsLetterOrDigit)
            .Aggregate(new StringBuilder(), (builder, c) => builder.Append(MorseCodeDictionary[char.ToUpper(c)]))
            .ToString();
    }
}
