using C;
using L;
using N1;
using N2;
using P;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using S;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfPrism.Views;

namespace WpfPrism
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<WindowShell>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

            containerRegistry.RegisterSingleton<ICC,CC>();
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<SM>();
            moduleCatalog.AddModule<PM>();
            moduleCatalog.AddModule<LM>();
            moduleCatalog.AddModule<N1M>();
            moduleCatalog.AddModule<N2M>();

        }
    }
}
