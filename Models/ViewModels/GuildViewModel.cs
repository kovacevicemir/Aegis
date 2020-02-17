using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models.ViewModels
{
    public class GuildViewModel
    {
        public IEnumerable<PlayerModel> MemberList { get; set; }
        public Guild Guild { get; set; }
    }
}
