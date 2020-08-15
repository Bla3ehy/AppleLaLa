using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_AppleLaLa.Controllers;
using MVC_AppleLaLa.Servicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MVC_AppleLaLa.Controllers.Tests
{
    [TestClass()]
    public class AccountDetailControllerTests
    {
        private AccountDetailService Account = new AccountDetailService();

        [TestMethod()]
        public void IndexTest()
        {
            var user_name = "oo@gmail.com";
            var viewmodel = Account.get_account_detail(user_name);
            var _order = Account.Get_order(viewmodel.Cust_id);
            var _Coupon = Account.Coupon(viewmodel.Cust_id);

            Assert.IsNotNull(_order);
            Assert.IsNotNull(_Coupon);
        }
    }
}