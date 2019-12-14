using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8
{
    class Imenik : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string ime;

        public string Ime
        {
            get => ime;
            set
            {
                ime = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs("Ime"));
            }
        }

        private string prezime;

        public string Prezime
        {
            get => prezime;
            set
            {
                prezime = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs("Prezime"));
            }
        }

        private string telefon;

        public string Telefon
        {
            get => telefon;
            set
            {
                telefon = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs("Telefon"));
            }
        }

        public Imenik(string i, string p, string t)
        {
            Ime = i;
            Prezime = p;
            Telefon = t;
        }
        public Imenik(string i, string t)
        {
            Ime = i;
            Telefon = t;
        }

        

    }
}
