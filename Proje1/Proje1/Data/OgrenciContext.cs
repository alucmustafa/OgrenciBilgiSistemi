using Microsoft.EntityFrameworkCore;
using Proje1.Models;

namespace Proje1.Data
{
    public class OgrenciContext:DbContext
    {
        public OgrenciContext(DbContextOptions<OgrenciContext> options) : base(options)
        {

        }
        //public OgrenciContext():base("name"="OgrenciContext")
        //{
        //}


        public DbSet<Ogrenci> ogrencis { get; set; }
    }
}
