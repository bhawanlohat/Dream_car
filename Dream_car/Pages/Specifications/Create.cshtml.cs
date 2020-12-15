using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dream_car.Data;
using Dream_car.Models;

namespace Dream_car.Pages.Specifications
{
    public class CreateModel : PageModel
    {
        private readonly Dream_car.Data.Dream_car_Database _context;

        public CreateModel(Dream_car.Data.Dream_car_Database context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ModelId"] = new SelectList(_context.Model, "Id", "Model_Name");
            return Page();
        }

        [BindProperty]
        public Specification Specification { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Specification.Add(Specification);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
