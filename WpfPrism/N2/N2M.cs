using N2.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace N2
{
    public class N2M : IModule
    {
        IRegionManager r;
        public N2M(IRegionManager _r)
        {
            r = _r;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            r.RegisterViewWithRegion("N2",typeof(PPersonList));
            r.RegisterViewWithRegion("N2", typeof(PPersonDetail));

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<PPersonDetail>();
            containerRegistry.RegisterForNavigation<PPersonList>();

        }
    }
}
