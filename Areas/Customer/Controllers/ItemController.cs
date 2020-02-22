using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aegis.Data;
using Aegis.Models;
using Aegis.Models.ViewModels;
using Aegis.Utility;
using Microsoft.AspNetCore.Mvc;

namespace Aegis.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateItem(ItemViewModel itemViewModel)
        {
            if (itemViewModel.ItemList != null)
            {
                _db.ItemList.Add(itemViewModel.ItemList);
                await _db.SaveChangesAsync();

                return RedirectToAction("Index");
            }

            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> AddItemToPlayer(ItemViewModel itemViewModel)
        {
            var itemFromList = _db.ItemList.FirstOrDefault(i => i.Id == itemViewModel.ItemId);
            Item item = new Item();

            item.Name = itemFromList.Name;
            item.Description = itemFromList.Description;
            item.Attack = itemFromList.Attack;
            item.Deffense = itemFromList.Deffense;
            item.Mana = itemFromList.Mana;
            item.MaxMana = itemFromList.MaxMana;
            item.HealthPoints = itemFromList.HealthPoints;
            item.Gold = itemFromList.Gold;
            item.GoldPerHour = itemFromList.GoldPerHour;
            item.ItemType = itemFromList.ItemType;
            item.ClassRequirement = itemFromList.ClassRequirement;
            item.ItemClass = itemFromList.ItemClass;
            item.LevelReq = itemFromList.LevelReq;
            item.Picture = itemFromList.Picture;
            item.Block = itemFromList.Block;
            item.Evasion = itemFromList.Evasion;
            item.PlayerId = itemViewModel.PlayerId;

            _db.Item.Add(item);

            var inventory = _db.Inventory.FirstOrDefault(i => i.Id == itemViewModel.PlayerId);
            string inventoryItemList = inventory.InventoryItemList;
            if (inventoryItemList == null)
            {
                int newItemId = _db.Item.OrderByDescending(u => u.Id).Select(i => i.Id).FirstOrDefault();
                newItemId = newItemId + 1;
                inventoryItemList = newItemId.ToString();
            }
            else
            {
                int newItemId = _db.Item.OrderByDescending(u => u.Id).Select(i => i.Id).FirstOrDefault();
                newItemId = newItemId + 1;

                string[] split = inventoryItemList.Split(',');
                var split2 = split.ToList();

                split2.Add(newItemId.ToString());
                var split3 = split2.ToArray();

                var result = string.Join(",", split3);
                inventoryItemList = result;


            }

            inventory.InventoryItemList = inventoryItemList;

            _db.Inventory.Update(inventory);

            _db.SaveChangesAsync();

            return RedirectToAction("Index");


        }


        [HttpPost]
        public async Task<IActionResult> DropItemToPlayer(int itemid)
        {
            var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");
            var itemViewModel = new ItemViewModel();
            itemViewModel.ItemId = itemid;
            itemViewModel.PlayerId = ssPlayerModel.Id;

            var itemFromList = _db.ItemList.FirstOrDefault(i => i.Id == itemViewModel.ItemId);
            Item item = new Item();

            item.Name = itemFromList.Name;
            item.Description = itemFromList.Description;
            item.Attack = itemFromList.Attack;
            item.Deffense = itemFromList.Deffense;
            item.Mana = itemFromList.Mana;
            item.MaxMana = itemFromList.MaxMana;
            item.HealthPoints = itemFromList.HealthPoints;
            item.Gold = itemFromList.Gold;
            item.GoldPerHour = itemFromList.GoldPerHour;
            item.ItemType = itemFromList.ItemType;
            item.ClassRequirement = itemFromList.ClassRequirement;
            item.ItemClass = itemFromList.ItemClass;
            item.LevelReq = itemFromList.LevelReq;
            item.Picture = itemFromList.Picture;
            item.Block = itemFromList.Block;
            item.Evasion = itemFromList.Evasion;
            item.PlayerId = itemViewModel.PlayerId;

            _db.Item.Add(item);

            var inventory = _db.Inventory.FirstOrDefault(i => i.Id == itemViewModel.PlayerId);
            string inventoryItemList = inventory.InventoryItemList;
            if (inventoryItemList == null)
            {
                int newItemId = _db.Item.OrderByDescending(u => u.Id).Select(i => i.Id).FirstOrDefault();
                newItemId = newItemId + 1;
                inventoryItemList = newItemId.ToString();
            }
            else
            {
                int newItemId = _db.Item.OrderByDescending(u => u.Id).Select(i => i.Id).FirstOrDefault();
                newItemId = newItemId + 1;

                string[] split = inventoryItemList.Split(',');
                var split2 = split.ToList();

                split2.Add(newItemId.ToString());
                var split3 = split2.ToArray();

                var result = string.Join(",", split3);
                inventoryItemList = result;


            }

            inventory.InventoryItemList = inventoryItemList;

            _db.Inventory.Update(inventory);

            await _db.SaveChangesAsync();

            return Content(item.Name);

        }


    }
}