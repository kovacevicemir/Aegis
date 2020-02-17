using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models.ViewModels
{
    public class Top100ViewModel
    {
        public IEnumerable<PlayerModel> PlayerRanking { get; set; }
        public IEnumerable<Guild> CrewRanking { get; set; }
        public string RankBy { get; set; }
    }
}
