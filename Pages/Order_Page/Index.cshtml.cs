﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SignalAssigment_2.Data;
using SignalAssigment_2.Model;

namespace SignalAssigment_2.Pages.Order_Page
{
    public class IndexModel : PageModel
    {
        private readonly SignalAssigment_2.Data.ApplicationContext _context;

        public IndexModel(SignalAssigment_2.Data.ApplicationContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Order = await _context.Orders
                .Include(o => o.Customer).ToListAsync();
        }
    }
}
