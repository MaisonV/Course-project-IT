using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FightMatrix.Models
{
    public class News
    {
        public int ID { get; set; }

        [Required]
        public string Header { get; set; }

        public string Author { get; set; }

        [DataType(DataType.Date)]
        public DateTime NewsDate { get; set; }

        [Required]
        public string Text { get; set; }

    }
}
