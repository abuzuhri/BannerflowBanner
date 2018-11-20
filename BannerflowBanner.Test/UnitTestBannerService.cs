using BannerflowBanner.Service.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BannerflowBanner.Test
{
    [TestClass]
    public class UnitTestBannerService
    {
        

        [TestMethod]
        public void AddBanner()
        {
            BannerService bannerService = new BannerService();
            bannerService.AddBanner(1,"</b><b>hi<a>");
        }

        [TestMethod]
        public void UpdateBanner()
        {
            BannerService bannerService = new BannerService();
            bannerService.AddBanner(1,"hi2");
        }
        [TestMethod]
        public void GetAllBanner()
        {
            BannerService bannerService = new BannerService();
            bannerService.GetBanners();
        }
        [TestMethod]
        public void DeleteBanner()
        {
            BannerService bannerService = new BannerService();
            bannerService.DeleteBanner(1);
        }
    }
}
