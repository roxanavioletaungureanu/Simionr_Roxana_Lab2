using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Simionr_Roxana_Lab2.Data;
using Simionr_Roxana_Lab2.Models;

namespace Simionr_Roxana_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Simionr_Roxana_Lab2.Data.Simionr_Roxana_Lab2Context _context;

        public IndexModel(Simionr_Roxana_Lab2.Data.Simionr_Roxana_Lab2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await_context.Book
                .Include(base=>base.Publisher)
                .ToListAsync();
            }
        }
    }
}
