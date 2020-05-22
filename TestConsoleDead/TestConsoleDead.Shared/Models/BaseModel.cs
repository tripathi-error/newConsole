using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestConsoleDead.Shared.Models
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName]string prop = "") {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(prop)); 
        }
    }
}
