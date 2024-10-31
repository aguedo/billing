namespace Aslanta.Billing.Web.BillInsurance.Implementations.Mocks;

internal static class RandomDateGenerator
{
    public static DateTime Generate(int fromYear = 1940, int toYear = 2023)
    {
        var start = new DateTime(fromYear, 1, 1);
        var end = new DateTime(toYear, 12, 31);
        var range = (end - start).Days;
        return start.AddDays(RandomInstance.Random.Next(range));
    }
}