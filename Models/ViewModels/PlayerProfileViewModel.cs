using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models.ViewModels
{
    public class PlayerProfileViewModel
    {
        public PlayerModel PlayerModel { get; set; }
        public List<Item> EquipedItems { get; set; }
        public int PlayerRank { get; set; }
        public Guild PlayerGuild { get; set; }
        public int GoldRank { get; set; }
    }
}
