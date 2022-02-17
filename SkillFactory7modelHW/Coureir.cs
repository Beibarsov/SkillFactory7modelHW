using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Coureir
    {
        //Изменине данных о курьерах невозможно. Данные о них предоставляет курьерская компания.
        public Contacs Contacs { get; }
        public string Fio { get; }

        public Coureir(Contacs contacs, string Fio)
    {
        Contacs = contacs;
        this.Fio = Fio;

    }
        public void GoToWay()
    {
        Console.WriteLine("Курьер поехал на доставку");
    }

    }

/// <summary>
/// Класс-коллекция с коллекцией курьеров
/// </summary>
    class CourierCompany{
    protected Coureir[] courierList;

    public CourierCompany(Coureir[] collection)
    {
        courierList = collection;
    }

    public Coureir this[int index]
    {
        get
        {
            if (index >= 0 && index < courierList.Length)
            {
                return courierList[index];
            }
            else
            {
                return null;
            }
        }
        private set
        {
            if (index >= 0 && index < courierList.Length)
            {
                courierList[index] = value;
            }
        }
    }




}
