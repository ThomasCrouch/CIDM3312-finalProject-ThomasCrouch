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
    public class DetailsModel : PageModel
    {
        private readonly finalProject_ThomasCrouch.Models.PrisonDbContext _context;

        public DetailsModel(finalProject_ThomasCrouch.Models.PrisonDbContext context)
        {
            _context = context;
        }

      public Prison Prison { get; set; } = default!; 

      [BindProperty]
      public int PrisonerIDToRelease {get; set;}

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Prisons == null)
            {
                return NotFound();
            }

            var prison = await _context.Prisons.Include(m => m.Prisoners).FirstOrDefaultAsync(m => m.PrisonID == id);
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

        public IActionResult OnPostReleasePrisoner(int? id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var Prisoner = _context.Prisoners.FirstOrDefault(p => p.PrisonerID == PrisonerIDToRelease);

            if (Prisoner != null)
            {
                _context.Remove(Prisoner);
                _context.SaveChanges();
            }

            Prison = _context.Prisons.Include(p => p.Prisoners).First(p => p.PrisonID == id);

            return Page();
        }
    }
}
