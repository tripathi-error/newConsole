using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using TestConsoleDead.Shared.Converters;
using TestConsoleDead.Shared.Models;
using TestConsoleDead.Shared.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace TestConsoleDead.Shared
{
    public sealed partial class GenericControl : UserControl
    {
        public GenericControl()
        {
            InitializeComponent();
            DataContextChanged += (s, e) =>
            {
                var createModel = this.DataContext as CreateModel;
               // CreateControlsUsingObjects(createModel);
            };
       
        }

        public ObservableCollection<CreateSubSectionModel> SectionControlSource
        {
            get
            {
                return (ObservableCollection<CreateSubSectionModel>)GetValue(SectionControlSourceProperty);
            }
            set
            {
                SetValue(SectionControlSourceProperty, value);
            }
        }

        // Using a DependencyProperty as the backing store for ItemSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SectionControlSourceProperty =
            DependencyProperty.Register("SectionControlSource", typeof(ObservableCollection<CreateSubSectionModel>), typeof(GenericControl), new PropertyMetadata(null, PropertyChangedCallback));


        private static void PropertyChangedCallback(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs args)
        {
            GenericControl userControl = ((GenericControl)dependencyObject);
            userControl.SectionControlSource = (ObservableCollection<CreateSubSectionModel>)args.NewValue;
        }

    }
}
