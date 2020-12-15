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

namespace Dream_car.Pages.Models
{
    public class EditModel : PageModel
    {
        private readonly Dream_car.Data.Dream_car_Database _context;

        public EditModel(Dream_car.Data.Dream_car_Database context)
        {
            _context = context;
        }

        [BindProperty]
        public Model Model { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Model = await _context.Model
                .Include(m => m.Dealer).FirstOrDefaultAsync(m => m.Id == id);

            if (Model == null)
            {
                return NotFound();
            }
           ViewData["DealerId"] = new SelectList(_context.Dealer, "Id", "Dealer_Address");
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

            _context.Attach(Model).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModelExists(Model.Id))
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

        private bool ModelExists(int id)
        {
            return _context.Model.Any(e => e.Id == id);
        }
    }
}
