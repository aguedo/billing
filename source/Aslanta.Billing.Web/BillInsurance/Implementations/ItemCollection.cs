
namespace Aslanta.Billing.Web.BillInsurance.Implementations;

public class ItemCollection<T> : IItemCollection<T>
{
    private HashSet<T> _selectedItems = new HashSet<T>();
    private HashSet<T> _items = new HashSet<T>();

    public IReadOnlyCollection<T> Items => _items;
    public IReadOnlyCollection<T> SelectedItems => _selectedItems;

    public void Add(params T[] items)
    {
        Add(items.AsEnumerable());
    }

    public void Add(IEnumerable<T> items)
    {
        _items.UnionWith(items);
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool IsSelected(T item)
    {
        throw new NotImplementedException();
    }

    public void Remove(params T[] items)
    {
    }

    public void Remove(IEnumerable<T> items)
    {
    }

    public void RemoveSelected()
    {
        throw new NotImplementedException();
    }
}
