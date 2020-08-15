using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_AppleLaLa.Controllers;
using MVC_AppleLaLa.Models;
using MVC_AppleLaLa.Servicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace MVC_AppleLaLa.Controllers.Tests
{
    [TestClass()]
    public class ShippingProcessControllerTests
    {
        [TestMethod()]
        public void Choose_services_listTest()
        {
            Choose_service_listServicies Csl_service = new Choose_service_listServicies();
            var data = Csl_service.GetData();

            Assert.IsNotNull(data);
        }

        [TestMethod()]
        public void shopping_cartTest()
        {
            ShopingCartViewModel model = new ShopingCartViewModel();
            var service = new Shopping_Cart_Service();
            model.ReserveItem = "手部精緻保養,足部精緻保養";
            var get_service_price_model = service.GetService(model.ReserveItem);

            var user_name = "oo@gmail.com";
            var Account = new AccountDetailService();

            var viewmodel = Account.get_account_detail(user_name);
            var _Coupon = service.GetCoupon(viewmodel.Cust_id);

            var get_designer_model = service.GetDesigners();

            var get_session = service.Get_Session_list();

            Assert.IsNotNull(get_service_price_model);
            Assert.IsNotNull(viewmodel);
            Assert.IsNotNull(_Coupon);
            Assert.IsNotNull(get_designer_model);
            Assert.IsNotNull(get_session);
        }

        [TestMethod()]
        public void Work_Schedule_JSONTest()
        {
            var service = new Shopping_Cart_Service();
            var data = JsonConvert.SerializeObject(service.Get_Work_Schedule());
            Assert.IsNotNull(data);
        }
    }
}