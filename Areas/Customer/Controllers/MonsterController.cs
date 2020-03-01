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
    public class MonsterController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MonsterController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            MonsterAndRoomViewModel monsterAndRoomModel = new MonsterAndRoomViewModel();

            return View(monsterAndRoomModel);
        }

        public async Task<IActionResult> CreateMonster(MonsterAndRoomViewModel monsterAndRoomViewModel)
        {
            if (monsterAndRoomViewModel == null)
            {
                return NotFound();
            }

            var monster = monsterAndRoomViewModel.Monster;

            _db.Monster.Add(monster);

            await _db.SaveChangesAsync();

            MonsterAndRoomViewModel monsterAndRoomModel1 = new MonsterAndRoomViewModel();
            return View("Index", monsterAndRoomModel1);
        }

        public async Task<IActionResult> CreateRoom(MonsterAndRoomViewModel monsterAndRoomViewModel)
        {
            if (monsterAndRoomViewModel == null)
            {
                return NotFound();
            }

            var room = monsterAndRoomViewModel.Room;

            _db.Room.Add(room);

            await _db.SaveChangesAsync();

            MonsterAndRoomViewModel monsterAndRoomViewModel1 = new MonsterAndRoomViewModel();
            return View("Index", monsterAndRoomViewModel1);
        }

        [HttpGet]
        public MonsterAndRoomForWorldMapVM GetRoom(int id)
        {

            var room = _db.Room.FirstOrDefault(r => r.Id == id);

            var monsterListString = room.MonsterList;

            var monsterIdList = monsterListString.Split('/').ToList();

            List<Monster> monsterList = new List<Monster>();

            foreach (var item in monsterIdList)
            {
                if (Int32.Parse(item) != 0)
                {
                    monsterList.Add(_db.Monster.FirstOrDefault(m => m.Id == Int32.Parse(item)));
                }
            }

            MonsterAndRoomForWorldMapVM monsterAndRoomForWorldMapVM = new MonsterAndRoomForWorldMapVM();

            monsterAndRoomForWorldMapVM.Room = room;
            monsterAndRoomForWorldMapVM.MonsterList = monsterList;

            return (monsterAndRoomForWorldMapVM);
        }

        [HttpGet]
        public MonsterAttackModel AttackMonster(int roomid, int mobid)
        {
            var tempId = roomid;

            if(roomid < 0)
            {
                tempId = roomid * -1;
            }
            

            var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");
            var Attacker = _db.PlayerModel.FirstOrDefault(u => u.Id == ssPlayerModel.Id);
            var room = _db.Room.FirstOrDefault(r => r.Id == tempId);

            var monsterListString = room.MonsterList;
            var monsterIdList = monsterListString.Split('/').ToList();
            List<Monster> monsterList = new List<Monster>();

            foreach (var item in monsterIdList)
            {
                if (Int32.Parse(item) != 0)
                {
                    monsterList.Add(_db.Monster.FirstOrDefault(m => m.Id == Int32.Parse(item)));
                }
            }

            MonsterAttackModel monsterAttackModel = new MonsterAttackModel();
            List<int> PlayerAttacks = new List<int>();
            List<int> MonsterAttacks = new List<int>();
            List<int> PlayerHpLog = new List<int>();
            List<int> MonsterHpLog = new List<int>();

            PlayerHpLog.Add(Attacker.TotalHp);


            //SINGLE ATTACK
            if (roomid > 0)
            {

                //Const`s:
                //var Mob = monsterList[mobid];
                var Mob = _db.Monster.FirstOrDefault(m => m.Id == mobid);
                MonsterHpLog.Add(Mob.Hp);

                int PlayerCurrentAtt = 1;
                int MobCurrentAtt = 1;

                int PlayerCurrentHp = Attacker.TotalHp;
                int PlayerCrit = Attacker.TotalCrit;
                int PlayerEvasion = Attacker.TotalEvasion;
                int PlayerBlock = Attacker.TotalBlock;

                int MobCurrentHp = Mob.Hp;
                int MobMaxAtt = Mob.MaxAttack;
                int MobMinAtt = Mob.MinAttack;
                int MobBlock = Mob.Block;

                //Logic
                while (PlayerCurrentHp > 0 && MobCurrentHp > 0)
                {
                    //Step1
                    Random rnd = new Random();

                    int AttackVariationAttacker = rnd.Next(1, 12);
                    PlayerCurrentAtt = Attacker.TotalAttack + (int)Math.Ceiling((double)Attacker.TotalAttack * ((double)AttackVariationAttacker / 100));

                    int RandomIntforBlock = rnd.Next(1, 100);
                    if (RandomIntforBlock < MobBlock + 25)
                    {
                        PlayerCurrentAtt = 0;
                    }

                    
                    int RandomIntforCrit = rnd.Next(1, 100);
                    if (RandomIntforCrit < PlayerCrit + 50)
                    {
                        PlayerCurrentAtt -= (PlayerCurrentAtt * 3);
                    }

                    //

                    if (PlayerCurrentAtt == -1)
                    {
                        MobCurrentHp = MobCurrentHp + 0;
                    }
                    else
                    {
                        if (PlayerCurrentAtt < 0)
                        {
                            MobCurrentHp += PlayerCurrentAtt;
                        }
                        else
                        {
                            MobCurrentHp -= PlayerCurrentAtt;
                        }
                    }


                    //logs
                    PlayerAttacks.Add(PlayerCurrentAtt);
                    MonsterHpLog.Add(MobCurrentHp);



                    //Step2

                    Random rnd1 = new Random();

                    int DeffenderVariationAttacker = rnd1.Next(1, 12);
                    MobCurrentAtt = Mob.MaxAttack + (int)Math.Ceiling((double)Mob.MaxAttack * ((double)DeffenderVariationAttacker / 100));

                    int RandomIntforBlock1 = rnd1.Next(1, 100);
                    if (RandomIntforBlock1 < PlayerBlock + 25)
                    {
                        MobCurrentAtt = 0;
                    }

                    int RandomIntforEva1 = rnd.Next(1, 100);
                    if (RandomIntforEva1 < PlayerEvasion + 25)
                    {
                        MobCurrentAtt = -1;
                    }
                    else
                    {


                        //
                        if (MobCurrentAtt == -1)
                        {
                            PlayerCurrentHp = PlayerCurrentHp + 0;
                        }
                        else
                        {
                            if (MobCurrentAtt < 0)
                            {
                                PlayerCurrentHp += MobCurrentAtt;
                            }
                            else
                            {
                                PlayerCurrentHp -= MobCurrentAtt;
                            }
                        }
                    }



                    //logs
                    MonsterAttacks.Add(MobCurrentAtt);
                    PlayerHpLog.Add(PlayerCurrentHp);


                }

                monsterAttackModel.MonsterAttacks = MonsterAttacks;
                monsterAttackModel.PlayerAttacks = PlayerAttacks;

                monsterAttackModel.MonsterCurrentHpLog = MonsterHpLog;
                monsterAttackModel.PlayerCurrentHpLog = PlayerHpLog;

                return(monsterAttackModel);

            }


            //AOE ATTACK
            else
            {
                return (monsterAttackModel);
            }


        }

    }

    
}