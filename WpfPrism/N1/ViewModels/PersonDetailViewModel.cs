using C;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace N1.ViewModels
{
    public class PersonDetailViewModel:BindableBase,INavigationAware
    {

        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { SetProperty(ref _selectedPerson, value); }
        }

        public PersonDetailViewModel()
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            if(navigationContext.Parameters.ContainsKey("p")){
                SelectedPerson = navigationContext.Parameters.GetValue<Person>("p");
            }
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            if (SelectedPerson == navigationContext.Parameters.GetValue<Person>("p"))
            return true;
            return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }
    }
}
