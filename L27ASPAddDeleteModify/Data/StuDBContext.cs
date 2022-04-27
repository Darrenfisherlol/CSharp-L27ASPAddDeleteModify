
using L27ASPAddDeleteModify.Models;
using Microsoft.EntityFrameworkCore;


namespace L27ASPAddDeleteModify.Data
{
    public class StuDBContext: DbContext
    {

        public DbSet<Student> Students { get; set; }

        public string DbPath { get; }

        public StuDBContext()
        {
            DbPath = System.IO.Path.Join("Data/Students.db");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {



            options.UseSqlite($"Data Source=Data/stu.db");
        }


    }
}
