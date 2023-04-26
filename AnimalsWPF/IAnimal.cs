using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    internal interface IAnimal
    {
        //Кличка
        string Name { get; set; }
        //Возраст
        int Age { get; set; }
        //Вес
        int Weight { get; set; }
        //Происхождение (откуда родом) 
        string CountryFrom { get; set; }

    }
}
