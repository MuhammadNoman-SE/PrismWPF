using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using S.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace S
{
    public class SM : IModule
    {
        IRegionManager r;
        public SM(IRegionManager _r)
        {
            r = _r;
        }
        public void OnInitialized(IContainerProvider containerProvider)
        {
            r.RegisterViewWithRegion("S",typeof(SV));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
    }
}
