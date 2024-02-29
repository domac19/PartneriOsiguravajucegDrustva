using Dapper;
using PartneriOsiguravajućegDruštva.Models;
using PartneriOsiguravajućegDruštva.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartneriOsiguravajućegDruštva.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["PartneriOsiguravajucegDrustva"].ConnectionString;

            using (var connection = new SqlConnection(connectionString))
            {
                // Your Dapper or other database code here
                connection.Open();

                // Example query using Dapper
                var result = connection.Query<Partner>("SELECT * FROM Partner");

                var userViewModel = result.Select(user => new PartnerViewModel
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Address = user.Address,
                    PartnerNumber = user.PartnerNumber,
                    CroatianPIN = user.CroatianPIN,
                    CreateByUser = user.CreateByUser,
                    CreatedAtUtc = user.CreatedAtUtc,
                    BrojPolice = user.BrojPolice,
                    IznosPolice = user.IznosPolice,
                    ExternalCode = user.ExternalCode,
                    Gender = user.Gender,
                    IsForeign = user.IsForeign
                });

                return View(userViewModel.ToList());
            }  
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}