using C;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace N2.ViewModels
{
    public class PPersonListViewModel:BindableBase,INavigationAware
    {
        private ObservableCollection<Person> _people;
        public ObservableCollection<Person> People
        {
            get { return _people; }
            set { SetProperty(ref _people, value); }
        }

        public DelegateCommand<Person> PersonSelectedCommand { get; private set; }
        IRegionManager r;
        IRegionNavigationJournal j;
        private DelegateCommand f;

        public DelegateCommand F
        {
            get { return f; }
            set {SetProperty(ref f , value); }
        }
        private void fc()
        {
            j.GoForward();
        }
        private bool cf()
        {
            return null!=j&&j.CanGoForward;
        }
        public PPersonListViewModel(IRegionManager _r)
        {
            PersonSelectedCommand = new DelegateCommand<Person>(PersonSelected);
            CreatePeople();
            r=_r;
            F = new DelegateCommand(fc,cf);
        }

        private void PersonSelected(Person person)
        {
            NavigationParameters np = new NavigationParameters();
            if(null!=person)
            np.Add("p",person);
            r.RequestNavigate("N2", "PPersonDetail",np);

        }

        public void nc() {
        }
        //demo code only, use a service in production code
        private void CreatePeople()
        {
            var people = new ObservableCollection<Person>();
            for (int i = 0; i < 10; i++)
            {
                people.Add(new Person()
                {
                    FirstName = String.Format("First {0}", i),
                    LastName = String.Format("Last {0}", i),
                    Age = i
                });
            }

            People = people;
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            j=navigationContext.NavigationService.Journal;
            F.RaiseCanExecuteChanged();
           
        }
        
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            
        }
    }
}
