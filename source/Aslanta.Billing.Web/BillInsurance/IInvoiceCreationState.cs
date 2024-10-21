using Aslanta.Billing.Web.BillInsurance.Models;

namespace Aslanta.Billing.Web.BillInsurance;

public interface IInvoiceCreationState
{
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
}
