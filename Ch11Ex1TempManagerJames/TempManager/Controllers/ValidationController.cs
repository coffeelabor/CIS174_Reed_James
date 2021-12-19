using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempManager.Models;


namespace TempManager.Controllers
{
    public class ValidationController : Controller
    {
        private TempManagerContext data { get; set; }
        public ValidationController(TempManagerContext tempContext) => data = tempContext;

        public JsonResult CheckDate(string date)
        {
            DateTime dTime = DateTime.Parse(date);
            Temp temp = data.Temps.FirstOrDefault(tem => tem.Date == dTime);

            if(temp == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"{date} is alread there");
            }
        }
    }
}
