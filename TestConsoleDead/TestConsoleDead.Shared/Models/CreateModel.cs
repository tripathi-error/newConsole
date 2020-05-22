using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.AccessControl;
using System.Text;
using Windows.UI.Xaml.Media;

namespace TestConsoleDead.Shared.Models
{
    public class CreateModel : BaseModel
    {
        private string _mainSectionName;
        private int _mainSectionOrder;
        private bool _isSelected;
        private SolidColorBrush _selectedSectionColor;
        private ObservableCollection<CreateSubSectionModel> _subSectionList;

        public string MainSectionName
        {
            get { return _mainSectionName; }
            set
            {
                _mainSectionName = value;
                RaisePropertyChanged("MainSectionName");
            }
        }

        public int MainSectionOrder
        {
            get { return _mainSectionOrder; }
            set
            {
                _mainSectionOrder = value;
                RaisePropertyChanged();
            }
        }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                RaisePropertyChanged();
            }
        }

        public SolidColorBrush SelectedSectionColor
        {
            get { return _selectedSectionColor; }
            set { _selectedSectionColor = value;
                RaisePropertyChanged();
            }
        }

        public ObservableCollection<CreateSubSectionModel> SubSectionList
        {
            get { return _subSectionList; }
            set
            {
                _subSectionList = value;
                RaisePropertyChanged();
            }
        }
    }

    public class CreateSubSectionModel : BaseModel
    {
        private string _subSectionName;

        public string SubSectionName
        {
            get { return _subSectionName; }
            set
            {
                _subSectionName = value;
                RaisePropertyChanged();
            }
        }

        private int _subSectionOrder;

        public int SubSectionOrder
        {
            get { return _subSectionOrder; }
            set
            {
                _subSectionOrder = value;
                RaisePropertyChanged();
            }
        }

        private ObservableCollection<CreateControlModel> _createControls;

        public ObservableCollection<CreateControlModel> CreateControls
        {
            get { return _createControls; }
            set
            {
                _createControls = value;
                RaisePropertyChanged();
            }
        }
        private bool isSectionOff;

        public bool IsSectionOff
        {
            get { return isSectionOff; }
            set { isSectionOff = value; 
                RaisePropertyChanged();
            }
        }

    }

    public class CreateControlModel : BaseModel
    {
        private Guid _uId;

        public Guid Uid
        {
            get { return _uId; }
            set
            {
                _uId = value;
                RaisePropertyChanged();
            }
        }

        private string _labelName;

        public string LabelName
        {
            get { return _labelName; }
            set
            {
                _labelName = value;
                RaisePropertyChanged();
            }
        }

        private string _placeHolder;

        public string PlaceHolder
        {
            get { return _placeHolder; }
            set
            {
                _placeHolder = value;
                RaisePropertyChanged();
            }
        }

        private CreateTypes _createType;

        public CreateTypes CreateType
        {
            get { return _createType; }
            set
            {
                _createType = value;
                RaisePropertyChanged();
            }
        }

        private object[] _controlValue;

        public object[] ControlValue
        {
            get { return _controlValue; }
            set
            {
                _controlValue = value;
                RaisePropertyChanged();
            }
        }

    }



    public enum CreateTypes
    {
        MultipleSelection, SingleSelect, TextOnly, Numeric, Money, Date, DateTime, Bool, CheckBox
    }
}
