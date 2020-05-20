using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Lab10
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<User> Users = new ObservableCollection<User>()
        {
            new User(1,"testowy",0),
            new User(2,"testowy2",0),
            new User(3,"testowy3",0)

        };
        public MainWindow()
        {
            InitializeComponent();
            MyListView.ItemsSource = Users;
            MyListBox.ItemsSource = Users;
            new FWWindow().Show();
        }
        //Dodaj
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Users.Add(new User(0,"newTest",0));
        }
        //Edytuj
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Users[0].Points += 10;
        }
        //Usun
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            if (Users.Any())
            {
                Users.RemoveAt(0);
            }
            
        }
    }
}
