using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimalsWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Repository repository;
        public MainWindow()
        {
            InitializeComponent();

            repository = FactoryRep.GetRep(10);
            GridViewAnimals.DataContext = repository.GetAnimals();
        }

        /// <summary>
        /// Пкм - добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemAddClick(object sender, RoutedEventArgs e)
        {
            //открыть новое окно с формой заполнения 
            NewAnimal animal = new NewAnimal();
            animal.ShowDialog();
            if (animal.DialogResult.Value)
            {
                repository.Add(animal.Animal);
            }

            
        }
    }
}
