using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlogUniversity.Models
{
    public class Portfolio
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pid { get; set; }
        [Required]
        public string WordFilter { get; set; } 
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImageUrl { get; set; }

    }
}
