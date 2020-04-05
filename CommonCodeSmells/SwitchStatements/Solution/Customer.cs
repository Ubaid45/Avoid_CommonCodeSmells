namespace CommonCodeSmells.SwitchStatements.Solution
{
    public abstract class Customer
    {
        public abstract MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage);
    }
}
