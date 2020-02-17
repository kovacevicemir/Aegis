using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aegis.Models;
using Aegis.Models.ViewModels;
using Aegis.Data;
using Microsoft.EntityFrameworkCore;
using Aegis.Utility;
using Newtonsoft.Json;

namespace Aegis.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;


        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public List<Notification> GetNotification(int id)
        {
            if(id == 0)
            {
                RedirectToAction("Index");
            }

            var UserNotifications = _db.Notification.Where(n => n.IntValue2 == id).ToList();
            return UserNotifications;
        }

        public async Task<IActionResult> Index()
        {

            HomeViewModel HomeViewModel = new HomeViewModel();

            List<GlobalChat> globalChatMessageList = await _db.GlobalChat.OrderByDescending(m => m.Id).Include(u =>u.Player).Take(10).ToListAsync();
            List<PlayerModel> knightRanking = await _db.PlayerModel.Where(p => p.Class == SD.Knight).OrderByDescending(m=>m.Experience).Take(10).ToListAsync();
            List<PlayerModel> archerRanking = await _db.PlayerModel.Where(p => p.Class == SD.Archer).OrderByDescending(m => m.Experience).Take(10).ToListAsync();
            List<PlayerModel> mageRanking = await _db.PlayerModel.Where(p => p.Class == SD.Mage).OrderByDescending(m => m.Experience).Take(10).ToListAsync();
            List<PlayerModel> powerRanking = await _db.PlayerModel.OrderByDescending(m => m.TotalAttack).Take(10).ToListAsync();
            List<PlayerModel> goldRanking = await _db.PlayerModel.OrderByDescending(m => m.Gold).Take(10).ToListAsync();
            List<Guild> guildRanking = await _db.Guild.OrderByDescending(p => p.GuildGold).Take(10).ToListAsync();

            HomeViewModel.GlobalChatMessageList = globalChatMessageList;
            HomeViewModel.KnightRanking = knightRanking;
            HomeViewModel.ArcherRanking = archerRanking;
            HomeViewModel.MageRanking = mageRanking;
            HomeViewModel.PowerRanking = powerRanking;
            HomeViewModel.GoldRanking = goldRanking;
            HomeViewModel.CrewRanking = guildRanking;

            return View(HomeViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GlobalMessagePost(int id, [FromForm] string message)
        {
            GlobalChat NewMessage = new GlobalChat();

            NewMessage.PlayerId = id;
            NewMessage.Message = Request.Form["NewGlobalMessage"];


            await _db.GlobalChat.AddAsync(NewMessage);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Top100(string str)
        {
            if(str == null)
            {
                return NotFound();
            }
            else
            {
                Top100ViewModel top100ViewModel = new Top100ViewModel();

                List<PlayerModel> playerRanking = new List<PlayerModel>();
                List<Guild> guildRanking = new List<Guild>();

                if (str == "Knight" || str == "Archer" || str == "Mage")
                {
                    playerRanking = await _db.PlayerModel.Where(p => p.Class == str).OrderByDescending(m => m.Experience).Take(100).ToListAsync();
                }

                if(str == "Power")
                {
                    playerRanking = await _db.PlayerModel.OrderByDescending(m => m.TotalAttack).Take(100).ToListAsync();
                }

                if (str == "Gold")
                {
                    playerRanking = await _db.PlayerModel.OrderByDescending(m => m.Gold).Take(100).ToListAsync();
                }

                if(str == "Guild")
                {
                    guildRanking = await _db.Guild.OrderByDescending(p => p.GuildGold).Take(100).ToListAsync();
                }

                top100ViewModel.CrewRanking = guildRanking;
                top100ViewModel.PlayerRanking = playerRanking;
                top100ViewModel.RankBy = str;

                return View(top100ViewModel);
            }
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
