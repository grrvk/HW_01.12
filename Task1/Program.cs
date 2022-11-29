//Порушено принцип єдиного обовʼязку
class Item
{
    public string name;
    public double cost;
    public Item(string name, double cost)
    {
        this.cost = cost;
        this.name = name;
    }
}

class Order
{
    private List<Item> itemList;
    internal List<Item> ItemList
    {
        get
        {
            return itemList;
        }
        set
        {
            itemList = value;
        }
    }
    public void AddItem(Item item)
    {
        itemList.Add(item);
    }
    public void DeleteItem(Item item)
    {
        itemList.Remove(item);
    }
}

class OrderNumManager
{
    public void CalculateTotalSum(Order order)
    {
        double Sum = 0;
        foreach (Item item in order.ItemList)
        {
            Sum += item.cost;
        }
        Console.WriteLine($"Total sum: {Sum}");
    }
    public void GetItemCount(Order order)
    {
        Console.WriteLine($"Number of itmes: {order.ItemList.Count()}");
    }
}

class PrintManager
{
    public void PrintOrder(Order order)
    {
        Console.WriteLine("Printing order");
        foreach (Item item in order.ItemList)
        {
            Console.WriteLine($"{item.name} - {item.cost}");
        }
    }
    public void ShowOrder(Order order)
    {
        Console.WriteLine("Showing order");
        foreach (Item item in order.ItemList)
        {
            Console.WriteLine($"{item.name} - {item.cost}");
        }
    }
    public void GetItems(Order order)
    {
        Console.WriteLine("Items: ");
        foreach (Item item in order.ItemList)
        {
            Console.WriteLine($"{item.name}");
        }
    }
}

class UpdateManager
{
    public void Load() {/*...*/}
    public void Save() {/*...*/}
    public void Update() {/*...*/}
    public void Delete() {/*...*/}
}

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();
        PrintManager prM = new PrintManager();
        OrderNumManager orM = new OrderNumManager();
        List<Item> items = new List<Item>()
        {
            new Item("First", 100),
            new Item("Second", 200),
            new Item("Third", 300)
        };
        order.ItemList = items;
        prM.PrintOrder(order);
        Item newItem = new Item("Forth", 400);
        order.AddItem(newItem);
        prM.ShowOrder(order);
        order.DeleteItem(newItem);
        prM.PrintOrder(order);
        orM.CalculateTotalSum(order);
        orM.GetItemCount(order);
        prM.GetItems(order);
    }
}