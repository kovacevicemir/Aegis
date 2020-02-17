using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        public string Location { get; set; }

        public string MonsterList { get; set; } = "0/0/0";

        //How many monsters count
        public string MonsterCount { get; set; } = "0/0/0";

        public string RespawnTime { get; set; } = "30/30/30";

        public string RoomPicture { get; set; }

        public int QuestId { get; set; }
        [ForeignKey("QuestId")]
        public virtual Quest Quest { get; set; }

    }
}
