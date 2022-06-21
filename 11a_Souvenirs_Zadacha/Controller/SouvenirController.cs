using _11a_Souvenirs_Zadacha.Data;
using _11a_Souvenirs_Zadacha.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11a_Souvenirs_Zadacha.Controller
{
    public class SouvenirController
    {
        private SouvenirContext souvenirContext = new SouvenirContext();
        public List<Souvenir> GetAll()
        {

            return souvenirContext.Souvenirs.Include("SouvenirType").ToList();
        }

        public Souvenir Get(int id)
        {
            Souvenir find = souvenirContext.Souvenirs.Find(id);
            if (find != null)
            {
                souvenirContext.Entry(find).Reference(x => x.SouvenirType).Load();
            }
            return find;
        }

        public void Add(Souvenir souvenir)
        {
            souvenirContext.Souvenirs.Add(souvenir);
            souvenirContext.SaveChanges();
        }
        public void Update(int id, Souvenir souvenir)
        {
            Souvenir souvenir1 = souvenirContext.Souvenirs.Find(id);
            if (souvenir == null)
            {
                return;
            }
            souvenir1.Name = souvenir.Name;
            souvenir1.Description = souvenir.Description;
            souvenir1.Price = souvenir.Price;
            souvenir1.SouvenirTypeId = souvenir.SouvenirTypeId;
            souvenirContext.SaveChanges();
        }
        public void Delete(int id)
        {
            Souvenir souvenir = souvenirContext.Souvenirs.Find(id);
            souvenirContext.Souvenirs.Remove(souvenir);
            souvenirContext.SaveChanges();
        }
    }
}
