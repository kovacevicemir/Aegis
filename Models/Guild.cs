using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models
{
    public class Guild
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Leader { get; set; }

        public string Picture { get; set; }

        public string PlayerList { get; set; }

        public string InvitationList { get; set; }

        [Range(1, 20)]
        public int GuildTax { get; set; }

        public int GuildAttackAdd { get; set; }

        public int GuildDeffenseAdd { get; set; }

        public int AttackMultiplier { get; set; }

        public int DeffenseMultiplier { get; set; }

        public int GuildGold { get; set; }

        public string RaidMembersList { get; set; }

        //F. Key
        public string GuildBankId { get; set; }

        public string rank1 { get; set; }
        public string rank2 { get; set; }
        public string rank3 { get; set; }
        public string rank4 { get; set; }

    }
}
