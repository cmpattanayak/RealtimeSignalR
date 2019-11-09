using Microsoft.AspNet.SignalR.Client;
using SignalrClient.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SignalrClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(Employee employee)
        {
            DataContext context = new DataContext();
            context.Employees.Add(employee);
            context.SaveChanges();

            await InvokeSignalrHub();
            return View();
        }

        public ActionResult GetEmployeeList()
        {
            DataContext context = new DataContext();
            return PartialView("_EmployeeList", context.Employees.ToList());
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

        public async Task InvokeSignalrHub()
        {
            var connection = new HubConnection("http://localhost:8080/");
            IHubProxy myHub = connection.CreateHubProxy("BroadcastHub");
 
            await connection.Start();
            await myHub.Invoke("Broadcast");
        }
    }
}