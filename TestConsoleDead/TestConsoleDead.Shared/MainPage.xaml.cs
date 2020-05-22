using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TestConsoleDead.Shared;
using TestConsoleDead.Shared.Models;
using TestConsoleDead.Shared.ViewModel;
using Uno.Extensions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestConsoleDead
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public CreateViewModel viewModel { get; set; } = new CreateViewModel();

        public MainPage()
        {
            this.InitializeComponent();
            createFormControl.DataContext = viewModel.CreateModel[0];
        }

        public void LoadStepControl(Object sender, RoutedEventArgs e)
        {
            //CreateNavigationctrl.StepControlSource = viewModel.LoadStepsData();
            createFormControl.SectionControlSource = viewModel.CreateModel[0].SubSectionList;
           // Console.WriteLine($"section {createFormControl.SectionControlSource.Count}");
        }

       

    }
}
