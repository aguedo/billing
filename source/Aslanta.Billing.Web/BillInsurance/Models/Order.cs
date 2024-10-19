using System;

namespace Aslanta.Billing.Web.BillInsurance.Models;

public class Order
{
    private readonly HashSet<InvoiceItem> _invoiceItems;

    public Order()
    {
        _invoiceItems = new HashSet<InvoiceItem>();
    }

    public Order(IEnumerable<InvoiceItem> invoiceItems)
    {
        _invoiceItems = new HashSet<InvoiceItem>(invoiceItems);
    }

    public required string Code { get; set; }
    public required Patient Patient { get; set; }
    public DateTime? CollectionDate { get; set; }
    public DateTime? CreationDate { get; set; }
    public DateTime? ReceivedDate { get; set; }
    public DateTime? ReportedDate { get; set; }
    public required Insurance Insurance { get; set; }
    public IReadOnlyCollection<InvoiceItem> InvoiceItems => _invoiceItems;

    public void AddInvoiceItem(params InvoiceItem[] invoiceItems)
    {
        AddInvoiceItem(invoiceItems.AsEnumerable());
    }

    public void AddInvoiceItem(IEnumerable<InvoiceItem> invoiceItems)
    {
        _invoiceItems.UnionWith(invoiceItems);
    }

    public void RemoveInvoiceItem(params InvoiceItem[] invoiceItems)
    {
        RemoveInvoiceItem(invoiceItems.AsEnumerable());
    }

    public void RemoveInvoiceItem(IEnumerable<InvoiceItem> invoiceItems)
    {
        _invoiceItems.ExceptWith(invoiceItems);
    }
}
