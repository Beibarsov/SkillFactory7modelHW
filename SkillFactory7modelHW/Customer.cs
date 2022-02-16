 abstract class Customer
{
    public Address Address{get; protected set;}  
    public Contacs Contacs {get; protected set;}   

   

    static public int CustomerCount;

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
    private int age;

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (Age > 18) this.Age = value;
        }
    }
    public IndivCustomer(Address address, Contacs contacs, int age, string fio) : base(address, contacs)
    { 
        
        Address = address;
        Contacs = contacs;
        Fio = fio;
 }
}



