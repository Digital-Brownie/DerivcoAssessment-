using DerivcoAssessment.Tests.Problems.Fixtures;
using DerivcoAssessment.Tests.Problems.Fixtures.ClassData;
using FluentAssertions;

namespace DerivcoAssessment.Tests.Problems;

public class UnitTests : IClassFixture<ProblemsFixture>
{
    private readonly ProblemsFixture _fixture;

    public UnitTests(ProblemsFixture fixture)
    {
        _fixture = fixture;
    }

    [Theory]
    [InlineData("THE RAIN IN SPAIN", "yes")]
    [InlineData("IN THE RAIN AND THE SNOW", "no")]
    [InlineData("THE RAIN IN SPAIN IN THE PLAIN", "no")]
    public void ProblemA(string input, string expected)
    {
        _fixture.ProblemA.Solve(input).Should().Be(expected);
    }

    [Theory]
    [ClassData(typeof(ProblemBTestData))]
    public void ProblemB(string input, string expected)
    {
        _fixture.ProblemB.Solve(input).Should().Be(expected);
    }

    [Theory]
    [InlineData("hello", 0)]
    [InlineData("159", 1)]
    [InlineData("Madam I'm Adam", 0)]
    [InlineData("footstool", 1)]
    [InlineData("SOS", 1)]
    [InlineData("A E", 1)]
    public void ProblemC_GivenTestData(string input, int expected)
    {
        _fixture.ProblemC.Solve(input).Should().Be(expected);
    }

    [Theory]
    [ClassData(typeof(ProblemCTestData))]
    public void ProblemC_AllMorsePalindromes(string input)
    {
        _fixture.ProblemC.Solve(input).Should().Be(1);
    }
}
