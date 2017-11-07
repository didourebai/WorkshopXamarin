using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sample3
{
    public class Page2ViewModel : INotifyPropertyChanged
    {
        private string labelText = "Hello";

        public string LabelText {
            get { return labelText; }
            set { labelText = value;
                RaisePropertyChanged();
            }
        }

        public event ProgressChangedEventHandler PropertyChanged;

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        protected void RaisePropertyChanged([CallerMemberName] string caller ="")
        {

        }
    }
}
