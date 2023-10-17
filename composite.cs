namespace Composite;

public interface IItems
{
    public int Price();
}

public class CompoundBox : IItems
{
    int packaging = 2;
    List<IItems> Items = new();

    public void AddItem(IItems item)
    {
        Items.Add(item);
    }

    public int Price()
    {
        int price = 0;
        foreach(var item in Items)
        {
            price += item.Price();
        }
        return price + packaging;
    }

    public void RemoveItem(IItems item)
    {
        Items.Remove(item);
    }
}

public class Item : IItems
{
    readonly int price;

    public Item(int price)
    {
        this.price = price;
    }

    public int Price()
    {
        return price;
    }
}