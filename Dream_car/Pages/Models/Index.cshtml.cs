using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dream_car.Data;
using Dream_car.Models;

namespace Dream_car.Pages.Models
{
    public class IndexModel : PageModel
    {
        private readonly Dream_car.Data.Dream_car_Database _context;

        public IndexModel(Dream_car.Data.Dream_car_Database context)
        {
            _context = context;
        }

        public IList<Model> Model { get;set; }

        public async Task OnGetAsync()
        {
            Model = await _context.Model
                .Include(m => m.Dealer).ToListAsync();
        }
    }
}
