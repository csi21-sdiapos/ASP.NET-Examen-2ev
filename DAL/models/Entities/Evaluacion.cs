using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.models.Entities
{
    [Table("eva_cat_evaluacion", Schema = "sc_evaluacion")]
    public class Evaluacion
    {
        [Key]
        [Required]
        [Column("Cod_evaluacion")]
        [Display(Name = "Cod_evaluacion")]
        public string Cod_evaluacion { get; set; }

        [Required]
        [Column("Desc_evaluacion")]
        [Display(Name = "Desc_evaluacion")]
        public string? Desc_evaluacion { get; set; }

        /****************************** Campos Relacionales *********************************/

        // Relación Evaluacion-Nota --> 1:N --> una evaluación tiene muchas notas
        [InverseProperty("Evaluacion")]
        public virtual List<Nota>? ListaNotas { get; set; }
    }
}
