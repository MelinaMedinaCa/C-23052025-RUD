using C_23052025_RUD.Data;
using C_23052025_RUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace C_23052025_RUD.Pages.Alumnos
{
    public class CreateModel : PageModel
    {
        public void OnGet()
        {

        }
        [BindProperty]
        public Models.Alumno Alumno { get; set; }

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			Alumno.Id = DatosCompartidos.ObtenerNuevoId();
			//DatosCompartidos.Alumno.Add(Alumno);
			return RedirectToPage("Index");

		}





	}
}
