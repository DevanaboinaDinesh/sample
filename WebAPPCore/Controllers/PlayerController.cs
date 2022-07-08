using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPPCore.Models;

namespace WebAPPCore.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            List<Player> lstPlayers=new List<Player>
            {
                new Player { PId = 1, PName = "MSD", PAvg = 56, PTeam = "CSK" },
                new Player { PId = 2, PName = "VK", PAvg = 76, PTeam = "RCB" },

                new Player { PId = 3, PName = "RS", PAvg = 86, PTeam = "MI" },
            };

           
            return View();
            
        }
    }
}
