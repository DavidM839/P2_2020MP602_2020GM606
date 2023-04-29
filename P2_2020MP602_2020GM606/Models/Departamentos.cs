using System.ComponentModel.DataAnnotations;

namespace P2_2020MP602_2020GM606.Models
{
    public class Departamentos
    {
        [Key]
        public int id_departamento { get; set; }
        public String? Nombre_dep { get; set; }
    }
}
