using System.ComponentModel.DataAnnotations;
namespace P2_2020MP602_2020GM606.Models
{
    public class CasosReportados
    {
        [Key]
        public int id_caso { get; set; }
        public int num_casos_confirm { get; set; }
        public int num_casos_rec { get; set; }
        public int num_casos_fall { get; set; }
    }
}
