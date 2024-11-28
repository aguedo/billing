namespace Aslanta.Billing.Web.BillInsurance.Implementations.Mocks;

internal static class IdGenerator
{
    private static int _nextInt = 1;

    public static int NextInt => _nextInt++;

    public static string RandomStringId(int size) => Guid.NewGuid().ToString().Replace("-", "").Substring(0, size);

    public static string RandomDateCode(int fromYear, int toYear, string prefix, int size)
    {
        DateTime date = RandomDateGenerator.Generate(fromYear, toYear);
        string year = date.Year.ToString().Substring(2);
        string month = date.Month.ToString().PadLeft(2, '0');
        string day = date.Day.ToString().PadLeft(2, '0');
        const int dateSize = 6;
        string code = size - dateSize > 0 ? NextInt.ToString().PadLeft(size - dateSize, '0') : string.Empty;
        return $"{prefix}{year}{month}{day}{code}";
    }
}