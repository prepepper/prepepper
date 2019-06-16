using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TradeManager.Controllers
{       
    public class MarketController : Controller
    {
        /// <summary>
        /// 상세 페이지
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public IActionResult Detail(int id)
        {
            return View(id);
        }
    }
}