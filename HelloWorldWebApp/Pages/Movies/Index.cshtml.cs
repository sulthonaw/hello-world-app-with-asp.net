﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HelloWorldWebApp.Data;
using HelloWorldWebApp.Models;

namespace HelloWorldWebApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly HelloWorldWebApp.Data.HelloWorldWebAppContext _context;

        public IndexModel(HelloWorldWebApp.Data.HelloWorldWebAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
