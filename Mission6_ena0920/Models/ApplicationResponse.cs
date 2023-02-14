using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission6_ena0920.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }
        
        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public ushort Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string LentTo { get; set; }

        public string Notes { get; set; }
    }
}
