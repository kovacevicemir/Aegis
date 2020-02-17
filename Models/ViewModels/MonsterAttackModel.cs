using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models.ViewModels
{
    public class MonsterAttackModel
    {

        public List<int> PlayerAttacks { get; set; }
        public List<int> MonsterAttacks { get; set; }

        public List<int> PlayerCurrentHpLog { get; set; }
        public List<int> MonsterCurrentHpLog { get; set; }

    }
}
