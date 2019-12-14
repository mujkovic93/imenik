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

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Imenik> lista = new ObservableCollection<Imenik>();
        public MainWindow()
        {
            InitializeComponent();
            dg.ItemsSource = lista;

        }

        private void Button_Izmeni(object sender, RoutedEventArgs e)
        {
            Editor noviProzor = new Editor();
            noviProzor.Visibility = Visibility.Visible;
            noviProzor.DataContext = dg.SelectedItem;
        }

        private void Button_Dodaj(object sender, RoutedEventArgs e)
        {
            Editor noviProzor = new Editor();
            noviProzor.Visibility = Visibility.Visible;
            noviProzor.DataContext = lista;
        }

        private void Button_Izbrisi(object sender, RoutedEventArgs e)
        {
            if (dg.SelectedItem == null)
            {
                MessageBox.Show("Izaberite nesto!", "Greska");
            }
            else
            {
                lista.Remove(dg.SelectedItem as Imenik);
            }

        }
    }
}
