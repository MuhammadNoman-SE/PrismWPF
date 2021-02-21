using N1.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace N1
{
    public class N1M : IModule
    {
        IRegionManager r;
        public N1M(IRegionManager _r)
        {
            r = _r;

        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            r.RegisterViewWithRegion("N1",typeof(PersonList));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<PersonDetail>();
        }
    }
}
