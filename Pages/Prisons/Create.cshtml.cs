using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using finalProject_ThomasCrouch.Models;

namespace CIDM3312_finalProject_ThomasCrouch.Pages.Prisons
{
    public class CreateModel : PageModel
    {
        private readonly finalProject_ThomasCrouch.Models.PrisonDbContext _context;

        public CreateModel(finalProject_ThomasCrouch.Models.PrisonDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Prison Prison { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Prisons == null || Prison == null)
            {
                return Page();
            }

            _context.Prisons.Add(Prison);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
