using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models
{
    public class Monster
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Level { get; set; } = 1;

        public int Hp { get; set; } = 0;

        public int MinAttack { get; set; } = 0;

        public int MaxAttack { get; set; } = 0;

        public int Block { get; set; } = 0;

        public string Picture { get; set; }

        public string DropList { get; set; } = "0/0/0";

        //to be used as foreign key or maybe use items from utility or something ?
        //public int Drop1 { get; set; } = 0;
        //[ForeignKey("Drop1")]
        //public virtual ItemList ItemDrop1 { get; set; }

        //public int Drop2 { get; set; } = 0;
        //[ForeignKey("Drop2")]
        //public virtual ItemList ItemDrop2 { get; set; }

        //public int Drop3 { get; set; } = 0;
        //[ForeignKey("Drop3")]
        //public virtual ItemList ItemDrop3 { get; set; }

        public int Drop1Chance { get; set; } = 0;
        public int Drop2Chance { get; set; } = 0;
        public int Drop3Chance { get; set; } = 0;

        public int GoldPerKill { get; set; } = 0;
        public int Exp { get; set; } = 0;
    }
}
