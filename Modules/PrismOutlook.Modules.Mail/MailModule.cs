using Prism.Outlook.Modules.Mail.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismOutlook.Core;
using PrismOutlook.Modules.Mail.Menus;

namespace Prism.Outlook.Modules.Mail
{
    public class MailModule : IModule
    {
        public MailModule(IRegionManager regionManager)
        {
            RegionManager = regionManager;
        }

        public IRegionManager RegionManager { get; }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            // TODO: remove after we start utilizing navigation
            RegionManager.RegisterViewWithRegion(RegionNames.ContentRegion, typeof(ViewA));

            RegionManager.RegisterViewWithRegion(RegionNames.RibbonRegion, typeof(HomeTab));
            RegionManager.RegisterViewWithRegion(RegionNames.OutlookGroupRegion, typeof(MailGroup));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}