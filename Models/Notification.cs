using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }

        public string Type { get; set; }

        public int IntValue1 { get; set; }

        public int IntValue2 { get; set; }

        public string Description { get; set; }

    }
}
