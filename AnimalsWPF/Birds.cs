using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    internal class Birds : IAnimal
    {
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

        public Birds(string name, int age, int weight, string countryFrom)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.CountryFrom = countryFrom;
        }
    }
}
