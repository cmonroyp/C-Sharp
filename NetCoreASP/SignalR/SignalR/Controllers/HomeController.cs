using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalR.Hubs;
using SignalR.Models;

namespace SignalR.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHubContext<ChatHub> chatHub;
        //enviar mensajes a usuarios desde nuestra aplicacion 
        public HomeController(IHubContext<ChatHub> chatHub)
        {
            this.chatHub = chatHub;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            chatHub.Clients.All.SendAsync("ReceiveMessage", "Admin", "Alguien ha entrado a la pagina About");
            return View();
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
