using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestConsoleDead.Shared.Models
{
    public class Test : INotifyPropertyChanged
    {

		private string _headerText;

		public string HeaderText
		{
			get { return _headerText; }
			set { _headerText = value;
				
					RaisePropertyChanged("HeaderText");

				}

	}


		public event PropertyChangedEventHandler PropertyChanged;
		public void RaisePropertyChanged([CallerMemberName]string prop = "") {
			if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(prop));
		}
	}
}
