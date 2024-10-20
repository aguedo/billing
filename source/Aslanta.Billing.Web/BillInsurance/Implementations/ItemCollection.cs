
namespace Aslanta.Billing.Web.BillInsurance.Implementations;

public class ItemCollection<T> : IItemCollection<T>
{
    public IReadOnlyCollection<T> Items => throw new NotImplementedException();

    public IReadOnlyCollection<T> SelectedItems => throw new NotImplementedException();

    public void Add(params T[] items)
    {
        throw new NotImplementedException();
    }

    public void Add(IEnumerable<T> items)
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    public void Remove(IEnumerable<T> items)
    {
        throw new NotImplementedException();
    }

    public void RemoveSelected()
    {
        throw new NotImplementedException();
    }
}
