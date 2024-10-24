using Aslanta.Billing.Web.BillInsurance.Models;

namespace Aslanta.Billing.Web.BillInsurance;

public interface IInvoiceCreationState
{
    IReadOnlyCollection<Order> Orders { get; }
    IReadOnlyCollection<Order> SelectedOrders { get; }
    void AddOrders(params Order[] orders);
    void AddOrders(IEnumerable<Order> orders);
    void RemoveOrders(params Order[] orders);
    void RemoveOrders(IEnumerable<Order> orders);
    void RemoveSelectedOrders();
    void SelectOrder(Order order);
    void UnselectOrder(Order order);
    void SelectAllOrders();
    void UnselectAllOrders();
    bool IsOrderSelected(Order order);

    IReadOnlyCollection<InvoiceItem> InvoiceItems { get; }
    IReadOnlyCollection<InvoiceItem> SelectedInvoiceItems { get; }
    void AddInvoiceItems(params InvoiceItem[] invoiceItems);
    void AddInvoiceItems(IEnumerable<InvoiceItem> invoiceItems);
    void RemoveInvoiceItems(params InvoiceItem[] invoiceItems);
    void RemoveInvoiceItems(IEnumerable<InvoiceItem> invoiceItems);
    void RemoveSelectedInvoiceItems();
    void SelectInvoiceItem(InvoiceItem invoiceItem);
    void UnselectInvoiceItem(InvoiceItem invoiceItem);
    void SelectAllInvoiceItems();
    void UnselectAllInvoiceItems();
    bool IsInvoiceItemSelected(InvoiceItem invoiceItem);
}
