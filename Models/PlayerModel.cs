using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models
{
    public class PlayerModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nickname { get; set; }

        [Required]
        public string Class { get; set; }

        [Required]
        public string Email { get; set; }

        public int Level { get; set; } = 1;

        public int Experience { get; set; } = 1;

        public int Gold { get; set; } = 0;

        public int MobsK { get; set; } = 0;

        public int PlayerK { get; set; } = 0;

        public int PlayerD { get; set; } = 0;

        public string DateCreated { get; set; }

        //To be used as foreignKey
        public string GuildName { get; set; }

        public string GuildRank { get; set; }

        public int GuildId { get; set; } = 0;

        public string StatusMessage { get; set; } = "Status Message...";

        public string ProfilePicture { get; set; }

        //To be used as foreignKey
        public int InventoryId { get; set; }
        [ForeignKey("InventoryId")]
        public virtual Inventory Inventory { get; set; }

        //To be used as foreignKey
        public int BankId { get; set; }
        [ForeignKey("BankId")]
        public virtual Bank Bank { get; set; }

        public string EquipedItemsList { get; set; } = "0/0/0/0/0/0/0/0/0";

        ////To be used as foreignKey`s
        //public int WeaponId { get; set; } = 0;
        //[ForeignKey("WeaponId")]
        //public virtual Item Weapon { get; set; }

        //public int ArmorId { get; set; } = 0;
        //[ForeignKey("ArmorId")]
        //public virtual Item Armor { get; set; }

        //public int HelmId { get; set; } = 0;
        //[ForeignKey("HelmId")]
        //public virtual Item Helm { get; set; }

        //public int BootsId { get; set; } = 0;
        //[ForeignKey("BootsId")]
        //public virtual Item Boots { get; set; }

        //public int RingId { get; set; } = 0;
        //[ForeignKey("RingId")]
        //public virtual Item Ring { get; set; }

        //public int BeltId { get; set; } = 0;
        //[ForeignKey("BeltId")]
        //public virtual Item Belt { get; set; }

        //public int NeckId { get; set; } = 0;
        //[ForeignKey("NeckId")]
        //public virtual Item Neck { get; set; }

        //public int OffHandId { get; set; } = 0;
        //[ForeignKey("OffHandId")]
        //public virtual Item OffHand { get; set; }

        //public int PantsId { get; set; } = 0;
        //[ForeignKey("PantsId")]
        //public virtual Item Pants { get; set; }

        //

        public string QuestDone { get; set; }

        public string Skills { get; set; }

        //

        public int TotalHp { get; set; } = 100;
        public int TotalAttack { get; set; } = 10;
        public int TotalDeffense { get; set; } = 10;
        public int TotalCrit { get; set; } = 1;
        public int TotalBlock { get; set; } = 1;
        public int TotalGoldH { get; set; } = 1;
        public int TotalEvasion { get; set; } = 1;
        public int CurrentMana { get; set; } = 1000;
        public int TotalManaH { get; set; } = 10;
        public int TotalMaxMana { get; set; } = 1000;






    }
}
