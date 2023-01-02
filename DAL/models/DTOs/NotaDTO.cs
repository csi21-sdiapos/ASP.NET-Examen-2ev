using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models.DTOs
{
    public class NotaDTO
    {
        // ATRIBUTOS
        string Md_uuid;
        DateTime Md_fch;
        string Cod_alumno;
        int Nota_evaluacion;
        string Cod_evaluacion;


        // CONSTRUCTORES

        // constructor lleno (sin md_uuid, md_fch)
        public NotaDTO(/*string md_uuid, DateTime md_fch,*/ string cod_alumno, int nota_evaluacion, string cod_evaluacion)
        {
            Md_uuid = RamdomValue();
            Md_fch = DateTime.Now;
            Cod_alumno = cod_alumno;
            Nota_evaluacion = nota_evaluacion;
            Cod_evaluacion = cod_evaluacion;
        }

        // constructor vacío
        public NotaDTO()
        {
        }


        // GETTERS Y SETTERS
        public string Md_uuid1 { get => Md_uuid; set => Md_uuid = value; }
        public DateTime Md_fch1 { get => Md_fch; set => Md_fch = value; }
        public string Cod_alumno1 { get => Cod_alumno; set => Cod_alumno = value; }
        public int Nota_evaluacion1 { get => Nota_evaluacion; set => Nota_evaluacion = value; }
        public string Cod_evaluacion1 { get => Cod_evaluacion; set => Cod_evaluacion = value; }


        // MÉTODOS
        public string RamdomValue()
        {
            Random random = new Random();
            return ("A" + random.Next());
        }

    }
}
