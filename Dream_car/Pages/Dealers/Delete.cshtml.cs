using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dream_car.Data;
using Dream_car.Models;

namespace Dream_car.Pages.Dealers
{
    public class DeleteModel : PageModel
    {
        private readonly Dream_car.Data.Dream_car_Database _context;

        public DeleteModel(Dream_car.Data.Dream_car_Database context)
        {
            _context = context;
        }

        [BindProperty]
        public Dealer Dealer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dealer = await _context.Dealer
                .Include(d => d.Company).FirstOrDefaultAsync(m => m.Id == id);

            if (Dealer == null)
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

            Dealer = await _context.Dealer.FindAsync(id);

            if (Dealer != null)
            {
                _context.Dealer.Remove(Dealer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
