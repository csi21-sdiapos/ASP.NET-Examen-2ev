using DAL.models.DTOs;
using DAL.models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.models.ToDTO
{
    public class NotaToDTO
    {
        /// <summary>
        ///     Método que convierte una NotaDAO en una NotaDTO
        /// </summary>
        /// <param name="nota">
        ///     Recibe una nota del tipo Nota (entidad original)
        /// </param>
        /// <returns>
        ///     Devuelve una nota del tipo NotaDTO
        /// </returns>
        public static NotaDTO NotaDaoToNotaDto(Nota nota)
        {
            NotaDTO notaDTO = new NotaDTO();

            notaDTO.Md_uuid1 = nota.Md_uuid;
            notaDTO.Md_fch1 = nota.Md_fch;
            notaDTO.Cod_alumno1 = nota.Cod_alumno;
            notaDTO.Nota_evaluacion1 = nota.Nota_evaluacion;
            notaDTO.Cod_evaluacion1 = nota.Cod_evaluacion;

            return notaDTO;
        }
    }
}
