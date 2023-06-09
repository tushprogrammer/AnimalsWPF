﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    //Млекопитающие
    class Mammals : IAnimal
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

        public Mammals(string name, double age, double weight, string countryFrom)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
            this.CountryFrom = countryFrom;
        }
    }
}
