using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestConsoleDead.Shared.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName]string prop = "") { if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(prop)); }

        private Boolean _IsBusy = false;
        public Boolean IsBusy
        {
            get { return _IsBusy; }
            set { _IsBusy = value; RaisePropertyChanged(); }
        }

        private string _Title = "";
        public string Title
        {
            get { return _Title; }
            set { _Title = value; RaisePropertyChanged(); }
        }

        private List<string> _ParentBreadcrumbs = new List<string>();
        public List<string> ParentBreadcrumbs
        {
            get { return _ParentBreadcrumbs; }
            set { _ParentBreadcrumbs = value; RaisePropertyChanged(); }
        }

    }
}
