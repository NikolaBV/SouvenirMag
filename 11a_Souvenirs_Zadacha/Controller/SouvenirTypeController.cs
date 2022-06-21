using _11a_Souvenirs_Zadacha.Data;
using _11a_Souvenirs_Zadacha.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11a_Souvenirs_Zadacha.Controller
{
    public class SouvenirTypeController
    {
        private SouvenirContext souvenirTypeContext = new SouvenirContext();
        public List<SouvenirType> GetAllTypes()
        {
            return souvenirTypeContext.SouvenirTypes.ToList();
        }
        public string GetType(int id)
        {
            return souvenirTypeContext.SouvenirTypes.Find(id).Name;
        }
    }
}
