using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgetMeLock.Backend.Model;
using ForgetMeLock.Backend.Contracts;


namespace ForgetMeLock.Backend.ViewModels
{
    public class InputViewModel
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
