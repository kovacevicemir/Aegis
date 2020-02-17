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
    public class GuildController : Controller
    {
        private readonly ApplicationDbContext _db;

        public GuildController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index(int id)
        {
            if (id != 0)
            {
                var GuildViewModel = new GuildViewModel();

                var playerGuild = await _db.Guild.FirstOrDefaultAsync(g => g.Id == id);
                GuildViewModel.Guild = playerGuild;

                var playerList = _db.PlayerModel.Where(p => p.GuildName == playerGuild.Name).ToList();
                GuildViewModel.MemberList = playerList;

                return View(GuildViewModel);
            }
            else
            {
                var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");
                var playerModel = await _db.PlayerModel.FirstOrDefaultAsync(u => u.Id == ssPlayerModel.Id);

                if (playerModel.GuildName == null || playerModel.GuildName == "")
                {
                    var GuildViewModel = new GuildViewModel();
                    return View(GuildViewModel);
                }
                else
                {
                    var GuildViewModel = new GuildViewModel();

                    var playerGuild = await _db.Guild.FirstOrDefaultAsync(g => g.Name == ssPlayerModel.GuildName);
                    GuildViewModel.Guild = playerGuild;

                    var playerList = _db.PlayerModel.Where(p => p.GuildName == playerGuild.Name).ToList();
                    GuildViewModel.MemberList = playerList;

                    return View(GuildViewModel);
                }
            }

        }

        //public async Task<IActionResult> Index()
        //{
        //    var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");
        //    var playerModel = await _db.PlayerModel.FirstOrDefaultAsync(u => u.Id == ssPlayerModel.Id);

        //    if (playerModel.GuildName == null)
        //    {
        //        return View();
        //    }
        //    else
        //    {
        //        var playerGuild = await _db.Guild.FirstOrDefaultAsync(g => g.Name == ssPlayerModel.GuildName);
        //        return View(playerGuild);
        //    }

        //}

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> CreateGuild(Guild guild)
        {

            if (ModelState.IsValid)
            {
                var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");

                //Create new guild
                Guild NewGuild = new Guild();
                NewGuild = guild;
                NewGuild.Leader = ssPlayerModel.Nickname;
                NewGuild.PlayerList = ssPlayerModel.Nickname;

                var guildnammecheck = await _db.Guild.FirstOrDefaultAsync(u => u.Name == NewGuild.Name);

                if(guildnammecheck == null)
                {
                    _db.Guild.Add(NewGuild);

                    //Create Bank for new guild
                    GuildBank NewGuildBank = new GuildBank();
                    NewGuildBank.GuildId = NewGuild.Id;
                    _db.GuildBank.Add(NewGuildBank);

                    //Change player GuildName
                    ssPlayerModel.GuildName = NewGuild.Name;
                    ssPlayerModel.GuildRank = "Leader";
                    _db.PlayerModel.Update(ssPlayerModel);

                }
                else
                {
                    return RedirectToAction("Index");
                }

                await _db.SaveChangesAsync();
            }

            return RedirectToAction("Index");

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> InviteToGuild([FromForm] string nickname)
        {

            var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");
            var guild = await _db.Guild.FirstOrDefaultAsync(g => g.Name == ssPlayerModel.GuildName);
            var InvitationListString = guild.InvitationList;

            string playerNickname = Request.Form["invitePlayerToGuild"];
            var playerId = await _db.PlayerModel.Where(p => p.Nickname == playerNickname).Select(k => k.Id).FirstOrDefaultAsync();
            if (playerId == 0)
            {
                return RedirectToAction("Index");
            }

            if (InvitationListString == "")
            {
                InvitationListString = playerNickname;
            }
            else
            {
                var invitationList = InvitationListString.Split(',').ToList();
                invitationList.Append(playerNickname);

                InvitationListString = string.Join(",", invitationList);
            }


            
            guild.InvitationList = InvitationListString;

            _db.Guild.Update(guild);

            Notification notification = new Notification();
            notification.IntValue1 = guild.Id;

            

            notification.IntValue2 = playerId;

            notification.Type = SD.GuildInvite;
            notification.Description = guild.Name + " has sent you an invitation !";
            _db.Notification.Add(notification);

            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AcceptGuildInvite(string guildname)
        {

            var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");
            var guild = await _db.Guild.FirstOrDefaultAsync(g => g.Name == guildname);

            if(guild == null)
            {
                return NotFound();
            }

            ssPlayerModel.GuildName = guildname;
            ssPlayerModel.GuildRank = guild.rank4;
            ssPlayerModel.GuildId = guild.Id;

            var InvitationListString = guild.InvitationList;
            var invitationList = InvitationListString.Split(',').ToList();
            invitationList.Remove(ssPlayerModel.Nickname);
            InvitationListString = string.Join(",", invitationList);

            guild.InvitationList = InvitationListString;

            var playerListString = guild.PlayerList;
            var playerList = playerListString.Split(',').ToList();
            playerList.Add(ssPlayerModel.Nickname);
            playerListString = string.Join(",", playerList);

            guild.PlayerList = playerListString;

            _db.Guild.Update(guild);

            ssPlayerModel.GuildId = guild.Id;
            ssPlayerModel.GuildName = guild.Name;
            ssPlayerModel.GuildRank = guild.rank4;

            _db.PlayerModel.Update(ssPlayerModel);
            //Need to update session as well...
            //Need to update session as well...
            //Need to update session as well...
            //Need to update session as well...
            //THIS IS NOT RIGHT WAY TO UPDATE SESSION I THINK

            await _db.SaveChangesAsync();

            return RedirectToAction("Index", guild.Id);

        }


        [HttpPost]
        [ActionName("LeaveGuild")]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> LeaveGuild(string guildname)
        {

            var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");
            var guild = await _db.Guild.FirstOrDefaultAsync(g => g.Name == guildname);

            if (guild == null)
            {
                return NotFound();
            }
            

            var guildMembersString = guild.PlayerList;
            var guildMembers = guildMembersString.Split(',').ToList();
            guildMembers.Remove(ssPlayerModel.Nickname);
            guildMembersString = string.Join(",", guildMembers);

            guild.PlayerList = guildMembersString;

            _db.Guild.Update(guild);

            ssPlayerModel.GuildRank = "";
            ssPlayerModel.GuildName = "";
            ssPlayerModel.GuildId = 0;

            _db.PlayerModel.Update(ssPlayerModel);
            //Need to update session as well...
            //Need to update session as well...
            //Need to update session as well...
            //Need to update session as well...
            //Need to update session as well...
            //THIS IS NOT RIGHT WAY TO UPDATE SESSION I THINK

            await _db.SaveChangesAsync();

            return RedirectToAction("Index", guild.Id);

        }


    }
}