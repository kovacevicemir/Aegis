using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aegis.Data;
using Aegis.Models;
using Aegis.Models.ViewModels;
using Aegis.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Aegis.Areas.Customer.Controllers
{

    [Area("Customer")]
    public class PlayerProfileController : Controller
    {
        private readonly ApplicationDbContext _db;

        

        public PlayerProfileController(ApplicationDbContext db)
        {
            _db = db;
        }

        //
        //[Authorize]
        //public async Task<IActionResult> Details(int id)
        //{
        //    var menuItemFromDb = await _db.MenuItem.Include(m => m.SubCategory).Include(m => m.Category).FirstOrDefaultAsync(m => m.Id == id);

        //    ShoppingCart cartObj = new ShoppingCart()
        //    {
        //        MenuItem = menuItemFromDb,
        //        MenuItemId = menuItemFromDb.Id
        //    };

        //    return View(cartObj);
        //}


        public async Task<IActionResult> Index(int id)
        {
            var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");

            var playerModel = await _db.PlayerModel.FirstOrDefaultAsync(u => u.Id == id);
            if (playerModel != null)
            {
                PlayerProfileViewModel playerProfileViewModel = new PlayerProfileViewModel();
                playerProfileViewModel.PlayerModel = playerModel;

                var EquipedItems = playerModel.EquipedItemsList;
                string[] split = EquipedItems.Split("/");
                var split2 = split.ToList();

                List<Item> EquipedItemList = new List<Item>();

                foreach(var item in split2)
                {
                    if(item == "0")
                    {
                        Item newItem = new Item();
                        EquipedItemList.Add(newItem);
                    }
                    else
                    {
                        EquipedItemList.Add(await _db.Item.FirstOrDefaultAsync(i => i.Id == Int32.Parse(item)));
                    }

                }

                playerProfileViewModel.EquipedItems = EquipedItemList;


                //var guildId = await _db.Guild.Where(g => g.Name == playerModel.GuildName).Select(g => g.Id).FirstOrDefaultAsync();
                //playerProfileViewModel.GuildId = guildId;

                var PlayerExpList = await _db.PlayerModel.OrderByDescending(m => m.Experience).ToListAsync();

                var rankingCount = 1;
                foreach(var item in PlayerExpList)
                {
                    if (item.Nickname == playerModel.Nickname)
                    {
                        break;
                    }
                    else
                    {
                        rankingCount++;
                    }
                }

                playerProfileViewModel.PlayerRank = rankingCount;

                PlayerExpList = PlayerExpList.OrderByDescending(g => g.Gold).ToList();
                var goldRankingCount = 1;
                foreach (var item in PlayerExpList)
                {
                    if (item.Nickname == playerModel.Nickname)
                    {
                        break;
                    }
                    else
                    {
                        goldRankingCount++;
                    }
                }

                var PlayerGuild = await _db.Guild.FirstOrDefaultAsync(g => g.Id == playerModel.GuildId);

                playerProfileViewModel.GoldRank = goldRankingCount;
                playerProfileViewModel.PlayerGuild = PlayerGuild;

                return View(playerProfileViewModel);
            }
            else
            {
                return Redirect("https://localhost:44337");
            }

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> StatusMessagePost(int id, [FromForm] string message)
        {
            var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");
            string NewStatusMessage = Request.Form["NewStatusMessage"];

            ssPlayerModel.StatusMessage = NewStatusMessage;
            _db.PlayerModel.Update(ssPlayerModel);

            await _db.SaveChangesAsync();

            return RedirectToAction("Index", new { id = id });
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AttackPlayer(int id)
        {
            var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");
            PlayerAttackModel playerAttackModel = new PlayerAttackModel();

            var Attacker = await _db.PlayerModel.FirstOrDefaultAsync(u => u.Id == ssPlayerModel.Id);
            var Deffender = await _db.PlayerModel.FirstOrDefaultAsync(u => u.Id == id);

            List<int> AttackerAttacks = new List<int>();
            List<int> DeffenderAttacks = new List<int>();

            List<int> AttackerDeffs = new List<int>();
            List<int> DeffenderDeffs = new List<int>();

            List<int> AttackerCurrentHpLog = new List<int>();
            AttackerCurrentHpLog.Add(Attacker.TotalHp);

            List<int> DeffenderCurrentHpLog = new List<int>();
            DeffenderCurrentHpLog.Add(Deffender.TotalHp);

            int AttackerCurrentAtt = 1;
            int DeffenderCurrentAtt = 1;

            int AttackerCurrentHp = Attacker.TotalHp;
            int DeffenderCurrentHp = Deffender.TotalHp;

            int AttackerCrit = Attacker.TotalCrit;
            int DeffenderCrit = Deffender.TotalCrit;

            int AttackerEvasion = Attacker.TotalEvasion;
            int DeffenderEvasion = Deffender.TotalEvasion;

            int AttackerBlock = Attacker.TotalBlock;
            int DeffenderBlock = Deffender.TotalBlock;

            while (AttackerCurrentHp > 0 && DeffenderCurrentHp > 0)
            {
                //Step1
                Random rnd = new Random();

                int AttackVariationAttacker = rnd.Next(1, 12);
                AttackerCurrentAtt = Attacker.TotalAttack + (int)Math.Ceiling((double)Attacker.TotalAttack * ((double)AttackVariationAttacker /100));

                int RandomIntforBlock = rnd.Next(1, 100);
                if (RandomIntforBlock < DeffenderBlock + 25)
                {
                    AttackerCurrentAtt = 0;
                }

                int RandomIntforEva = rnd.Next(1, 100);
                if (RandomIntforEva < DeffenderEvasion + 25)
                {
                    AttackerCurrentAtt = -1;
                }
                else
                {
                    int RandomIntforCrit = rnd.Next(1, 100);
                    if (RandomIntforCrit < AttackerCrit + 50)
                    {
                        AttackerCurrentAtt -= (AttackerCurrentAtt * 3);
                    }

                    //

                    if (AttackerCurrentAtt == -1)
                    {
                        DeffenderCurrentHp = DeffenderCurrentHp + 0;
                    }
                    else
                    {
                        if (AttackerCurrentAtt < 0)
                        {
                            DeffenderCurrentHp += AttackerCurrentAtt;
                        }
                        else
                        {
                            DeffenderCurrentHp -= AttackerCurrentAtt;
                        }
                    }
                }


                //logs
                AttackerAttacks.Add(AttackerCurrentAtt);
                DeffenderCurrentHpLog.Add(DeffenderCurrentHp);

                //Step2

                Random rnd1 = new Random();

                int DeffenderVariationAttacker = rnd1.Next(1, 12);
                DeffenderCurrentAtt = Deffender.TotalAttack + (int)Math.Ceiling((double)Deffender.TotalAttack * ((double)DeffenderVariationAttacker / 100));

                int RandomIntforBlock1 = rnd1.Next(1, 100);
                if (RandomIntforBlock1 < AttackerBlock + 25)
                {
                    DeffenderCurrentAtt = 0;
                }

                int RandomIntforEva1 = rnd.Next(1, 100);
                if (RandomIntforEva1 < AttackerEvasion + 25)
                {
                    DeffenderCurrentAtt = -1;
                }
                else
                {
                    int RandomIntforCrit1 = rnd1.Next(1, 100);
                    if (RandomIntforCrit1 < DeffenderCrit + 50)
                    {
                        DeffenderCurrentAtt -= (DeffenderCurrentAtt * 3);
                    }



                    //
                    if (DeffenderCurrentAtt == -1)
                    {
                        AttackerCurrentHp = AttackerCurrentHp + 0;
                    }
                    else
                    {
                        if (DeffenderCurrentAtt < 0)
                        {
                            AttackerCurrentHp += DeffenderCurrentAtt;
                        }
                        else
                        {
                            AttackerCurrentHp -= DeffenderCurrentAtt;
                        }
                    }
                }

                

                //logs
                DeffenderAttacks.Add(DeffenderCurrentAtt);
                AttackerCurrentHpLog.Add(AttackerCurrentHp);
            }

            List<PlayerModel> test = new List<PlayerModel>();
            test.Add(Attacker);
            test.Add(Deffender);

            playerAttackModel.AttackerAndDeffenderModels = test;

            //playerAttackModel.AttackerAndDeffenderModels.Add(Deffender);
            //playerAttackModel.AttackerAndDeffenderModels.Add(Attacker);

            playerAttackModel.AttackerAttacks = AttackerAttacks;
            playerAttackModel.DeffenderAttacks = DeffenderAttacks;

            playerAttackModel.AttackerCurrentHpLog = AttackerCurrentHpLog;
            playerAttackModel.DeffenderCurrentHpLog = DeffenderCurrentHpLog;

            playerAttackModel.AttackerDeffs = AttackerDeffs;
            playerAttackModel.DeffenderDeffs = DeffenderDeffs;

            return View(playerAttackModel);
        }

        [HttpPost]
        [ActionName("AddExpToPlayer")]
        public int AddExpToPlayer(int exp)
        //And Monster kill count! add
        {
            var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");
            ssPlayerModel.MobsK++;
            ssPlayerModel.Experience = ssPlayerModel.Experience + exp;

            _db.PlayerModel.Update(ssPlayerModel);
            _db.SaveChangesAsync();

            //update session
            HttpContext.Session.SetObject("ssPlayerModel", ssPlayerModel);
            return (exp);
        }

        [HttpPost]
        [ActionName("AddGoldToPlayer")]
        public int AddGoldToPlayer(int gold)
        {
            var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");
            ssPlayerModel.Gold = ssPlayerModel.Gold + gold;

            _db.PlayerModel.Update(ssPlayerModel);
            _db.SaveChangesAsync();

            //update session
            HttpContext.Session.SetObject("ssPlayerModel", ssPlayerModel);

            return (gold);
        }

        //NOT WORKING WTF ? //PROBABLY AJAX CALL DATA
        [HttpPost]
        public async Task<IActionResult> AwardPlayerOnKill(int gold, int exp, int mana)
        {
            var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");
            ssPlayerModel.Gold = ssPlayerModel.Gold + gold;
            ssPlayerModel.MobsK++;
            ssPlayerModel.Experience = ssPlayerModel.Experience + exp;
            ssPlayerModel.CurrentMana = ssPlayerModel.CurrentMana - mana;

            _db.PlayerModel.Update(ssPlayerModel);
            await _db.SaveChangesAsync();

            //update session
            HttpContext.Session.SetObject("ssPlayerModel", ssPlayerModel);
            return StatusCode(200);
        }


    }
}