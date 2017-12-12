using MathMod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace MathMod.Controllers
{
    public class MethodsController : Controller
    {
        public MethodsController()
        {

        }

        public ActionResult Index()
        {
            return View();
        }
        public class TestData
        {
            public string equation { get; set; }
            public string koshi { get; set; }

        }

        [System.Web.Http.HttpPost]
        public JsonResult TestPost(TestData data)
        {
            return Json("your equation:" + data.equation + "end your params" + data.koshi);
        }

        public async Task<IEnumerable<double>> EulerMethod(MethodParams methodParams)
        {
            methodParams = new MethodParams();
            List<double> result = new List<double>();
            return result; 
        }
        
        public async Task<IEnumerable<double>> RunheKuta(MethodParams methodParams)
        {
            methodParams = new MethodParams();
            List<double> result = new List<double>();
            return result;
        }
        
        public async Task<IEnumerable<double>> Method3(MethodParams methodParams)
        {
            methodParams = new MethodParams();
            List<double> result = new List<double>();
            return result;
        }
        
        public async Task<IEnumerable<double>> Method4(MethodParams methodParams)
        {
            methodParams = new MethodParams();
            List<double> result = new List<double>();
            return result;
        }
    }
}
