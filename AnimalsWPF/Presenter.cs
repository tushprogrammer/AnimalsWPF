using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    class Presenter
    {
        IView view;
        IModel model;
        public Presenter(IView view) 
        {
            this.view = view;
            model = new ModelLogic(); 
        }
        public void Info()
        {
            view.Animals = model.GetData();
            view.Saves = model.GetSaves();

        }
        public void DeleteAnimal()
        {
            model.Delete(view.AnimalNow);
        }
        public void Save()
        {
            model.SaveAllAnimals();
        }
        public void ChangeModSave()
        {
            model.ChangeModSave(view.ModSave);
        }
        public void AddNewAnimal(IAnimal animal)
        {
            model.Add(animal);
        }
    }
}
