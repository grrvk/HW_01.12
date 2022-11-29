//Порушено Принцип розділення інтерфейсу

interface IItem
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);
    void SetPrice(double price);
}

interface IBook : IItem
{
    void SetCover(string color);
    string getTitle();
    double getPrice();
}

interface IClothes : IItem
{
    void SetColor(string color);
    void SetSize(string size);
    string getColor();
    string getSize();
}

interface IPrintBookFormatter
{
    void FormatterType(IBook book);
}

interface IPrintClothesFormatter
{
    void FormatterType(IClothes clothes);
}

class BookFormatter : IPrintBookFormatter
{
    public void FormatterType(IBook book)
    {
        Console.WriteLine($"Title: {book.getTitle()}, Price: {book.getPrice()}");
    }
}

class ClothesFormatter : IPrintClothesFormatter
{
    public void FormatterType(IClothes clothes)
    {
        Console.WriteLine($"Color: {clothes.getColor()}, Size: {clothes.getSize()}");
    }
}

class Book : IBook
{
    private string color;
    private string title;
    private double price;
    public Book(string title)
    {
        this.title = title;
    }
    public void SetCover(string color)
    {
        this.color = color;
    }
    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Discount '{discount}' applied");
    }
    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine($"Promocode '{promocode}' applied");
    }
    public void SetPrice(double price)
    {
        this.price = price;
    }
    public string getTitle()
    {
        return title;
    }
    public double getPrice()
    {
        return price;
    }
}

class Shirt : IClothes
{
    private string color;
    private string size;
    private double price;
    public void ApplyDiscount(string discount)
    {
        Console.WriteLine($"Discount '{discount}' applied");
    }
    public void ApplyPromocode(string promocode)
    {
        Console.WriteLine($"Promocode '{promocode}' applied");
    }
    public void SetPrice(double price)
    {
        this.price = price;
    }
    public void SetColor(string color)
    {
        this.color = color;
    }
    public void SetSize(string size)
    {
        this.size = size;
    }
    public string getColor()
    {
        return color;
    }
    public string getSize()
    {
        return size;
    }
}


class Program
{
    static void Main(string[] args)
    {
        IPrintBookFormatter prB = new BookFormatter();
        IPrintClothesFormatter prC = new ClothesFormatter();
        IClothes shirt = new Shirt();
        shirt.SetColor("red");
        shirt.SetPrice(300);
        shirt.SetSize("M");
        prC.FormatterType(shirt);
        IBook book = new Book("Title");
        book.SetPrice(200);
        prB.FormatterType(book);
    }
}