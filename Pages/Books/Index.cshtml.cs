﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Nechita_Carina_Lab8.Data;
using Nechita_Carina_Lab8.Models;

namespace Nechita_Carina_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Nechita_Carina_Lab8.Data.Nechita_Carina_Lab8Context _context;

        public IndexModel(Nechita_Carina_Lab8.Data.Nechita_Carina_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.Include(b => b.Publisher).ToListAsync();
        }
    }
}
