using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    public interface IAnimal
    {
        //Кличка
        string Name { get; set; }
        //Возраст
        double Age { get; set; }
        //Вес
        double Weight { get; set; }
        //Происхождение (откуда родом) 
        string CountryFrom { get; set; }

    }
}
