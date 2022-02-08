// See https://aka.ms/new-console-template for more information

class Order<TDelivery, TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public int Number;

    public string Description;

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

    public Product[] Products;

    public Customer Customer;
    // ... Другие поля
}