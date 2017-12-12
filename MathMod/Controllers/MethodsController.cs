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
