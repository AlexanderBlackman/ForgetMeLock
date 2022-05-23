using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgetMeLock.Backend.Model;
using ForgetMeLock.Backend.Contracts;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ForgetMeLock.Backend.ViewModels
{
    public class InputViewModel : ObservableObject
    {
        public Mood selectedMood;
        private readonly IDataService dataService;

        public ObservableNote CurrentNote { get; set; } = new ObservableNote(new Note());


        public InputViewModel(IDataService dataService)
        {
            this.dataService = dataService;
        }
    }
}
