//Класс, содержащий географическое местоположение

class Address
{
    public string City;
    public string Region;
    public string PostalCode;
    public string Country;
    public string Street;
    public string Home;
    
    public Address(string city, string street, string home)
    {
        City = city;
        Street = street;
        Home = home;
    }
}

class AppartamentAddress : Address
{
    public string Appartament;

    public AppartamentAddress(string city, string street, string home, string appartament) : base (city, street, home)
    {
        City = city;
        Street = street;
        Home = home;
        Appartament = appartament;
    }


        public override string ToString(){
        return City + " " + Street + " " + Home + " " + Appartament;
    }
}