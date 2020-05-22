using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TestConsoleDead.Shared.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace TestConsoleDead.Shared
{
    public sealed partial class CreateEditSectionControl : UserControl
    {
        public CreateEditSectionControl()
        {
            this.InitializeComponent();

            DataContextChanged += (s, e) =>
            {
                if (DataContext is ObservableCollection<CreateControlModel>)
                {
                    var createModel = DataContext as ObservableCollection<CreateControlModel>;
                    CreateControlsUsingObjects(createModel);
                }
            };
        }


        private void CreateControlsUsingObjects(ObservableCollection<CreateControlModel> obj)
        {

            sectionGridLayout.ColumnDefinitions.Add(
               new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

            sectionGridLayout.ColumnDefinitions.Add(
               new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) });

            int temp = 0;
            // var controlsCount = obj.Select(i => i).ToList();

            for (int i = 0; i < obj.Count; i++)
            {
                int row = i / 2;
                if (row == 0 || temp != row)
                {
                    sectionGridLayout.RowDefinitions.Add(CreateRowDefinition(GridLength.Auto));
                }

                int col = i % 2;
                Console.WriteLine("i am in creat");


                switch (obj[i].CreateType)
                {
                    case CreateTypes.TextOnly:
                        //headerGrid.RowDefinitions.Add(CreateRowDefinition(GridLength.Auto));
                        var tb1 = new TextBox { Margin = new Thickness(0, 20, 0, 0)};

                        tb1.SetBinding(TextBox.PlaceholderTextProperty,
                          new Binding
                          {
                              Path = new PropertyPath($"CreateControls[{i}].PlaceHolder"),
                              Mode = BindingMode.TwoWay,
                              UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
                          }) ;
                        sectionGridLayout.Children.Add(tb1);
                        Grid.SetRow(tb1, row);
                        Grid.SetColumn(tb1, col);
                        break;

                   

                    default:
                        Console.WriteLine("Nothing");
                        break;
                }
                temp = row;


                //   LayoutRoot.Children.Add(wraps);
                // Grid.SetRow(wraps, j);

            }
          //  sectionGridLayout.Children.Add(gridBody);
           // Grid.SetRow(gridBody, 0);


        }

        private RowDefinition CreateRowDefinition(GridLength gridLength)
        {
            var RowDefinition = new RowDefinition();
            RowDefinition.Height = gridLength;
            return RowDefinition;
        }

    }
}
