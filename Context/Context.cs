using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NNI8G0S; Database=Sunparadise; Trusted_Connection=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<IsIlanı> IsIlanlari { get; set; }
        public DbSet<CvTablosu> CvTablosu { get; set; }
        public DbSet<Deneyim> DeneyimTablosu { get; set; }
        public DbSet<Egitim> EgitimTablosu { get; set; }
    }
}
