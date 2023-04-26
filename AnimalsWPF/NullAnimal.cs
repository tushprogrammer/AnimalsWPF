using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    class NullAnimal : IAnimal
    {
        public NullAnimal()
        {
            this.Name = "404 Name Not Found";
            this.Age = 0;
            this.Weight = 0;
            this.CountryFrom = "404 CountryFrom Not Found";
        }

        /// <summary>
        /// Кличка
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }
        /// <summary>
        /// Вес
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// Страна происхождения
        /// </summary>
        public string CountryFrom { get; set; }


    }
}
