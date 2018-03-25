using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentsData.Models
{
    public class StudentsDataContext : DbContext
    {
        public StudentsDataContext (DbContextOptions<StudentsDataContext> options)
            : base(options)
        {
        }

        public DbSet<StudentsData.Models.Students> Students { get; set; }
    }
}
