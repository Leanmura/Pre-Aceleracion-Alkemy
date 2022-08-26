using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    public class Comment
    {
        [Key]
        public int Id{ set; get; }
        public DateTime? Date { set; get; } 
        public string Comments { set; get; }
        public Usuario User { set; get; }
    }
}
