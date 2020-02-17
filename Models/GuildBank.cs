using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models
{
    public class GuildBank
    {
        [Key]
        public int Id { get; set; }

        //To be used as F. key
        public int GuildId { get; set; }
        [ForeignKey("GuildId")]
        public virtual Guild Guild { get; set; }

        public int Count { get; set; }

        public string GuildBankItemList { get; set; }
    }
}
