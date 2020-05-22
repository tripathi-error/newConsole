using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestConsoleDead.Shared.Models;

namespace TestConsoleDead.Shared.ViewModel
{
    public class TestViewModel : INotifyPropertyChanged
    {
		private Test _createModel = new Test();

		private string _textHeader;

		public Test CreateModel
		{
			get { return _createModel; }
			set { _createModel = value;
				
				RaisePropertyChanged();

				}
			
		}

		public TestViewModel() {
			CreateModel.HeaderText = "Ankit";
			CreateModel = CreateModel;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		public void RaisePropertyChanged([CallerMemberName]string prop = "")
		{
			if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(prop));
		}
	}
}
