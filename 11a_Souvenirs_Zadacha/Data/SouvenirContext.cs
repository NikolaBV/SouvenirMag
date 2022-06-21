using _11a_Souvenirs_Zadacha.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11a_Souvenirs_Zadacha.Data
{
    public class SouvenirContext : DbContext
    {
        public SouvenirContext() : base("name=SouvenirContext")
        {

        }
        public DbSet<Souvenir> Souvenirs { get; set; }
        public DbSet<SouvenirType> SouvenirTypes { get; set; }
    }
}
