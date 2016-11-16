using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App9
{
    class ViewModel : INotifyPropertyChanged
    {
        private string mintext;

        public string MinText
        {
            get { return mintext; }
            set {
                mintext = value;
                OnPropertyChanged(nameof(MinText));

            }
        }

        public ViewModel()
        {
            MinText = "987654";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

    }
}
