namespace Aslanta.Billing.Web.BillInsurance.Implementations.Mocks;

internal static class RandomRelationshipGenerator
{
    private static readonly string[] _relationships = ["Self", "Spouse", "Child", "Other"];

    public static string Generate() => _relationships[RandomInstance.Random.Next(0, _relationships.Length)];
}
