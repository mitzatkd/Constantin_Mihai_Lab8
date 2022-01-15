using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Constantin_Mihai_Lab8.Data;
using Constantin_Mihai_Lab8.Models;

namespace Constantin_Mihai_Lab8.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Constantin_Mihai_Lab8.Data.Constantin_Mihai_Lab8Context _context;

        public DetailsModel(Constantin_Mihai_Lab8.Data.Constantin_Mihai_Lab8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book
                .Include(b=>b.Publisher)
                .Include(b=>b.BookCategories)
                .ThenInclude(b=>b.Category)
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
