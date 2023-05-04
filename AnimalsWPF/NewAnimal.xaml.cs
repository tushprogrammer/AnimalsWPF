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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace AnimalsWPF
{
    /// <summary>
    /// Логика взаимодействия для NewAnimal.xaml
    /// </summary>
    public partial class NewAnimal : Window
    {
        public NewAnimal(IAnimal NewAnimal)
        {
            InitializeComponent();
            Add.Click += delegate
            {
                //проверка на заполненность 
                if (NewName.Text == string.Empty ||
                NewCountryFrom.Text == string.Empty ||
                NewWeight.Text == string.Empty ||
                NewAge.Text == string.Empty)
                {
                    MessageBox.Show("Заполните все обязательные поля");
                    return;
                }
                double Weight, Age;

                try
                {
                    bool is_num = double.TryParse(NewWeight.Text.ToString(), out Weight);
                    if (!is_num)
                    {
                        throw new ExceptionNumber("Неправильный ввод в поле: ", "Вес");
                    }
                    
                    is_num = double.TryParse(NewAge.Text.ToString(), out Age);
                    if (!is_num)
                    {
                        throw new ExceptionNumber("Неправильный ввод в поле: ", "Возраст");
                    }
                }
                catch (ExceptionNumber e)
                {
                    MessageBox.Show(e.Message + e.Field);
                    return;
                }
                NewAnimal = AnimalFactory.GetAnimal(NewName.Text, NewCountryFrom.Text, Weight, Age, TypeAnimal.Text);

                this.DialogResult = true;



            };
        }

    }
}
