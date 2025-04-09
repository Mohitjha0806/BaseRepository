using BaseRepository.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BaseRepository.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
