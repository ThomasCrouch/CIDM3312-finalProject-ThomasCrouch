using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using finalProject_ThomasCrouch.Models;

namespace CIDM3312_finalProject_ThomasCrouch.Pages.Prisons
{
    public class DeleteModel : PageModel
    {
        private readonly finalProject_ThomasCrouch.Models.PrisonDbContext _context;

        public DeleteModel(finalProject_ThomasCrouch.Models.PrisonDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Prison Prison { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Prisons == null)
            {
                return NotFound();
            }

            var prison = await _context.Prisons.FirstOrDefaultAsync(m => m.PrisonID == id);

            if (prison == null)
            {
                return NotFound();
            }
            else 
            {
                Prison = prison;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Prisons == null)
            {
                return NotFound();
            }
            var prison = await _context.Prisons.FindAsync(id);

            if (prison != null)
            {
                Prison = prison;
                _context.Prisons.Remove(Prison);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
