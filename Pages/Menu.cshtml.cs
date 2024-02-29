using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SignalAssigment_2.Data;
using SignalAssigment_2.Model;

namespace SignalAssigment_2.Pages
{
    public class MenuModel : PageModel
    {
        private readonly ApplicationContext _dbContext;

        public MenuModel(ApplicationContext context)
        {
            _dbContext = context;
        }

        public List<Product> Products { get; set; } = default!;
        public async Task OnGetAsync()
        {
            Products = await _dbContext.Products.ToListAsync(); // Use ToListAsync instead of ToList
        }
    }
}
