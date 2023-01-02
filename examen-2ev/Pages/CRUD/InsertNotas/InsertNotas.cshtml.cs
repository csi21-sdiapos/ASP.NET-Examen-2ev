using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DAL.contexts;
using DAL.models.Entities;
using DAL.models.DTOs;
using DAL.models.ToDAO;

namespace examen_2ev.Pages.CRUD.InsertNotas2
{
    public class InsertNotasModel : PageModel
    {
        // creamos un objeto de la clase de nuestro contexto, para poder usar posteriormente sus DbSets para las operaciones del CRUD
        private readonly NotaEvaluacionContext notaEvaluacionContext;

        public InsertNotasModel(NotaEvaluacionContext context)
        {
            notaEvaluacionContext = context;
        }

        // con este método OnGet(), en cuanto el usuario entre en esta page, se obtienen las diferentes evaluaciones para mostrarlas en un dropdown
        public IActionResult OnGet()
        {
        ViewData["Cod_evaluacion"] = new SelectList(notaEvaluacionContext.SetEvaluaciones, "Cod_evaluacion", "Cod_evaluacion");
            return Page();
        }

        // creamos una propiedad del tipo de la NotaDTO, para obtener los datos que el usuario introduce por pantalla a través de los campos de este objeto
        [BindProperty]
        public NotaDTO NotaDTO { get; set; }
        

        /// <summary>
        ///     Método OnPost (asíncrono) para crear una nueva nota en la BBDD
        /// </summary>
        /// <returns>
        ///     Devuelva la redirección del usuario hacia otro componente
        /// </returns>
        public async Task<IActionResult> OnPostAsync()
        {
            /*
            if (!ModelState.IsValid) // no entiendo por qué ModelState siempre se marca como no válido (IsValid = false)
            {
                return Page();
            }
            */

            // Creamos un objeto del tipo NotaDTO, para usar su constructor con los parámetros que recibimos de usuario
            NotaDTO notaDTO = new NotaDTO(NotaDTO.Cod_alumno1, NotaDTO.Nota_evaluacion1, NotaDTO.Cod_evaluacion1);

            // convertimos la NotaDTO a una NotaDAO
            Nota nota = NotaToDAO.NotaDtoToNotaDao(notaDTO);

            // utilizamos el contexto para acceder al DbSet de notas y añadir la nueva nota que hemos creado
            notaEvaluacionContext.SetNotas.Add(nota);
            await notaEvaluacionContext.SaveChangesAsync(); // guardamos los cambios de forma asíncrona

            return RedirectToPage("../SelectNotas/SelectNotas"); // redirigimos al usuario a otro componente para que pueda consultar la nota que acaba de crear
        }
    }
}
