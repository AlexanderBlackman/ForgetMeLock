using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
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
//Note this is just for testing purposes before a view model
using ForgetMeLock.Backend.Model;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ForgetMeLock.UI.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NotesDuePage : Page
    {
        public List<Note> Notes { get; set; }

        public NotesDuePage()
        {
            Notes = new List<Note>()
            {
                new Note(){ Title = "Buy Milk", Content = "The following image shows a PipsPager used with a small photo gallery (we recommend centering the PipsPager below the gallery).", DueTime = DateTime.Now.AddHours(2), StateOfMind = Mood.Worried},
                new Note(){ Title= "Send flowers", Content = "By default, the flip view flips horizontally. To make the it flip vertically, use a stack panel with a vertical orientation as the flip view's", DueTime = DateTime.Now.AddHours(-2), StateOfMind = Mood.Frustrated},
                new Note(){ Title= "Pay the bill", Content= " with localized value to your localization resource files: TextBox.PlaceholderText And then depending on phone's region and language", DueTime=DateTime.Now.AddHours(5), StateOfMind = Mood.Lovestruck},
            };

            this.InitializeComponent();

        }
    }
}
