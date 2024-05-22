
using BizLand_Business.Services.Abstracts;
using BizLand_Core.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BizLand.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITeamService _teamService;

        public HomeController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            List<Team> teams = _teamService.GetAllTeams();
            return View(teams);
        }

    }
}
