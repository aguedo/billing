namespace Aslanta.Billing.Web.BillInsurance.Models;

public class Insurance
{
    public required Payer Payer { get; set; }
    public required string PolicyNumber { get; set; }
    public string? GroupNumber { get; set; }
    public required string RelationshipToInsured { get; set; }
}
