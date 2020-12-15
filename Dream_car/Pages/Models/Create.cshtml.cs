﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dream_car.Data;
using Dream_car.Models;

namespace Dream_car.Pages.Models
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
        ViewData["DealerId"] = new SelectList(_context.Dealer, "Id", "Dealer_Address");
            return Page();
        }

        [BindProperty]
        public Model Model { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Model.Add(Model);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
