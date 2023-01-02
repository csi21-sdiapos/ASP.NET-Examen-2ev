using DAL.models.DTOs;
using DAL.models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models.ToDAO
{
    public class NotaToDAO
    {
        /// <summary>
        ///     Método que convierte una NotaDTO en una NotaDAO
        /// </summary>
        /// <param name="notaDTO">
        ///     Recibe una nota del tipo NotaDTO
        /// </param>
        /// <returns>
        ///     Devuelve una nota del tipo Nota (entidad original)
        /// </returns>
        public static Nota NotaDtoToNotaDao(NotaDTO notaDTO)
        {
            Nota nota = new Nota();

            nota.Md_uuid = notaDTO.Md_uuid1;
            nota.Md_fch = notaDTO.Md_fch1;
            nota.Cod_alumno = notaDTO.Cod_alumno1;
            nota.Nota_evaluacion = notaDTO.Nota_evaluacion1;
            nota.Cod_evaluacion = notaDTO.Cod_evaluacion1;

            return nota;
        }
    }
}
