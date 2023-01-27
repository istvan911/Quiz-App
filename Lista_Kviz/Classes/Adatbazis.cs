using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Lista_Kviz
{
    class Adatbazis : DbContext
    {
        public Adatbazis() : base("KvizDB")
        {

        }
        public DbSet<Felhasznalo> Felhasznalok { get; set; }
        public DbSet<Temakor> Temakorok { get; set; }
        public DbSet<Class4Valasz> Kerdesek { get; set; }
    }
}