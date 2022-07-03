using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tools.Earn;

namespace DesingPatternsAsp.Controllers
{
    public class ProductDetailController : Controller
    {
        private EarnFactory _localEarnFactory;
        private ForeignEarnFactory _foreignEarnFactory;

        public ProductDetailController(LocalEarnFactory localEarnFactory, ForeignEarnFactory foreignEarnFactory)
        {
            _localEarnFactory = localEarnFactory;
            _foreignEarnFactory = foreignEarnFactory;
        }
        public IActionResult Index(decimal total)
        {
            // Factories
            //LocalEarnFactory localEarnFactory = new LocalEarnFactory(0.20m);
            //ForeignEarnFactory foreignEarnFactory = new ForeignEarnFactory(0.30m, 20);

            // Products
            var localEar = _localEarnFactory.GetEarn();
            var foreignEar = _foreignEarnFactory.GetEarn();

            // total
            ViewBag.totalLocal = total + localEar.Earn(total);
            ViewBag.totalForeign = total + foreignEar.Earn(total);

            return View();
        }
    }
}
