using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DAL.contexts;
using DAL.models.Entities;

namespace examen_2ev.Pages.CRUD.SelectEvaluacion
{
    public class SelectEvaluacionModel : PageModel
    {
        // creamos un objeto de la clase de nuestro contexto, para poder usar posteriormente sus DbSets para las operaciones del CRUD
        private readonly NotaEvaluacionContext notaEvaluacionContext;

        public SelectEvaluacionModel(NotaEvaluacionContext context)
        {
            notaEvaluacionContext = context;
        }

        // creamos una Lista del tipo Nota, para ir guardando todas las notas que recolectamos de la BBDD
        public IList<Nota> ListaNotas { get;set; } = default!;

        // creamos una propiedad para obtener el dato que el usuario introduce por pantalla (la evaluación que selecciona el usuario)
        [BindProperty]
        public string Cod_evaluacion { get; set; }


        /// <summary>
        ///     Método OnPost (asíncrono) para que cuando el usuario pulse en el botón de consultar,
        ///     se obtengan todas las notas de la BBDD, pertenecientes a una misma evaluación elegida por el usuario,
        ///     y se vayan guardando en una lista de notas, que después se recorrerá en la vista para mostrar sus datos
        /// </summary>
        public async Task OnPostAsync()
        {
            if (notaEvaluacionContext.SetNotas != null)
            {
                ListaNotas = await notaEvaluacionContext.SetNotas
                    .Where(e => e.Cod_evaluacion == Cod_evaluacion)
                    .Include(n => n.Evaluacion).ToListAsync();
            }
        }
    }
}
