using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class AdressViewModel : INotifyPropertyChanged
    {
        public AdressViewModel()
        {
            Model = new Adress("Testweg1", "Entenhausen", "Hessen", "4711");
        }

        public Adress Model { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        [Required]
        public string Street
        {
            get { return Model.Street; }
            set
            {
                Model.Street = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Street)));
            }
        }

        [Required]
        public string City
        {
            get { return Model.City; }
            set
            {
                Model.City = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(City)));
            }
        }

        [Required]
        public string State
        {
            get { return Model.State; }
            set
            {
                Model.State = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(State)));
            }
        }

        [Required]
        public string Zip
        {
            get { return Model.Zip; }
            set
            {
                Model.Zip = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Zip)));
            }
        }
    }


}
