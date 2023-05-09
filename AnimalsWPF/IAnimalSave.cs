using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    //Мод сохранения 
    public interface IAnimalSave
    {
        string Name { get; set; }

        /// <summary>
        /// Метод сохранения коллекции IAnimal
        /// </summary>
        /// <param name="animals">Сохраняемая коллекция</param>
        /// <param name="FileName">Имя сохраняемого файла</param>
        void Save(ObservableCollection<IAnimal> animals, string FileName);
    }
}
