using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Dream_car.Data;
using Dream_car.Models;

namespace Dream_car.Pages.Companys
{
    public class IndexModel : PageModel
    {
        private readonly Dream_car.Data.Dream_car_Database _context;

        public IndexModel(Dream_car.Data.Dream_car_Database context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; }

        public async Task OnGetAsync()
        {
            Company = await _context.Company.ToListAsync();
        }
    }
}
