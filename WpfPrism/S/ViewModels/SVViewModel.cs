using C;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace S.ViewModels
{
    public class SVViewModel:BindableBase
    {
        public SVViewModel(ICC cc)
        {
            SA = cc;
        }
        private ICC myVar;

        public ICC SA
        {
            get { return myVar; }
            set {SetProperty(ref myVar , value); }
        }

    }
}
