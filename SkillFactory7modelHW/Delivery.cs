// See https://aka.ms/new-console-template for more information
abstract class Delivery<TCustomer> where TCustomer : Customer
{
    public bool isReady = false;
    public bool isAwait = false;
    public TCustomer Customer { get; set; }

    public abstract void InfoAboutCourier();
}
class HomeDelivery<TCustomer> : Delivery<TCustomer> where TCustomer : Customer
{
    public IndivCustomer Customer { get; set; }
    public Coureir Coureir { get; set; }


    public DateTime DateDelivery;
    public void CalltoClient()
    {
        if (isAwait == true){
            Console.WriteLine("Клиент уже ждет, повторного звонка не требуется");
            return;
        }
        if (isReady == true){
            Console.WriteLine("Заказ уже доставлен");
            return;
        }
        while (!isAwait)
        {
            Console.WriteLine($"Курьер совершает звонок на номер клиента {Customer.Contacs.Phone}");
            Console.WriteLine("Клиент ответил и ждет доставки?");
            bool.TryParse(Console.ReadLine(), out isAwait);
            DateDelivery = DateTime.Today.Date;
        }
    isReady = true;
        
    }

    public void DeliverytoClient(){

        if(!isAwait){
            Console.WriteLine("Клиент не ожидает доставки, требуется сначала позвонить");
            return;
        }
        if (isReady == true){
            Console.WriteLine("Заказ уже доставлен");
            return;
        }
        if (DateTime.Now.Date != DateDelivery.Date){
            Console.WriteLine("Срок доставки не сегодня");
            return;
        }

        Console.WriteLine($"Курьер доставляет по адресу {Customer.Address.ToString()}");
        

    }
    public override void InfoAboutCourier()
    {
        Console.WriteLine($"Доставку обеспечивает курьер {Coureir.Fio}");
    }


}

class PickPointDelivery<TCustomer> : Delivery<TCustomer> where TCustomer : Customer
{

    public DateTime StoragePeriod = DateTime.Now.Date.AddDays(7);
    public Address Address;
    public IndivCustomer Customer;
    public bool isAwait = false;



    public void DeliveryToPicPoint(){
        Console.WriteLine("Заказ курьера компании для доставки в пункт выдачи");
        Console.WriteLine("Получение информации от пункта выдачи:");
        StoragePeriod = DateTime.Now.Date.AddDays(7);
        Console.WriteLine($"Сколько будет хранить товар? : {StoragePeriod}");
        Address = new Address("Москва", "Московский переулок", "Дом 33");
        Console.WriteLine($"Где он ожидает клиента? : {Address}");


    }
    public void CalltoClient(){
        if (!isAwait) {
            Console.WriteLine("Рано звонить, товар еще не на месте");
        }
        if(isReady){
            Console.WriteLine("Товар уже забран");
        }
        Console.WriteLine($"Уведомить клиента {Customer.Fio} о том, что заказ ждет его по адресу {Address.ToString()} до {StoragePeriod.Date}");
        isAwait = true;
    }

    public bool Wait(){
        Console.WriteLine("Ожидаем уведомления от пункта выдачи, что клиент забрал заказ");
        IsDone();
        return true;
    }

    public void IsDone(){
        Console.WriteLine("Поступило подтверждение о забранном заказе по одному из каналов. Доставку можно считать исполненной.");
        isReady = true;
    }
    public override void InfoAboutCourier()
    {
        Console.WriteLine("Запрашиваем информацию о курьере из компании");
    }


}

class ShopDelivery<TCustomer> : Delivery<TCustomer> where TCustomer : Customer
{

    public CorpCustomer Customer;
    public  Coureir Coureir;

    public void DeliveryToPicPoint()
    {
        Console.WriteLine($"Курьер отвозит заказ на адресс {Customer.Address.ToString}");


    }
    public override void InfoAboutCourier()
    {
        Console.WriteLine($"Доставку обеспечивает курьер {Coureir.Fio}");
    }


    public void IsDone()
    {
        Console.WriteLine($"Курьер {Coureir.Fio} сказал что всё готово. Магазин {Customer.CorpName}. Доставку можно считать исполненной.");
        isReady = true;
    }

}

