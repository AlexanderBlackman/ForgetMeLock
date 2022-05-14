using CommunityToolkit.Mvvm.DependencyInjection;
using ForgetMeLock.Backend.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using ForgetMeLock.Backend.Model;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ForgetMeLock.UI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InputPage : Page
    {
        public InputViewModel ViewModel { get; }
        public InputPage()
        {
            this.InitializeComponent();
            ViewModel = Ioc.Default.GetService<InputViewModel>();

        }

        //private void HappyClick(object sender, RoutedEventArgs e)
        //{

        //}
        //private void HappyClick(object sender, RoutedEventArgs e) => ViewModel.selectedMood = Backend.Model.Mood.Happy;
        //private void SadClick(object sender, RoutedEventArgs e) => ViewModel.selectedMood = Backend.Model.Mood.Sad;
        //private void WorriedClick(object sender, RoutedEventArgs e) => ViewModel.selectedMood = Backend.Model.Mood.Worried;
        //private void HappyClick(object sender, RoutedEventArgs e) => ViewModel.selectedMood = Backend.Model.Mood.Lovestruck;

        private void MoodSelectClick(object sender, RoutedEventArgs e)
        {
            //Button selected = (Button)sender;
            //foreach (Button button in MoodSelectSP.Children)
            //{
            //    button.IsEnabled = false;
            //}
        }

        private void MoodSelectRB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is RadioButtons rb)
            {
                String mood = (String)rb.Tag;

                ViewModel.selectedMood = mood switch
                {
                    "Happy" => Mood.Happy,
                    "Sad" => Mood.Sad,
                    "Worried" => Mood.Worried,
                    "Lovestruck" => Mood.Lovestruck,
                    "Angry" => Mood.Angry,
                    _ => Mood.Frustrated
                };

            }
        }
    }
}
