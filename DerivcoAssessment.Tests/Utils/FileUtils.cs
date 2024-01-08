namespace DerivcoAssessment.Tests.Utils;

public static class FileUtils
{
    public static string ReadFile(string fileName)
    {
        return File.ReadAllText($"Problems/Fixtures/TestData/{fileName}");
    }
}
