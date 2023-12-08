using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vieru_Marina_LAB2.Data;
using Vieru_Marina_LAB2.Models;

namespace Vieru_Marina_LAB2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Vieru_Marina_LAB2.Data.Vieru_Marina_LAB2Context _context;

        public IndexModel(Vieru_Marina_LAB2.Data.Vieru_Marina_LAB2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                .Include(b => b.Publisher).ToListAsync();
            }
        }
    }
}
