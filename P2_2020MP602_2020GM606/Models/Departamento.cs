using System.ComponentModel.DataAnnotations;

namespace P2_2020MP602_2020GM606.Models
{
    public class Departamento
    {
        [Key]
        public int id_departamento { get; set; }
        public int Nombre_dep { get; set; }
    }
}
