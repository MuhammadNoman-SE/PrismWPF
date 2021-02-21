using P.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace P
{
    public class PM : IModule
    {
        IRegionManager r;
        public PM(IRegionManager _r)
        {
            r = _r;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            r.RegisterViewWithRegion("P", typeof(PV));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
