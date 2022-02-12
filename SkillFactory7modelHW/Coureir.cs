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

    }

    }

