using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projects.Data;
using Projects.Models;

namespace Projects.Pages.pjc
{
    public class CreateModel : PageModel
    {
        private readonly Projects.Data.ProjectsContext _context;

        public CreateModel(Projects.Data.ProjectsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["category_id"] = new SelectList(_context.Category, "category_id", "category_id");
            return Page();
        }

        [BindProperty]
        public Project Project { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Project.Add(Project);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
