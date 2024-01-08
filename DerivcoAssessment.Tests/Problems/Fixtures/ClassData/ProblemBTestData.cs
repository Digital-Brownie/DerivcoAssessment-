using DerivcoAssessment.Tests.Utils;

namespace DerivcoAssessment.Tests.Problems.Fixtures.ClassData;

public class ProblemBTestData : TheoryData<string, string>
{
    private const string TestDataFile = "ProblemBTestData.txt";
    private const string ExpectedDataFile = "ProblemBTestExpected.txt";

    public ProblemBTestData()
    {
        Add(ReadFile(TestDataFile), ReadFile(ExpectedDataFile));
    }

    private static string ReadFile(string fileName)
    {
        return FileUtils.ReadFile(fileName);
    }
}
