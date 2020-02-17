using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        public int LevelReq { get; set; } = 1;

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public int ManaCost { get; set; }

        public string Picture { get; set; }

        public int AttackAdd { get; set; } = 0;

        public int DeffenseAdd { get; set; } = 0;

        public int CritAdd { get; set; } = 0;

        public int BlockAdd { get; set; } = 0;

        public int AttackMultiplier { get; set; } = 0;

        public int DeffenseMultiplier { get; set; } = 0;

        public enum ESkill { AoE = 0, Single = 1 }

        public string PlayerClass { get; set; }
    }
}
