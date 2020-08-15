using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_AppleLaLa;
using MVC_AppleLaLa.Controllers;
using MVC_AppleLaLa.Servicies;
using MVC_AppleLaLa.ViewModels.Home;

namespace MVC_AppleLaLa.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            HomePageService homeService = new HomePageService();
            HomeViewModel data = new HomeViewModel();
            data.homeOurServicesList = homeService.GetOurServiceData();
            data.BannerList = homeService.GetBannerData();
            data.HomeEnvironmentViewList = homeService.GetHomeEnvironmentData();

            Assert.IsNotNull(data.homeOurServicesList);
            Assert.IsNotNull(data.BannerList);
            Assert.IsNotNull(data.HomeEnvironmentViewList);

        }                                              
                                                       
    }
}
