using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using finalProject_ThomasCrouch.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace finalProject_ThomasCrouch.Pages
{
    public class AddPrisonerModel : PageModel
    {
        private readonly ILogger<AddPrisonerModel> _logger;
        private readonly PrisonDbContext _context;
        
        [BindProperty]
        public Prisoner Prisoner {get; set;} = default!;
        public SelectList PrisonsDropDown {get; set;} = default!;

        public AddPrisonerModel(PrisonDbContext context, ILogger<AddPrisonerModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            PrisonsDropDown = new SelectList(_context.Prisons.ToList(), "PrisonID", "PrisonName");
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Prisoners.Add(Prisoner);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}