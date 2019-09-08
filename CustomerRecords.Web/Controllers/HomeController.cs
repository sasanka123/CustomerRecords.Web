#region Modification Log
/*------------------------------------------------------------------------------------------------------------------------------------------------- 
   System      -   Test
   Client      -   Test         
   Module      -   Home Controller
   Sub_Module  -   

   Copyright   -   Test Company

Modification History:
==================================================================================================================================================
Date              Version      Modify by              Description
--------------------------------------------------------------------------------------------------------------------------------------------------
19/07/2018         1.0        Sasanka   		  Initial Version
--------------------------------------------------------------------------------------------------------------------------------------------------*/
#endregion

using CustomerRecords.BLL;
using CustomerRecords.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerRecords.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerDataService customerDataService;

        public HomeController(ICustomerDataService customerDataService)
        {
            this.customerDataService = customerDataService;
        }

        #region LoadCustomerData
        public ActionResult Index()
        {
           
                //int ss = 10;
                //int yy = 0;
                //var t = ss / yy;
                return View();
           
        }

        [HttpGet]
        public ActionResult Customers()
        {
            List<Customer> custList = customerDataService.Get();
            Common common = new Common();
            common.Customers = custList;
            common.Countries = GetCountryList();
            ViewBag.SelectedCountryId = common.Countries[0].Id;

            var selectedCountryName = Convert.ToString(TempData["SelectedCountry"]);
            if (!String.IsNullOrEmpty(selectedCountryName))
            {
                ViewBag.Selected = selectedCountryName;
                common.Customers = custList.Where(c => c.Address == selectedCountryName).ToList();
                ViewBag.SelectedCountryId = common.Countries.Where(x => x.Name == selectedCountryName).FirstOrDefault().Id;
            }
            return View(common);
        }
        #endregion

        #region ViewCustomerData
        [HttpGet]
        public ActionResult Details(string id)
        {
            Customer customer = customerDataService.Get(Convert.ToInt32(id));
            return View(customer);
        }
        #endregion

        #region CreateCustomerData
        [HttpGet]
        public ActionResult Create(string id)
        {
            Customer customer = new Customer();
            if (!String.IsNullOrEmpty(id))
                customer = customerDataService.Get(Convert.ToInt32(id));
            return View(customer);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customerDataService.Add(customer);
                return RedirectToAction("Customers", "Home");
            }
            return View(customer);
        }
        #endregion

        #region DeleteCustomer
        [HttpPost]
        public ActionResult Delete(Customer customer)
        {
            customerDataService.Remove(customer);
            return RedirectToAction("Customers", "Home");
        }
        #endregion

        #region Data
        public ActionResult Data()
        {
            //ViewBag.Message = "Data";
            return View();
        }
        #endregion

        #region Chart Data
        public ActionResult GetChartData()
        {
            Population pop = new Population();
            pop.Male = 10000;
            pop.Female = 800;
            pop.Other = 200;
            return Json(pop, JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region DropdownData
        public List<Country> GetCountryList()
        {
            List<Country> countries = new List<Country>() {
            new Country { Name = "All", Id = 0},
            new Country {Name = "Sri Lanka", Id = 1},
            new Country {Name = "India", Id = 2},
            new Country {Name = "Singapore", Id = 3},
            new Country { Name = "NZ", Id = 4}};
            return countries;
        }

        
        public ActionResult FillterRecords(string countryName)
        {
            TempData["SelectedCountry"] = countryName;
            return RedirectToAction("Customers", "Home");
        }


        #endregion
    }
}