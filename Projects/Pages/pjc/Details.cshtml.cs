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
    public class DetailsModel : PageModel
    {
        private readonly Projects.Data.ProjectsContext _context;

        public DetailsModel(Projects.Data.ProjectsContext context)
        {
            _context = context;
        }

        public Project Project { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Project.FirstOrDefaultAsync(m => m.project_id == id);

            if (project is not null)
            {
                Project = project;

                return Page();
            }

            return NotFound();
        }
    }
}
