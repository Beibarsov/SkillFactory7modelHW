// See https://aka.ms/new-console-template for more information

class Order<TDelivery, Tproduct, TCustomer> 

    where TDelivery : Delivery<Customer>
    where Tproduct : Product
    
{
    public TDelivery Delivery;

    public int Number;

    public string Description;

    public Product[] Products;

    public TCustomer Customer;
    
    

}