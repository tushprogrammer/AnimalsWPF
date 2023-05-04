using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    public class AnimalFactory
    {
        public static IAnimal GetAnimal(string name,string country, double wight, double age, string Type )
        {
            switch( Type )
            {
                case "Bird": return new Birds(name, age, wight, country);
                case "Amphibian": return new Amphibians(name, age, wight, country);
                case "Mammal": return new Mammals(name, age, wight, country);

                default: return new NullAnimal();
            }
        }
    }
}
