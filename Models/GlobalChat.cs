using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Aegis.Models
{
    public class GlobalChat
    {
        [Key]
        public int Id { get; set; }

        //F. key
        public int PlayerId { get; set; }
        [ForeignKey("PlayerId")]
        public virtual PlayerModel Player { get; set; }

        public string Message { get; set; }

    }
}
