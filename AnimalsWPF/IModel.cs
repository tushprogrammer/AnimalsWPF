using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    public interface IModel
    {
        ObservableCollection<IAnimalSave> GetSaves();
        ObservableCollection<IAnimal> GetData();

        void Delete(IAnimal animalNow);
        void SaveAllAnimals();
        void ChangeModSave(IAnimalSave SaveMod);
        void Add(IAnimal animal);
    }
}
