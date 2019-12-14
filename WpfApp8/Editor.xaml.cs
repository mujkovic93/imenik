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
using System.Windows.Shapes;

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for Editor.xaml
    /// </summary>
    public partial class Editor : Window
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void Button_OK(object sender, RoutedEventArgs e)
        {
            if (DataContext is ObservableCollection<Imenik> kolekcija)
            {
                if (string.IsNullOrEmpty(ime.Text))
                {
                    MessageBox.Show("Unesite ime!");
                }
                else if (string.IsNullOrEmpty(prezime.Text))
                {
                    MessageBox.Show("Unesite prezime!");
                }

                else if (string.IsNullOrEmpty(telefon.Text))
                {
                    MessageBox.Show("Unesite broj telefona!");
                }
                else
                {
                    kolekcija.Add(new Imenik(ime.Text, prezime.Text, telefon.Text));
                    this.Close();
                }
                //standardni cast
                //((ObservableCollection<Artikal>)DataContext)
                //(DataContext as ObservableCollection<Artikal>)
            }
            else
            {
                BindingOperations.GetBindingExpression(ime, TextBox.TextProperty).UpdateSource();
                BindingOperations.GetBindingExpression(prezime, TextBox.TextProperty).UpdateSource();
                BindingOperations.GetBindingExpression(telefon, TextBox.TextProperty).UpdateSource();
                this.Close();
            }

        }
        private void Window_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (DataContext is ObservableCollection<Imenik>)
            {
                BindingOperations.ClearBinding(ime,
                    TextBox.TextProperty);
                BindingOperations.ClearBinding(prezime,
                    TextBox.TextProperty);
                BindingOperations.ClearBinding(telefon,
                    TextBox.TextProperty);


            }
        }
    }
}
