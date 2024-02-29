﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SignalAssigment_2.Data;
using SignalAssigment_2.Model;

namespace SignalAssigment_2.Pages.Product_page
{
    public class IndexModel : PageModel
    {
        private readonly SignalAssigment_2.Data.ApplicationContext _context;

        public IndexModel(SignalAssigment_2.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
            
        }
        public async Task OnPostAsync()
        {
            // Handle POST request for search
            var searchId = Request.Form["id"];
            Product = await _context.Products
                .Where(p => p.ProductName.Contains(searchId)  )
                .ToListAsync();
        }
    }
}
