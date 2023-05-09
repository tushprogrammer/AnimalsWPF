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
    public partial class MainWindow : Window, IView
    {
        Presenter Presenter;

        public MainWindow()
        {
            InitializeComponent();
            SaveModCombobox.SelectedIndex = 0;
            Presenter = new Presenter(this);
            Presenter.Info(); 

        }
      
        /// <summary>
        /// Пкм - добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemAddClick(object sender, RoutedEventArgs e)
        {
            //открыть новое окно с формой заполнения 
            NewAnimal AnimalWindow = new NewAnimal();
            AnimalWindow.ShowDialog();
            if (AnimalWindow.DialogResult.Value)
            {
                Presenter.AddNewAnimal(AnimalWindow.Animal);
            }            
        }

        /// <summary>
        /// ПКМ - удалить
        /// </summary>
        private void MenuItemDeleteClick(object sender, RoutedEventArgs e)
        {
            Presenter.DeleteAnimal();
            
        }

        /// <summary>
        /// Кнопка сохранения
        /// </summary>
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Presenter.Save();
            
        }

        private void SaveModCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SaveModCombobox.SelectedItem != null)
            {
                //IAnimalSave typeSave = (IAnimalSave)SaveModCombobox.SelectedItem; //уже не надо
                Presenter.ChangeModSave();
            }
        }

        public ObservableCollection<IAnimal> Animals //таблица значений 
        {
            set => GridViewAnimals.DataContext = value;
        }

        public ObservableCollection<IAnimalSave> Saves //комбобокс вариантов сохранения
        {
            set => SaveModCombobox.ItemsSource = value;
        }

        public IAnimalSave ModSave //текущий объект из комбобокса
        {
            get => (IAnimalSave)this.SaveModCombobox.SelectedItem;
        }

        public IAnimal AnimalNow //выбранный сейчас объект 
        {
            get => (IAnimal)GridViewAnimals.SelectedItem;
        }
    }
}
