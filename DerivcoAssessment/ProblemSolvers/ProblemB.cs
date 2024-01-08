using System.Text;
using DerivcoAssessment.ProblemSolvers.Abstract;

namespace DerivcoAssessment.ProblemSolvers;

public class ProblemB : ISolveProblems<string>
{
    public string Solve(string input)
    {
        var students = GetNames(input)
            .OrderBy(s => s.LastName)
            .ThenBy(s => s.FirstName)
            .ToList();

        var map = students
            .GroupBy(s => s.FirstName)
            .ToDictionary(g => g.Key, g => g.Count());

        var toPrint = new StringBuilder();
        foreach (var student in students)
        {
            if (map[student.FirstName] > 1)
            {
                toPrint.AppendLine($"{student.FirstName} {student.LastName}");
                continue;
            }
            toPrint.AppendLine($"{student.FirstName}");
        }

        return toPrint.ToString();
    }

    private static IEnumerable<(string FirstName, string LastName)> GetNames(string input)
    {
        using var stringReader = new StringReader(input);
        while (stringReader.ReadLine() is { } line)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                break;
            }

            var temp = line.Split(' ');
            yield return (temp[0], temp[1]);
        }
    }
}
