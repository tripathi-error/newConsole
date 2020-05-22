using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using TestConsoleDead.Shared.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace TestConsoleDead.Shared.ViewModel
{
    public class CreateViewModel : BaseViewModel
    {
        private ObservableCollection<CreateModel> _createModel = new ObservableCollection<CreateModel>();
        //private ObservableCollection<StepControlModel> _stepControlModel = new ObservableCollection<StepControlModel>();
        public ObservableCollection<CreateModel> CreateModel
        {
            get { return _createModel; }
            set
            {
                _createModel = value;
                RaisePropertyChanged("CreateModel");
            }
        }


        //public ObservableCollection<StepControlModel> StepControls
        //{
        //    get { return _stepControlModel; }
        //    set
        //    {
        //        _stepControlModel = value;
        //        RaisePropertyChanged();
        //    }
        //}

        public CreateViewModel()
        {
            LoadData();
        }

        public void LoadData()
        {
            var createSubSectionModelOne = new CreateSubSectionModel
            {
                SubSectionName = "Select an individual",
                SubSectionOrder = 1,
                CreateControls = new ObservableCollection<CreateControlModel>()
            };
            //var tr = new CreateControlModel
            //{
            //    Uid = Guid.NewGuid(),
            //    CreateType = CreateTypes.SingleSelect,
            //    LabelName = "Prefix",
            //    PlaceHolder = "",
            //    ControlValue = new object[] { "Mr", "Mrs", "Ms", "Dr", "Sri" }
            //};
            var tr = new CreateControlModel
            {
                Uid = Guid.NewGuid(),
                CreateType = CreateTypes.TextOnly,
                LabelName = "Email Address",
                PlaceHolder = "Email Address",
                ControlValue = new object[] { "tripathi@gmail.com" }
            };


            createSubSectionModelOne.CreateControls.Add(tr);

            var createModel1 = new CreateModel
            {
                MainSectionName = "Select an individual type",
                MainSectionOrder = 1,
                IsSelected = true,
                //SelectedSectionColor = Application.Current.Resources["ColorCompanyBrush"] as SolidColorBrush,
                SubSectionList = new ObservableCollection<CreateSubSectionModel>()
            };

            createModel1.SubSectionList.Add(createSubSectionModelOne);
            _createModel.Add(createModel1);


            var createSubSectionModel1 = new CreateSubSectionModel
            {
                SubSectionName = "Basic Information 1",
                SubSectionOrder = 1,
                IsSectionOff = false,
                CreateControls = new ObservableCollection<CreateControlModel>()
            };

            createSubSectionModel1.CreateControls.Add(tr);
            createSubSectionModel1.CreateControls.Add(new CreateControlModel
            {
                Uid = Guid.NewGuid(),
                CreateType = CreateTypes.TextOnly,
                LabelName = "Email Address",
                PlaceHolder = "Email Address",
                ControlValue = new object[] { }
            });

            createSubSectionModel1.CreateControls.Add(new CreateControlModel
            {
                Uid = Guid.NewGuid(),
                CreateType = CreateTypes.TextOnly,
                LabelName = "",
                PlaceHolder = "First Name",
                ControlValue = new object[] { }
            });
            createSubSectionModel1.CreateControls.Add(new CreateControlModel
            {
                Uid = Guid.NewGuid(),
                CreateType = CreateTypes.TextOnly,
                LabelName = "",
                PlaceHolder = "Middle Name",
                ControlValue = new object[] { }
            });
            createSubSectionModel1.CreateControls.Add(new CreateControlModel
            {
                Uid = Guid.NewGuid(),
                CreateType = CreateTypes.TextOnly,
                LabelName = "",
                PlaceHolder = "Last Name",
                ControlValue = new object[] { }
            });

            //createSubSectionModel1.CreateControls.Add(new CreateControlModel
            //{
            //    Uid = Guid.NewGuid(),
            //    CreateType = CreateTypes.SingleSelect,
            //    LabelName = "Suffix",
            //    PlaceHolder = "",
            //    ControlValue = new object[] { "Mr", "Mrs", "Ms", "Dr", "Sri" }
            //});
            //createSubSectionModel1.CreateControls.Add(new CreateControlModel
            //{
            //    Uid = Guid.NewGuid(),
            //    CreateType = CreateTypes.TextOnly,
            //    LabelName = "",
            //    PlaceHolder = "Designation",
            //    ControlValue = new object[] { }
            //});
            //createSubSectionModel1.CreateControls.Add(new CreateControlModel
            //{
            //    Uid = Guid.NewGuid(),
            //    CreateType = CreateTypes.SingleSelect,
            //    LabelName = "Status",
            //    PlaceHolder = "",
            //    ControlValue = new object[] { "Active", "InActive", "Default" }
            //});
            //createSubSectionModel1.CreateControls.Add(new CreateControlModel
            //{
            //    Uid = Guid.NewGuid(),
            //    CreateType = CreateTypes.TextOnly,
            //    LabelName = "",
            //    PlaceHolder = "Work Phone",
            //    ControlValue = new object[] { }
            //});
            //createSubSectionModel1.CreateControls.Add(new CreateControlModel
            //{
            //    Uid = Guid.NewGuid(),
            //    CreateType = CreateTypes.TextOnly,
            //    LabelName = "",
            //    PlaceHolder = "Home Phone",
            //    ControlValue = new object[] { }
            //});
            //createSubSectionModel1.CreateControls.Add(new CreateControlModel
            //{
            //    Uid = Guid.NewGuid(),
            //    CreateType = CreateTypes.Bool,
            //    LabelName = "Do not Email?",
            //    PlaceHolder = "",
            //    ControlValue = new object[] { false }
            //});
            createSubSectionModel1.CreateControls.Add(new CreateControlModel
            {
                Uid = Guid.NewGuid(),
                CreateType = CreateTypes.CheckBox,
                LabelName = "Favourite Sports",
                PlaceHolder = "",
                ControlValue = new object[] { "Auto updates", "Auto updates", "Auto updates" }
            });


            var createSubSectionModel2 = new CreateSubSectionModel
            {
                SubSectionName = "Basic Information 2",
                SubSectionOrder = 1,
                IsSectionOff = false,
                CreateControls = new ObservableCollection<CreateControlModel>()
            };

            createSubSectionModel2.CreateControls.Add(new CreateControlModel
            {
                Uid = Guid.NewGuid(),
                CreateType = CreateTypes.SingleSelect,
                LabelName = "Prefix",
                PlaceHolder = "",
                ControlValue = new object[] { "Mr", "Mrs", "Ms", "Dr", "Sri" }
            });
            createSubSectionModel2.CreateControls.Add(new CreateControlModel
            {
                Uid = Guid.NewGuid(),
                CreateType = CreateTypes.TextOnly,
                LabelName = "",
                PlaceHolder = "First Name",
                ControlValue = new object[] { }
            });
            createSubSectionModel2.CreateControls.Add(new CreateControlModel
            {
                Uid = Guid.NewGuid(),
                CreateType = CreateTypes.TextOnly,
                LabelName = "",
                PlaceHolder = "Last Name",
                ControlValue = new object[] { }
            });
            createSubSectionModel2.CreateControls.Add(new CreateControlModel
            {
                Uid = Guid.NewGuid(),
                CreateType = CreateTypes.TextOnly,
                LabelName = "",
                PlaceHolder = "Designation",
                ControlValue = new object[] { }
            });
            createSubSectionModel2.CreateControls.Add(new CreateControlModel
            {
                Uid = Guid.NewGuid(),
                CreateType = CreateTypes.TextOnly,
                LabelName = "",
                PlaceHolder = "Work Phone",
                ControlValue = new object[] { }
            });

            createSubSectionModel2.CreateControls.Add(new CreateControlModel
            {
                Uid = Guid.NewGuid(),
                CreateType = CreateTypes.TextOnly,
                LabelName = "Email Address",
                PlaceHolder = "Email Address",
                ControlValue = new object[] { }
            });

            //createSubSectionModel2.CreateControls.Add(new CreateControlModel
            //{
            //    Uid = Guid.NewGuid(),
            //    CreateType = CreateTypes.Bool,
            //    LabelName = "Do not Email",
            //    PlaceHolder = "",
            //    ControlValue = new object[] {false}
            //});
            createSubSectionModel2.CreateControls.Add(new CreateControlModel
            {
                Uid = Guid.NewGuid(),
                CreateType = CreateTypes.MultipleSelection,
                LabelName = "Email Address",
                PlaceHolder = "Email Address",
                ControlValue = new object[] { "List Item1", "List Item2", "List Item3" }
            });






            //  createModel1.SubSectionList.Add(createSubSectionModel2);

            var createModel2 = new CreateModel
            {
                MainSectionName = "Enter individual Information",
                MainSectionOrder = 2,
                IsSelected = false,
                //SelectedSectionColor = Application.Current.Resources["ColorListHeaderBackgroundBrush"] as SolidColorBrush,
                SubSectionList = new ObservableCollection<CreateSubSectionModel>()
            };

            var createModel3 = new CreateModel
            {
                MainSectionName = "Duplicates",
                MainSectionOrder = 3,
                IsSelected = false,
              //  SelectedSectionColor = Application.Current.Resources["ColorListHeaderBackgroundBrush"] as SolidColorBrush,
                SubSectionList = new ObservableCollection<CreateSubSectionModel>()
            };
            createModel2.SubSectionList.Add(createSubSectionModel1);

            //createModel2.SubSectionList.Add(createSubSectionModel2);
            /* Add to list */

            //_createModelList.Add(createModel1);
            _createModel.Add(createModel2);
            _createModel.Add(createModel3);

            CreateModel = _createModel;
        }

       

    }
}