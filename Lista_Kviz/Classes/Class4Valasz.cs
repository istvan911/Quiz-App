using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lista_Kviz
{
    internal class Class4Valasz
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Temakor { get; set; }
        [Required]
        public string tipus { get; set; }
        [Required]
        public string kerdes { get; set; }
        [Required]
        public string valasz1 { get; set; }
        [Required]
        public string valasz2 { get; set; }
        public string valasz3 { get; set; }
        public string valasz4 { get; set; }
        [Required]
        public int helyesvalasz { get; set; }
    }
}
