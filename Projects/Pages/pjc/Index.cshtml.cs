using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Projects.Data;
using Projects.Models;

namespace Projects.Pages.pjc
{
    public class IndexModel : PageModel
    {
        private readonly Projects.Data.ProjectsContext _context;

        public IndexModel(Projects.Data.ProjectsContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Project = await _context.Project
                .Include(p => p.category).ToListAsync();
        }
    }
}
