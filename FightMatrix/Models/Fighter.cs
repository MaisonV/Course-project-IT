using System;
using System.ComponentModel.DataAnnotations;

namespace FightMatrix.Models
{
    public class Fighter
    {
        [Key]
        public int ID { get; set; }

        [MinLength(3)]
        [Required]
        public string Name { get; set; }

        [Range(0,100)]
        public int Age { get; set; }

        [Range(0,100)]
        public int Height { get; set; }

        [Display(Name = "Debut Date")]
        [DataType(DataType.Date)]
        public DateTime DebutDate { get; set; }
        public string Promotion { get; set; }

        [Required]
        public string Category { get; set; }

        [Range(0,500)]
        public int Wins { get; set; }

        [Range(0, 500)]
        public int Loses { get; set; }

        [Range(0, 500)]
        public int Draws { get; set; }

        [Range(0, 500)]
        public int NC { get; set; }

        [Range(0,100000)]
        [Display(Name="Points")]
        public int RatingPoints { get; set; }
    }
}
