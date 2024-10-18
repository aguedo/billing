namespace Aslanta.Billing.Web.BillInsurance.Models;

public class Insured
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime? DateOfBirth { get; set; }
}
