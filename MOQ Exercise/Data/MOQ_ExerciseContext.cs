using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MOQ_Exercise.Models;

namespace MOQ_Exercise.Data
{
    public class MOQ_ExerciseContext : DbContext
    {
        public MOQ_ExerciseContext (DbContextOptions<MOQ_ExerciseContext> options)
            : base(options)
        {
        }

        public DbSet<MOQ_Exercise.Models.Employee> Employee { get; set; } = default!;
    }
}
