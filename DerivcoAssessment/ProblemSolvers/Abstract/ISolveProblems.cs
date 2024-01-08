namespace DerivcoAssessment.ProblemSolvers.Abstract;

public interface ISolveProblems<out T>
{
    public T Solve(string input);
}
