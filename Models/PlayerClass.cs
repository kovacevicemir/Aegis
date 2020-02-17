using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models
{
    public class PlayerClass
    {
        public int Id { get; set; }

        public enum EPlayerClass { Knight = 0, Archer = 1 , Mage = 2}

    }
}
