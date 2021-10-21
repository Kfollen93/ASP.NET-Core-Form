using System;
using System.Diagnostics;
using FormTemplateProject.Data;
using FormTemplateProject.Models;
using FormTemplateProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FormTemplateProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            var vm = new FormSubmissionMessageVM();
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(FormSubmissionMessageVM form)
        {
            var myVm = new FormSubmissionMessageVM();
            myVm.Status = false;

            if (ModelState.IsValid)
            {
                try
                {
                    var registeredUser = new RegisteredUser
                    {
                        Name = form.RegisteredUser.Name,
                        EmailAddress = form.RegisteredUser.EmailAddress,
                        PhoneNumber = form.RegisteredUser.PhoneNumber,
                        Industry = form.RegisteredUser.Industry
                    };

                    _db.RegisteredUsers.Add(registeredUser);
                    _db.SaveChanges();
                    myVm.RegisteredUser = new RegisteredUser();
                    myVm.Status = true;
                    myVm.FormMessage = "The form has been submitted successfully. Thank you.";
                }
                catch (Exception)
                {
                    myVm.FormMessage = "An error has occurred while submitting the form. Please try again.";
                }
            }

            return View(myVm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
