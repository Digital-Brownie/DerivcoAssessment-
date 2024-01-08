using DerivcoAssessment.Tests.Utils;

namespace DerivcoAssessment.Tests.Problems.Fixtures.ClassData;

public class ProblemCTestData : TheoryData<string>
{
    private const string TestDataFile = "EverMorsePalindrome.txt";

    public ProblemCTestData()
    {
        using var stringReader = new StringReader(ReadFile(TestDataFile));
        while (stringReader.ReadLine() is { } line)
        {
            Add(line);
        }
    }

    private static string ReadFile(string fileName)
    {
        return FileUtils.ReadFile(fileName);
    }
}
