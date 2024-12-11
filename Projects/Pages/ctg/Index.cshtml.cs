using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projects.Data;
using Projects.Models;

namespace Projects.Pages.ctg
{
    public class IndexModel : PageModel
    {
        private readonly Projects.Data.ProjectsContext _context;

        public IndexModel(Projects.Data.ProjectsContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Category = await _context.Category
                .Include(c => c.parentCategory).ToListAsync();
        }
    }
}
