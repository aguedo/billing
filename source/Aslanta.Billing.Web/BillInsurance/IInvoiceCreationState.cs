using Aslanta.Billing.Web.BillInsurance.Models;

namespace Aslanta.Billing.Web.BillInsurance;

public interface IInvoiceCreationState
{
    void AddOrders(params Order[] orders);
    void AddOrders(IEnumerable<Order> orders);
    void RemoveOrders(params Order[] orders);
    void RemoveOrders(IEnumerable<Order> orders);
    void RemoveSelectedOrders();
}
