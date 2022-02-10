// See https://aka.ms/new-console-template for more information
class Product
{
    public int Id;
    public int Price;


    public Product(int id, int price){
        Id = id;
        Price = price;
    }
}

//Отдельно идет класс съедобных товаров т.к. у них важно учитывать срок годности
class EatableProduct: Product
{
    public DateTime ExpirationDate;

    public EatableProduct(int id, int price, DateTime expirationDate) : base(id, price)
    {
        Id = id;
        Price = price;
        ExpirationDate = expirationDate;
    }
}

