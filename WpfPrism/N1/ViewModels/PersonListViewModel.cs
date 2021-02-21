using C;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace N1.ViewModels
{
    public class PersonListViewModel:BindableBase,INavigationAware
    {
        private ObservableCollection<Person> _people;
        public ObservableCollection<Person> People
        {
            get { return _people; }
            set { SetProperty(ref _people, value); }
        }

        public DelegateCommand<Person> PersonSelectedCommand { get; private set; }
        IRegionManager r;
        public PersonListViewModel(IRegionManager _r)
        {
            PersonSelectedCommand = new DelegateCommand<Person>(PersonSelected);
            CreatePeople();
            r=_r;
        }

        private void PersonSelected(Person person)
        {
            NavigationParameters np = new NavigationParameters();
            if(null!=person)
            np.Add("p",person);
            r.RequestNavigate("PersonDetailsRegion", "PersonDetail",np);
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
