// See https://aka.ms/new-console-template for more information
abstract class Delivery
{
    public bool isReady;
}
class HomeDelivery : Delivery
{
    public Customer Customer { get; set; }
    public Coureir Coureir { get; set; }

    public DateTime DateDelivery;
    public bool CalltoClient(Customer customer, Coureir coureir, ref DateTime DateDelivery)
    {
        bool isAwaiting = false;
        while (!isAwaiting)
        {
            Console.WriteLine($"Курьер совершает звонок на номер клиента {customer.Contacs.Phone}");
            Console.WriteLine("Клиент ответил и ждет доставки завтра?");
            bool.TryParse(Console.ReadLine(), out isAwaiting);
            
        }
        if (isAwaiting)
        {
            DateDelivery = DateTime.Today.AddDays(1).AddHours(20);
            return true;
        }
        return false;
    }
}

class PickPointDelivery : Delivery
{
    /* ... */
}

class ShopDelivery : Delivery
{
    /* ... */
}

