using DerivcoAssessment.ProblemSolvers.Abstract;

namespace DerivcoAssessment.ProblemSolvers;

public class ProblemA : ISolveProblems<string>
{
    public string Solve(string input)
    {
        return input
            .Split(' ')
            .GroupBy(w => w)
            .Select(g => (Word: g.Key, Count: g.Count()))
            .Any(g => g.Count != 1) ? "no" : "yes";
    }
}
