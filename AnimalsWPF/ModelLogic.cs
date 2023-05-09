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
        ObservableCollection<IAnimalSave> saves; //коллекция вариантов сохранения данных
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
        //Выдача данных о текущей коллекции животных
        public ObservableCollection<IAnimal> GetData()
        {
            return repository.GetAnimals();
        }
        //Выдача данных о коллекции вариантов сохранения данных
        public ObservableCollection<IAnimalSave> GetSaves()
        {
            return saves;
        }
        /// <summary>
        /// Удаление объекта типа IAnimal
        /// </summary>
        /// <param name="animalNow"></param>
        public void Delete(IAnimal animalNow)
        {
            repository.Delete(animalNow);
        }
        /// <summary>
        /// Соханение данных
        /// </summary>
        public void SaveAllAnimals() 
        {
            repository.SaveAnimals("Animal"); //пока что имя по умолчанию
        }
        /// <summary>
        /// Изменение варианта сохранения данных
        /// </summary>
        /// <param name="savemod">Новый режим сохранения</param>
        public void ChangeModSave(IAnimalSave savemod)
        {
            repository.Mode = savemod;
        }
        /// <summary>
        /// Добавление нового объекта типа IAnimal в коллекцию
        /// </summary>
        /// <param name="newanimal"></param>
        public void Add(IAnimal newanimal)
        {
            repository.Add(newanimal);
        }
    }
}
