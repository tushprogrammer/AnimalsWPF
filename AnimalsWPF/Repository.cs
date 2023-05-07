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

        //Конструктор
        public Repository()
        {
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
        //тут же будут реализованы delete, change, print (вместо банального открытия бд через get,
        //но это еще надо подумать, как реализовать)
    }
}
