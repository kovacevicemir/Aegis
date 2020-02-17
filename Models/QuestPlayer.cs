using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models
{
    public class QuestPlayer
    {
        [Key]
        public int Id { get; set; }

        //F. key
        public int PlayerId { get; set; }
        [ForeignKey("PlayerId")]
        public virtual PlayerModel Player { get; set; }

        //F. Key
        public int QuestId { get; set; }
        [ForeignKey("QuestId")]
        public virtual Quest Quest { get; set; }

        //To keep track how many mobs been killed by player so far
        public int Count1 { get; set; }
        public int Count2 { get; set; }
        public int Count3 { get; set; }
        public int Count4 { get; set; }
        public int Count5 { get; set; }

    }
}
