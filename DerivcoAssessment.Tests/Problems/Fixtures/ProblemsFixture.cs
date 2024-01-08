using DerivcoAssessment.ProblemSolvers;
using DerivcoAssessment.ProblemSolvers.Abstract;

namespace DerivcoAssessment.Tests.Problems.Fixtures;

public class ProblemsFixture
{
    public ISolveProblems<string> ProblemA { get; set; } = new ProblemA();
    public ISolveProblems<string> ProblemB { get; set; } = new ProblemB();
    public ISolveProblems<string> ProblemC { get; set; } = new ProblemC();
}
