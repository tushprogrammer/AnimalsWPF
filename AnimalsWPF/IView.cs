using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    /// <summary>
    /// Отображение данных в окне
    /// </summary>
    interface IView
    {
        ObservableCollection<IAnimal> Animals { set; } //для вывода 
        ObservableCollection<IAnimalSave> Saves { set; } //для вывода
        IAnimalSave ModSave { get; } //для передачи
        IAnimal AnimalNow { get; } //для передачи
    }
}
