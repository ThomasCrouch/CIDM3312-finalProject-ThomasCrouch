using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using finalProject_ThomasCrouch.Models;

namespace CIDM3312_finalProject_ThomasCrouch.Pages.Prisons
{
    public class EditModel : PageModel
    {
        private readonly finalProject_ThomasCrouch.Models.PrisonDbContext _context;

        public EditModel(finalProject_ThomasCrouch.Models.PrisonDbContext context)
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

            var prison =  await _context.Prisons.FirstOrDefaultAsync(m => m.PrisonID == id);
            if (prison == null)
            {
                return NotFound();
            }
            Prison = prison;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Prison).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PrisonExists(Prison.PrisonID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PrisonExists(int id)
        {
          return (_context.Prisons?.Any(e => e.PrisonID == id)).GetValueOrDefault();
        }
    }
}
