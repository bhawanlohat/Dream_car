using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dream_car.Data;
using Dream_car.Models;

namespace Dream_car.Pages.Specifications
{
    public class DeleteModel : PageModel
    {
        private readonly Dream_car.Data.Dream_car_Database _context;

        public DeleteModel(Dream_car.Data.Dream_car_Database context)
        {
            _context = context;
        }

        [BindProperty]
        public Specification Specification { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Specification = await _context.Specification
                .Include(s => s.Model).FirstOrDefaultAsync(m => m.Id == id);

            if (Specification == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Specification = await _context.Specification.FindAsync(id);

            if (Specification != null)
            {
                _context.Specification.Remove(Specification);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
