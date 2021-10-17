using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyConverter.Controllers
{
    public class ConverterController : Controller
    {
        public IActionResult Index()
        {
            return View("ConverterView" );
        }
        public IActionResult convert(int usd, int rate) {
            Models.Currency curr = new Models.Currency(rate);
            curr.convert(usd);
            return View("ConverterView", curr);
        }
    }
}
