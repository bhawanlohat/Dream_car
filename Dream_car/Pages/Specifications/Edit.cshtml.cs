using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dream_car.Data;
using Dream_car.Models;

namespace Dream_car.Pages.Specifications
{
    public class EditModel : PageModel
    {
        private readonly Dream_car.Data.Dream_car_Database _context;

        public EditModel(Dream_car.Data.Dream_car_Database context)
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
           ViewData["ModelId"] = new SelectList(_context.Model, "Id", "Model_Name");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Specification).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecificationExists(Specification.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SpecificationExists(int id)
        {
            return _context.Specification.Any(e => e.Id == id);
        }
    }
}
