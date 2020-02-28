using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aegis.Data;
using Microsoft.AspNetCore.Mvc;
using Aegis.Models;
using Aegis.Utility;
using Microsoft.EntityFrameworkCore;

namespace Aegis.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class InventoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public InventoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(int playerId)
        {
            var inventory = _db.Inventory.FirstOrDefault(i => i.Id == playerId);
            if (string.IsNullOrEmpty(inventory.InventoryItemList))
            {
                List<Item> ItemList1 = new List<Item>();
                return View(ItemList1);
            }
            else
            {
                if (inventory.InventoryItemList == "" || inventory.InventoryItemList == null)
                {
                    List<Item> list = new List<Item>();
                    return View(list);
                }

                string[] split = inventory.InventoryItemList.Split(',');
                var split2 = split.ToList();

                var itemListIds = split2.Select(s => Convert.ToInt32(s)).ToList();
                //ova greska se desava ako inventory ostane prazan... treba napraviti if statement ako je prazan da ga vrati na default postavku

                List<Item> ItemList = new List<Item>();


                foreach (var item in itemListIds)
                {
                    var newItem = _db.Item.FirstOrDefault(i => i.Id == item);
                    ItemList.Add(newItem);
                }

                return View(ItemList);
            }



        }

        //

        public async Task<IActionResult> EquipItem(int id)
        {
            var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");

            //Get item type
            var item = _db.Item.FirstOrDefault(i => i.Id == id);
            var itemType = item.ItemType;

            //Equip item
            var equipedItems = ssPlayerModel.EquipedItemsList;
            string[] split = equipedItems.Split('/');
            var split2 = split.ToList();

            //if some item is already equiped
            var check = Int32.Parse(split2[itemType]);

            split2[itemType] = id.ToString();

            var split3 = split2.ToArray();

            var result = string.Join("/", split3);
            ssPlayerModel.EquipedItemsList = result;
            _db.PlayerModel.Update(ssPlayerModel);
            await _db.SaveChangesAsync();


            //Delete from player inventory
            var inventory = _db.Inventory.FirstOrDefault(i => i.Id == ssPlayerModel.Id);
            var inventoryItemList = inventory.InventoryItemList;

            string[] splitForDelete = inventoryItemList.Split(',');
            var splitForDelete2 = splitForDelete.ToList();
            splitForDelete2.Remove(new string(item.Id.ToString()));

            //check if inventory is empty
            if (splitForDelete2.Count() < 1)
            {
                inventory.InventoryItemList = string.Empty;
                _db.Inventory.Update(inventory);
                _db.SaveChanges();
            }
            else
            {
                var splitForDelete3 = splitForDelete2.ToArray();

                var result2 = string.Join(",", splitForDelete3);
                inventoryItemList = result2;

                inventory.InventoryItemList = inventoryItemList;
                _db.Inventory.Update(inventory);
                _db.SaveChanges();
            }


            //Check if equiped part II
            if (check > 0)
            {
                var inventoryItemList2 = inventoryItemList;
                string[] splitForReplace = inventoryItemList2.Split(',');
                var splitForReplace2 = splitForReplace.ToList();

                //FIX TRY
                splitForReplace2.Add(new string(check.ToString()));
                //splitForReplace2[itemType] = check.ToString();

                var splitForReplace3 = splitForReplace2.ToArray();

                var result3 = string.Join(",", splitForReplace3);
                inventoryItemList2 = result3;

                inventory.InventoryItemList = inventoryItemList2;
                _db.Inventory.Update(inventory);
                _db.SaveChanges();
            }


            //Update player status (hp,attack etc...)
            ssPlayerModel = UpdatePlayerStatsOnEquip(ssPlayerModel, item);
            _db.PlayerModel.Update(ssPlayerModel);

            await _db.SaveChangesAsync();
            HttpContext.Session.SetObject("ssPlayerModel", ssPlayerModel);
            return RedirectToAction("Index", new { playerId = ssPlayerModel.Id });
        }


        public async Task<IActionResult> UnEquipItem(int id)
        {
            var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");

            //Get item type
            var item = _db.Item.FirstOrDefault(i => i.Id == id);
            var itemType = item.ItemType;

            //UnEquip item
            var equipedItems = ssPlayerModel.EquipedItemsList;
            string[] split = equipedItems.Split('/');
            var split2 = split.ToList();


            split2[itemType] = "0";

            var split3 = split2.ToArray();

            var result = string.Join("/", split3);
            ssPlayerModel.EquipedItemsList = result;
            _db.PlayerModel.Update(ssPlayerModel);
            await _db.SaveChangesAsync();


            //Add to player inventory
            var inventory = _db.Inventory.FirstOrDefault(i => i.Id == ssPlayerModel.Id);
            var inventoryItemList = inventory.InventoryItemList;

            if (string.IsNullOrEmpty(inventoryItemList))
            {
                inventory.InventoryItemList = item.Id.ToString();
            }
            else
            {
                string[] splitForDelete = inventoryItemList.Split(',');
                var splitForDelete2 = splitForDelete.ToList();

                splitForDelete2.Add(new string(item.Id.ToString()));
                var splitForDelete3 = splitForDelete2.ToArray();

                var result2 = string.Join(",", splitForDelete3);
                inventoryItemList = result2;

                inventory.InventoryItemList = inventoryItemList;
            }

            _db.Inventory.Update(inventory);
            _db.SaveChanges();

            ssPlayerModel = UpdatePlayerStatsOnUnEquip(ssPlayerModel, item);
            _db.PlayerModel.Update(ssPlayerModel);

            await _db.SaveChangesAsync();
            HttpContext.Session.SetObject("ssPlayerModel", ssPlayerModel);
            return RedirectToAction("Index", "PlayerProfile", new { id = ssPlayerModel.Id });
        }


        public async Task<IActionResult> DeleteItem(int id)
        {
            var ssPlayerModel = HttpContext.Session.GetObject<PlayerModel>("ssPlayerModel");

            var inventory = _db.Inventory.FirstOrDefault(i => i.Id == ssPlayerModel.Id);
            var inventoryItemList = inventory.InventoryItemList;

            string[] splitForDelete = inventoryItemList.Split(',');
            var splitForDelete2 = splitForDelete.ToList();
            splitForDelete2.Remove(new string(id.ToString()));

            //check if inventory is empty
            if (splitForDelete2.Count() < 1)
            {
                inventory.InventoryItemList = string.Empty;
                _db.Inventory.Update(inventory);
                await _db.SaveChangesAsync();

            }
            else
            {
                var splitForDelete3 = splitForDelete2.ToArray();

                var result2 = string.Join(",", splitForDelete3);
                inventoryItemList = result2;

                
                inventory.InventoryItemList = inventoryItemList;
                _db.Inventory.Update(inventory);
                await _db.SaveChangesAsync();

            }

            //Delete item from item database list
            Item itemForDelete = new Item();
            itemForDelete.Id = id;
            _db.Item.Remove(itemForDelete);

            await _db.SaveChangesAsync();
            _db.Entry(inventory).State = EntityState.Detached;

            return RedirectToAction("Index", new { playerId = ssPlayerModel.Id });

        }


        //Help methods***

        //Equip item status update
        public PlayerModel UpdatePlayerStatsOnEquip(PlayerModel player, Item item)
        {
            if (item.Attack > 0)
            {
                player.TotalAttack += item.Attack;
            }

            if (item.Deffense > 0)
            {
                player.TotalDeffense += item.Deffense;
            }

            if (item.Mana > 0)
            {
                player.TotalManaH += item.Mana;
            }

            if (item.Crit > 0)
            {
                player.TotalCrit += item.Crit;
            }

            if (item.Block > 0)
            {
                player.TotalBlock += item.Block;
            }

            if (item.Evasion > 0)
            {
                player.TotalEvasion += item.Evasion;
            }

            if (item.MaxMana > 0)
            {
                player.TotalMaxMana += item.MaxMana;
            }

            if (item.HealthPoints > 0)
            {
                player.TotalHp += item.HealthPoints;
            }

            if (item.GoldPerHour > 0)
            {
                player.TotalGoldH += item.GoldPerHour;
            }

            return player;
        }

        //UnEquip item status update
        public PlayerModel UpdatePlayerStatsOnUnEquip(PlayerModel player, Item item)
        {
            if (item.Attack > 0)
            {
                player.TotalAttack -= item.Attack;
            }

            if (item.Deffense > 0)
            {
                player.TotalDeffense -= item.Deffense;
            }

            if (item.Mana > 0)
            {
                player.TotalManaH -= item.Mana;
            }

            if (item.Crit > 0)
            {
                player.TotalCrit -= item.Crit;
            }

            if (item.Block > 0)
            {
                player.TotalBlock -= item.Block;
            }

            if (item.Evasion > 0)
            {
                player.TotalEvasion -= item.Evasion;
            }

            if (item.MaxMana > 0)
            {
                player.TotalMaxMana -= item.MaxMana;
            }

            if (item.HealthPoints > 0)
            {
                player.TotalHp -= item.HealthPoints;
            }

            if (item.GoldPerHour > 0)
            {
                player.TotalGoldH -= item.GoldPerHour;
            }

            return player;
        }
    }
}