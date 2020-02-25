using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        public int Count { get; set; }

        //added =null; 25.feb.20 as try to fix some bug with equip/unequip etc.
        public string InventoryItemList { get; set; } = string.Empty;
    }
}
