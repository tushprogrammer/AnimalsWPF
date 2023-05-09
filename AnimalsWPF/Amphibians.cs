using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    internal class Amphibians : IAnimal
    {
        /// <summary>
        /// Кличка
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Возраст
        /// </summary>
        public double Age { get; set; }
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Страна происхождения
        /// </summary>
        public string CountryFrom { get; set; }

        /// <summary>
        /// Конструктор 
        /// </summary>
        public Amphibians(string name, double age, double weight, string countryFrom)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.CountryFrom = countryFrom;
        }
    }
}
