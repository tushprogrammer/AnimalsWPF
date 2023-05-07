using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    /// <summary>
    /// Фабрика общего репозитория
    /// </summary>
     class FactoryRep
    {
        static Random rnd;
        static FactoryRep()
        {
            rnd = new Random();
        }
        public static Repository GetRep(int count, IAnimalSave mode)
        {
            Repository Repository = new Repository(mode);
            for (double i = 1; i <= count; i++)
            {
                switch (rnd.Next(1,4))
                {
                    case 1:
                        Repository.Add(new Mammals($"Млекопитающее {i}", i/4, i*2, $"Страна {i}")); 
                        break;
                    case 2:
                        Repository.Add(new Birds($"Птица {i}", i / 4, i / 2, $"Страна {i}"));
                        break;
                    case 3:
                        Repository.Add(new Amphibians($"Земноводное {i}", i / 2, (1 * 1.5) , $"Страна {i}"));
                        break;
                    default:

                        break;

                }
            }
            return Repository;
        }
        

        
    }
}
