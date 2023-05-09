using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    public class ModelLogic : IModel
    {
        ObservableCollection<IAnimalSave> saves;
        IAnimal AnimalNow;
        Repository repository;

        public ModelLogic()
        {
            saves = new ObservableCollection<IAnimalSave>
            {
                new SaveModeJSON(),
                new SaveModeXML()
            };
            repository = FactoryRep.GetRep(10, saves[0]);
        }

        public ObservableCollection<IAnimal> GetData()
        {
            return repository.GetAnimals();
        }
        public ObservableCollection<IAnimalSave> GetSaves()
        {
            return saves;
        }
        public void Delete(IAnimal animalNow)
        {
            repository.Delete(AnimalNow);
        }
        public void SaveAllAnimals() 
        {
            repository.SaveAnimals("Animal"); //пока что имя по умолчанию
        }
        public void ChangeModSave(IAnimalSave savemod)
        {
            repository.Mode = savemod;
        }
        public void Add(IAnimal newanimal)
        {
            repository.Add(newanimal);
        }
    }
}
