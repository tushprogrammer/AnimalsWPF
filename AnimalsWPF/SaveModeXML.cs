using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalsWPF
{
    /// <summary>
    /// Вариант сохранения данных в XML формат
    /// </summary>
    class SaveModeXML : IAnimalSave
    {
        public string Name { get; set; }

        public void Save(ObservableCollection<IAnimal> animals, string NameFile)
        {
            XElement Animals = new XElement("AnimalCollection");
            foreach (IAnimal animalnow in animals)
            {
                XElement Animal = new XElement("Animal");

                XElement Name = new XElement("Name");
                Name.Add(animalnow.Name);
                XElement Age = new XElement("Age");
                Age.Add(animalnow.Age);
                XElement Weight = new XElement("Weight");
                Weight.Add(animalnow.Weight);
                XElement CountryFrom = new XElement("CountryFrom");
                CountryFrom.Add(animalnow.CountryFrom);
                Animal.Add(Name, Age, Weight, CountryFrom);
                Animals.Add(Animal);
            }
            Animals.Save(NameFile);
        }

        public SaveModeXML()
        {
            Name = "SaveModeXML";
        }
    }
}
