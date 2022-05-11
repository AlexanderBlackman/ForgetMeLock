using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgetMeLock.Backend.Model;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ForgetMeLock.Backend.ViewModels
{
    public partial class ObservableNote : ObservableObject
    {
        private readonly Note note;
        public ObservableNote(Note note) => this.note = note;

        [ObservableProperty]
        private int id;
        [ObservableProperty]
        private string? title;
        [ObservableProperty]
        private DateTime dueTime;
        [ObservableProperty]
        private DateTime created;
        [ObservableProperty]
        private Mood stateOfMind;




    }
}
