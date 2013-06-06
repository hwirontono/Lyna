using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DollarXpressBusinessServices;
using DollarXpressViewModel;

namespace DollarXpress.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetCustomers(string FieldName, string KeyWord)
        {
            CustomerBusinessService cbs = new CustomerBusinessService();
            return Json(cbs.GetCustomers(FieldName, KeyWord).Customers);
        }

        [HttpPost]
        public ActionResult GetCustomers2(FormCollection postedFormData)
        {
            CustomerBusinessService cbs = new CustomerBusinessService();
            string FieldName = Convert.ToString(postedFormData["FieldName"]);
            string KeyWord = Convert.ToString(postedFormData["KeyWord"]);
            return Json(cbs.GetCustomers(FieldName, KeyWord).Customers);
        }

        //[HttpPost]
        //public ActionResult GetCustomers(FormCollection postedFormData)
        //{
        //    CustomerBusinessService cbs = new CustomerBusinessService();
        //    string FieldName = Convert.ToString(postedFormData["FieldName"]);
        //    string KeyWord = Convert.ToString(postedFormData["KeyWord"]);

        //    return Json(cbs.GetCustomers(FieldName, KeyWord).Customers);
        //}
    }
}
