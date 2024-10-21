
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
        _items.Clear();
        _selectedItems.Clear();
    }

    public void Remove(params T[] items)
    {
        Remove(items.AsEnumerable());
    }

    public void Remove(IEnumerable<T> items)
    {
        _items.ExceptWith(items);
        _selectedItems.ExceptWith(items);
    }

    public void RemoveSelected()
    {
        Remove(_selectedItems);
        _selectedItems.Clear();
    }

    public bool IsSelected(T item)
    {
        return _selectedItems.Contains(item);
    }

    public void Select(T item)
    {
        _selectedItems.Add(item);
    }

    public void Unselect(T item)
    {
        _selectedItems.Remove(item);
    }

    public void SelectAll()
    {
        _selectedItems.UnionWith(Items);
    }

    public void UnselectAll()
    {
        _selectedItems.Clear();
    }
}
