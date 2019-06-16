using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TradeManager.Controllers
{
    public class MainController : Controller
    {
        /// <summary>
        /// 메인
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 흑우의 역사
        /// </summary>
        /// <returns></returns>
        public IActionResult History()
        {
            return View();
        }

        /// <summary>
        /// 만든이
        /// </summary>
        /// <returns></returns>
        public IActionResult Maker()
        {
            return View();
        }
    }
}