using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models
{
    public class ItemList
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        public int ItemType { get; set; }

        public int ItemClass { get; set; }

        public int Attack { get; set; } = 0;

        public int Deffense { get; set; } = 0;

        public int Gold { get; set; } = 0;

        public int Mana { get; set; } = 0;

        public int Crit { get; set; } = 0;

        public int Block { get; set; } = 0;

        public int Evasion { get; set; } = 0;

        public int GoldPerHour { get; set; } = 0;

        public int MaxMana { get; set; } = 0;

        public int HealthPoints { get; set; } = 0;

        public int LevelReq { get; set; } = 1;

        public string ClassRequirement { get; set; }
    }
}
