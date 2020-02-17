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

        public string InventoryItemList { get; set; }
    }
}
