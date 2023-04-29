using System.ComponentModel.DataAnnotations;
namespace P2_2020MP602_2020GM606.Models
{
    public class Generos
    {
        [Key]
        public int id_genero { get; set; }
        [Display(Name = "Genero")]
        public String? genero { get; set; }
    }
}
