 abstract class Customer
{
    public Address Address;
    public Contacs Contacs;    

    public Customer(Address address, Contacs contacs)
    {
        Address = address;
        Contacs = contacs;
    }
}

//Корпоративный заказчик
class CorpCustomer : Customer
{
    public string CorpName;
    public CorpCustomer(Address address, Contacs contacs, string CorpName) : base(address, contacs)
    {
        Address = address;
        Contacs = contacs;
        CorpName = CorpName;
    }
    
}
//Заказчик физическое лицо
class IndivCustomer : Customer
{
    public string Fio;
    public IndivCustomer(Address address, Contacs contacs, string fio) : base(address, contacs)
    {
        Address = address;
        Contacs = contacs;
        Fio = fio;
    }
}