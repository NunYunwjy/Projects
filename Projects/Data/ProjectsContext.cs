using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projects.Models;

namespace Projects.Data
{
    public class ProjectsContext : DbContext
    {
        public ProjectsContext (DbContextOptions<ProjectsContext> options)
            : base(options)
        {
        }

        public DbSet<Projects.Models.Category> Category { get; set; } = default!;
        public DbSet<Projects.Models.Project> Project { get; set; } = default!;
    }
}
