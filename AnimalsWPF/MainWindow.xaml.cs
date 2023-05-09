using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        IAnimal AnimalNow;
        ObservableCollection<IAnimalSave> saves;
        public MainWindow()
        {
            InitializeComponent();
            Start();
            
        }
        /// <summary>
        /// Установка стартовых параметров по умолчанию
        /// </summary>
        private void Start()
        {
            saves = new ObservableCollection<IAnimalSave>();
            saves.Add(new SaveModeJSON());
            saves.Add(new SaveModeXML());
            SaveModCombobox.ItemsSource = saves;
            repository = FactoryRep.GetRep(10, saves[0]);
            SaveModCombobox.SelectedIndex = 0;
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

        /// <summary>
        /// ПКМ - удалить
        /// </summary>
        private void MenuItemDeleteClick(object sender, RoutedEventArgs e)
        {
            AnimalNow = GridViewAnimals.SelectedItem as IAnimal; //Выбранный объект
            repository.Delete(AnimalNow);
        }

        /// <summary>
        /// Кнопка сохранения
        /// </summary>
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            repository.SaveAnimals("Animal"); //пока что имя по умолчанию
        }

        private void SaveModCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SaveModCombobox.SelectedItem != null)
            {
                IAnimalSave typeSave = (IAnimalSave)SaveModCombobox.SelectedItem;
                repository.Mode = typeSave;
            }
        }
    }
}
