using C;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace P.ViewModels
{
    public class PVViewModel:BindableBase
    {
        private string t="1";

        public string T
        {
            get { return t; }
            set { SetProperty(ref t, value); }
        }

        private bool ic=true;

        public bool IC
        {
            get { return ic; }
            set { SetProperty(ref ic, value); }
        }
        IEventAggregator ea { get; }
        public PVViewModel(ICC cc,IEventAggregator _e)
        {
            PC = new DelegateCommand(e,c);
            PC.ObservesProperty(()=> IC);
            cc.CCS.RegisterCommand(PC);
            ea = _e;
        }
        public bool c() {
            return ic;
        }
        EA ev;
        public void e()
        {
           // ServiceReference2.Service1Client p = new ServiceReference2.Service1Client(); 
            
            //int m = Int16.Parse(T);
            //T=p.GetData(m);
 
            ev=ea.GetEvent<EA>();
            ev.Publish(T);
        }
        private DelegateCommand myVar;

        public DelegateCommand PC
        {
            get { return myVar; }
            set {SetProperty(ref myVar , value); }
        }

    }
}
