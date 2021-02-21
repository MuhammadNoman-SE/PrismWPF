using C;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace L.ViewModels
{
    public class LVViewModel:BindableBase
    {

        private ObservableCollection<string> t=new ObservableCollection<string>();

        public ObservableCollection<string> T
        {
            get { return t; }
            set {SetProperty(ref t , value); }
        }

        private bool ic=true;

        public bool IC
        {
            get { return ic; }
            set {SetProperty(ref ic , value);hs(ic); }
        }
        IEventAggregator ea;
        public LVViewModel(ICC cc,IEventAggregator _e)
        {
            PC = new DelegateCommand(e, c);
            PC.ObservesProperty(() => IC);
            cc.CCS.RegisterCommand(PC);
            ea = _e;
            ev = ea.GetEvent<EA>();
            hs(true);
        }
        private void hs(bool i) {
            if (i)
                ev.Subscribe(s);
            else
                ev.Unsubscribe(s);
        }
        public bool c()
        {
            return ic;
        }
        EA ev;
        public void e()
        {
            T.Clear();
        }
        private void s(string m) {
            T.Add(m);
        }
        private DelegateCommand myVar;

        public DelegateCommand PC
        {
            get { return myVar; }
            set {SetProperty(ref myVar , value); }
        }

    }
}
