using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentAppp.Models;

namespace StudentAppp.Data
{
    public class StudentApppContext : DbContext
    {
        public StudentApppContext (DbContextOptions<StudentApppContext> options)
            : base(options)
        {
        }

        public DbSet<StudentAppp.Models.Student> Student { get; set; } = default!;
    }
}
