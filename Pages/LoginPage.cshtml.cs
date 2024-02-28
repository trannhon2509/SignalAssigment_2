using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SignalAssigment_2.Model;
using System.Security.Claims;

namespace SignalAssigment_2.Pages
{
    public class LoginPageModel : PageModel
    {
        [BindProperty]
        public Account account { get; set; }

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            // Verify
            if(account.UserName == "admin" && account.Password == "admin")
            {
                // Create the security context
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "admin"),
                    new  Claim(ClaimTypes.Email, "admin")
                };
                var identity = new ClaimsIdentity(claims, "MyCookieAuth");

                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync("MyCookieAuth", claimsPrincipal);

                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
