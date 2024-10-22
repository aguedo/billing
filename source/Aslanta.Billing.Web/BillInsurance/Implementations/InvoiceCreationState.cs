using Aslanta.Billing.Web.BillInsurance.Models;

namespace Aslanta.Billing.Web.BillInsurance.Implementations;

public class InvoiceCreationState : IInvoiceCreationState
{
    private IItemCollection<Order> _orderCollection;
    private IItemCollection<InvoiceItem> _invoiceItemCollection;

    public IReadOnlyCollection<Order> Orders => _orderCollection.Items;
    public IReadOnlyCollection<Order> SelectedOrders => _orderCollection.SelectedItems;

    public InvoiceCreationState(IItemCollection<Order> orderCollection, IItemCollection<InvoiceItem> invoiceItemCollection)
    {
        _orderCollection = orderCollection;
        _invoiceItemCollection = invoiceItemCollection;
    }

    public void AddOrders(params Order[] orders)
    {
        AddOrders(orders.AsEnumerable());
    }

    public void AddOrders(IEnumerable<Order> orders)
    {
        _orderCollection.Add(orders);
    }

    public void RemoveOrders(params Order[] orders)
    {
        RemoveOrders(orders.AsEnumerable());
    }

    public void RemoveOrders(IEnumerable<Order> orders)
    {
        _invoiceItemCollection.Remove(orders.SelectMany(o => o.InvoiceItems));
        _orderCollection.Remove(orders);
    }

    public void RemoveSelectedOrders()
    {
        _invoiceItemCollection.Remove(_orderCollection.SelectedItems.SelectMany(o => o.InvoiceItems));
        _orderCollection.RemoveSelected();
    }

    public bool IsOrderSelected(Order order)
    {
        return _orderCollection.IsSelected(order);
    }

    public void SelectOrder(Order order)
    {
        _orderCollection.Select(order);
        _invoiceItemCollection.Add(order.InvoiceItems);
    }

    public void UnselectOrder(Order order)
    {
        _orderCollection.Unselect(order);
        _invoiceItemCollection.Remove(order.InvoiceItems);
    }

    public void SelectAllOrders()
    {
        _orderCollection.SelectAll();
        _invoiceItemCollection.Add(Orders.SelectMany(o => o.InvoiceItems));
    }

    public void UnselectAllOrders()
    {
        _orderCollection.UnselectAll();
        _invoiceItemCollection.Clear();
    }
}
