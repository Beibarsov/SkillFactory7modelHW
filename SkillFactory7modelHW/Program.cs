// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


HomeDelivery<IndivCustomer> homeDelivery = new HomeDelivery<IndivCustomer>();
homeDelivery.Customer = new IndivCustomer(new AppartamentAddress("Москва", "Московская", "34", "9" ), new Contacs { Phone = "83953553422"}, "Виталий Витальевич Виталин");
homeDelivery.Coureir = new Coureir(new Contacs { Phone = "12312412"}, "Курьерович Курьерский");
homeDelivery.DateDelivery = new DateTime(2021, 12, 22);
homeDelivery.CalltoClient();

Console.WriteLine(homeDelivery.DateDelivery);
homeDelivery.DeliverytoClient();
homeDelivery.InfoAboutCourier();
Console.WriteLine(homeDelivery.isReady);
