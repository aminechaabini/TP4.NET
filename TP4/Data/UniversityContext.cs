using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using TP4.Models;

namespace TP4.Data
{
    public class UniversityContext : DbContext
    {
        private static UniversityContext _instance;
        private UniversityContext(DbContextOptions o): base(o) {
            
        }

         public static UniversityContext Instantiate_UniversityContext()
        {
            if (_instance == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
                optionsBuilder.UseSqlite(@"Data source=D:\\Downloads\2022 GL3 .NET Framework TP4 - SQLite database.db");
                _instance = new UniversityContext(optionsBuilder.Options);
            }
            return _instance;
            
        }
        public DbSet<StudentModel> Student { get; set; }
    }
}
