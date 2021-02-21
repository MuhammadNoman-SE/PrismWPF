using L.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Text;

namespace L
{
    public class LM : IModule
    {
        IRegionManager r;
        public LM(IRegionManager _r)
        {
            r = _r;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            r.RegisterViewWithRegion("L", typeof(LV));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}
