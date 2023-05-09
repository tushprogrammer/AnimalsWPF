using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    /// <summary>
    /// Вариант сохранения данных в JSON формат
    /// </summary>
    class SaveModeJSON : IAnimalSave
    {
        public string Name { get; set; }

        public void Save(ObservableCollection<IAnimal> animals, string NameFile) 
        {
            
            string json = JsonConvert.SerializeObject(animals);
            System.IO.File.WriteAllText($"{NameFile}.json", json);
        }

        public SaveModeJSON ()
        {
            this.Name = "SaveModeJSON";
        }
    }
}
