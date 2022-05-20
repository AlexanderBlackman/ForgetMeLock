using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using ForgetMeLock.Backend.Model;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Markup;
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

namespace ForgetMeLock.UI.UserControls
{
    [ContentProperty(Name = nameof(Note))]
    public sealed partial class MarkdownInputBox : UserControl
    {
        public MarkdownInputBox()
        {
            this.InitializeComponent();
        }

        public static readonly DependencyProperty NoteProperty =
            DependencyProperty.Register("Note", typeof(Note), typeof(MarkdownInputBox),
                new PropertyMetadata(null));



        public Note Note
        {
            get { return (Note)GetValue(NoteProperty); }
            set { SetValue(NoteProperty, value); }
        }


    }
}
