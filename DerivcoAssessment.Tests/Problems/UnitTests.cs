using DerivcoAssessment.Tests.Problems.Fixtures;

namespace DerivcoAssessment.Tests.Problems;

public class UnitTests : IClassFixture<ProblemsFixture>
{
    private readonly ProblemsFixture _fixture;

    public UnitTests(ProblemsFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void ProblemA()
    {

    }
}
