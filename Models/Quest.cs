using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models
{
    public class Quest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int LevelReq { get; set; } = 1;

        public string NpcName { get; set; }

        public string Description { get; set; }

        public string MonsterList { get; set; } = "0/0/0/0/0";

        public int MonsterCountFirst { get; set; }
        public int MonsterCountSecond { get; set; }
        public int MonsterCountThird { get; set; }
        public int MonsterCountFourth { get; set; }
        public int MonsterCountFifth { get; set; }
    }
}
