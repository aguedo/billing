namespace Aslanta.Billing.Web.BillInsurance.Models;

public class BillableItem
{
    public required int Id { get; set; }
    public required BillableItemType Type { get; set; }
    public required string Name { get; set; }
}
