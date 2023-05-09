using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    class Repository
    {
        //БД 
        ObservableCollection<IAnimal> animals;

        //Вариант сохранения
        public IAnimalSave Mode { get; set; }

        //Конструктор
        public Repository(IAnimalSave mode)
        {
            this.Mode = mode;
            animals = new ObservableCollection<IAnimal>(); //инициализация бд 
        }

        /// <summary>
        /// Добавление нового конкретного элемента в коллекцию 
        /// </summary>
        /// <param name="animal"></param>
        public void Add (IAnimal animal)
        {
            animals.Add(animal);
        }
        public ObservableCollection<IAnimal> GetAnimals()
        {
            return animals;
        }
        /// <summary>
        /// Метод удаления объекта Animal из БД
        /// </summary>
        /// <param name="animal">Объект IAnimal, который надо удалить</param>
        public void Delete(IAnimal animal)
        {
            animals.Remove(animal);
        }
        
        public void SaveAnimals(string FileName)
        {
            //вызов метода сохранения, не важно какой сейчас мод сохранения установлен
            Mode.Save(animals, FileName);
        }
    }
}
