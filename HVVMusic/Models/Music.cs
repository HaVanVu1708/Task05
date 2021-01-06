using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HVVMusic.Models
{
    public class Music
    {
        public int MusicID { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

       
        public string ReleaseDate { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Likes { get; set; }
        public decimal Price { get; set; }
    }
}
