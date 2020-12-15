﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly Dream_car.Data.Dream_car_Database _context;

        public DetailsModel(Dream_car.Data.Dream_car_Database context)
        {
            _context = context;
        }

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
    }
}
