using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<GlobalChat> GlobalChatMessageList { get; set;}
        public IEnumerable<PlayerModel> KnightRanking { get; set; }
        public IEnumerable<PlayerModel> ArcherRanking { get; set; }
        public IEnumerable<PlayerModel> MageRanking { get; set; }
        public IEnumerable<PlayerModel> GoldRanking { get; set; }
        public IEnumerable<Guild> CrewRanking { get; set; }
        public IEnumerable<PlayerModel> PowerRanking { get; set; }

    }
}
