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
    public class DetailsModel : PageModel
    {
        private readonly Projects.Data.ProjectsContext _context;

        public DetailsModel(Projects.Data.ProjectsContext context)
        {
            _context = context;
        }

        public Category Category { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.category_id == id);

            if (category is not null)
            {
                Category = category;

                return Page();
            }

            return NotFound();
        }
    }
}
