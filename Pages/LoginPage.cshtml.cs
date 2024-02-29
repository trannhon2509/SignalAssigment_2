using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SignalAssigment_2.Model;
using System.Security.Claims;

namespace SignalAssigment_2.Pages
{
    public class LoginPageModel : PageModel
    {
        private readonly SignalAssigment_2.Data.ApplicationContext _context;

        public LoginPageModel(SignalAssigment_2.Data.ApplicationContext context)
        {
            _context = context;
        }
        public IList<Account> account { get; set; } = default!;
        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync()
        {
            account = await _context.Accounts.ToListAsync();
            foreach (var item in account)
            {
                if(string.Equals(item.UserName, Request.Form["username"]) && string.Equals(item.Password, Request.Form["password"]))
                {
                    if(item.Type == 1){
                        return RedirectToPage("/Index");
                    } else
                    {
                        return Page();
                    }
                    
                }
            }

            return Page();
        }
    }
}
