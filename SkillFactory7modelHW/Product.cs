// See https://aka.ms/new-console-template for more information
class Product
{
    protected static int counter;
    protected int id;

    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
            counter++; //Чуть логичнее в конструктор, но почему бы и нет
        }
    }
    public int Price;


    public Product(int id, int price){
        Id = id;
        Price = price;
    }

    public virtual int GetCount() => counter;
}

//Отдельно идет класс съедобных товаров т.к. у них важно учитывать срок годности
class EatableProduct: Product
{
    public DateTime ExpirationDate;

    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value+900000; //На продукты питания серийные номера будут в стиле 900008, 900025 и т.д.
            counter++;
        }
    }

    public EatableProduct(int id, int price, DateTime expirationDate) : base(id, price)
    {
        Id = id;
        Price = price;
        ExpirationDate = expirationDate;
    }

    public bool IsEatDead(DateTime ExpirationDate){
        if (ExpirationDate > DateTime.Now) return true;
        else return false;

    }
}

