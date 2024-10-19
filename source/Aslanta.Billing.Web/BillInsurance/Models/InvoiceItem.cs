namespace Aslanta.Billing.Web.BillInsurance.Models;

public class InvoiceItem
{
    public required int Id { get; set; }
    public required Order Order { get; set; }
    public required BillableItem Item { get; set; }
    public required CptCode CptCode { get; set; }
    public required decimal Price { get; set; }
    public int Quantity { get; set; }
    public required decimal ActualPrice { get; set; }
    public IcdCode? IcdCode1 { get; set; }
    public IcdCode? IcdCode2 { get; set; }
    public IcdCode? IcdCode3 { get; set; }
    public IcdCode? IcdCode4 { get; set; }
    public Modifier? Modifier1 { get; set; }
    public Modifier? Modifier2 { get; set; }
    public Modifier? Modifier3 { get; set; }
    public Modifier? Modifier4 { get; set; }
}
