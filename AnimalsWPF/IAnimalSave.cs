﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsWPF
{
    public interface IAnimalSave
    {
        string Name { get; set; }
        void Save(ObservableCollection<IAnimal> animals, string FileName);
    }
}
