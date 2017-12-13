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

        [System.Web.Http.HttpGet]
        public  JsonResult EulerMethod(MethodParams methodParams)
        {
            methodParams = new MethodParams();
            methodParams.StartValue = 1;
            methodParams.EndValue = 3;
            methodParams.NumberOfStep = 10;
            IEnumerable<double> result;

            double tau = 1;

            func function = new func(Function);
            result =  EulerMethodRealisation(function, methodParams.StartValue, methodParams.EndValue, methodParams.NumberOfStep, tau);
            return Json(result, JsonRequestBehavior.AllowGet); 
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

        public delegate double func(double t);

        public double Function(double t)
        {
            return 6 * (t);
        }

        public static double StartValue(double t)
        {
            return t;
        }

        public static List<double> EulerMethodRealisation(func f, double a, double b, int n, double tau)
        {
            double step = tau / n;
            double result = a;
            int m = Convert.ToInt32(Math.Ceiling(b / tau));
            double start = a, end = a + tau;

            double[,] x = new double[m + 1, n + 1];
            double[] fi = new double[m + 1];

            fi[0] = StartValue(start);

            int l = 0;
            for (double i = start - tau; i < start; i += step)
            {
                x[0, l] = StartValue(i);
                //Console.WriteLine("{0} = {1} ", i, x[0, l++]);
            }

            for (int i = 1; i < m; i++)
            {
                int k = 0;
                x[i, 0] = fi[i - 1];

                for (double j = start; j < end; j += step)
                {
                    x[i, k + 1] = x[i, k] + step * f(fi[i]);
                    fi[i] = StartValue(j);
                    // Console.WriteLine("{0} = {1} ", j, x[i, k]);
                    k++;
                }

                fi[i] = x[i, n - 1];
                start += tau;
                end += tau;
            }

            List<double> resultList = new List<double>();

            for (int i = 0; i < m ; i++)
            {
                int k = 0;
                double eps = 0.00001;
                for (double j = start; j < end; j += step)
                {
                    if (j % 0.1 < eps)
                    {
                        resultList.Add(x[i, k]);
                    }
                    k++;
                }
            }

            return resultList;
        }
    }
}
