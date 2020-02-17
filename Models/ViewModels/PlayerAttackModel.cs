using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models.ViewModels
{
    public class PlayerAttackModel
    {
        public List<PlayerModel> AttackerAndDeffenderModels { get; set; }

        public List<int> AttackerAttacks { get; set; }
        public List<int> DeffenderAttacks { get; set; }

        public List<int> AttackerDeffs { get; set; }
        public List<int> DeffenderDeffs { get; set; }

        public List<int> AttackerCurrentHpLog { get; set; }
        public List<int> DeffenderCurrentHpLog { get; set; }

    }
}
