namespace Aslanta.Billing.Web.BillInsurance;

public interface IItemCollection<T>
{
    IReadOnlyCollection<T> Items { get; }
    IReadOnlyCollection<T> SelectedItems { get; }
    bool IsSelected(T item);
    void Add(params T[] items);
    void Add(IEnumerable<T> items);
    void Remove(params T[] items);
    void Remove(IEnumerable<T> items);
    void RemoveSelected();
    void Clear();
}
