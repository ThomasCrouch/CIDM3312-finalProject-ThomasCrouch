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
    public class IndexModel : PageModel
    {
        private readonly finalProject_ThomasCrouch.Models.PrisonDbContext _context;

        public IndexModel(finalProject_ThomasCrouch.Models.PrisonDbContext context)
        {
            _context = context;
        }

        public IList<Prison> Prison { get;set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;

        public int PageSize {get; set;} = 10;

        [BindProperty(SupportsGet = true)]
        public string? CurrentSort {get; set;}

        public async Task OnGetAsync()
        {
            if (_context.Prisons != null)
            {
                var query = _context.Prisons.Select(p => p);

                switch (CurrentSort)
                {
                    case "first_asc": 
                        query = query.OrderBy(p => p.PrisonName);
                        break;
                    case "first_desc":
                        query = query.OrderByDescending(p => p.PrisonName);
                        break;
                }
                
                Prison = await _context.Prisons.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            }
        }
    }
}
