using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_AppleLaLa.Controllers;
using MVC_AppleLaLa.Servicies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVC_AppleLaLa.Controllers.Tests
{
    [TestClass()]
    public class ServicesControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            var service = new Services_Service();
            var viewmodel = service.GetPortfilo();
            var vm = service.GetService();

            Assert.IsNotNull(viewmodel);
            Assert.IsNotNull(vm);
        }
    }
}