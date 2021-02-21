using C;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace N2.ViewModels
{
    public class PPersonDetailViewModel:BindableBase,INavigationAware
    {

        private Person _selectedPerson;
        public Person SelectedPerson
        {
            get { return _selectedPerson; }
            set { SetProperty(ref _selectedPerson, value); }
        }
        private DelegateCommand b;

        public DelegateCommand B
        {
            get { return b; }
            set {SetProperty(ref b , value); }
        }
        private void bc()
        {
            j.GoBack();
        }
        private bool cb()
        {
            return true;// null != j && j.CanGoBack;
        }
        public PPersonDetailViewModel()
        {
            B = new DelegateCommand(bc,cb);

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            if(navigationContext.Parameters.ContainsKey("p")){
                SelectedPerson = navigationContext.Parameters.GetValue<Person>("p");
            }
            j = navigationContext.NavigationService.Journal;
            B.RaiseCanExecuteChanged();
        }
        IRegionNavigationJournal j;
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
           // if (SelectedPerson == navigationContext.Parameters.GetValue<Person>("p"))
            return true;
           // return false;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            B.RaiseCanExecuteChanged();

        }
    }
}
