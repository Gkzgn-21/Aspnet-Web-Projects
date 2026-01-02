using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BllListele()
        {
            return DALDers.KDersListesi();
        }

        public static List<EntityDers> BllKontenjanListele()
        {
            return DALDers.KontenjanListele();
        }
        public static int TalepEkleBLL(EntityBasvuruForm p)
        {
            if (p.BASOGRID > 0 && p.BASDERSID > 0)
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }

        public static List<int> IstatistikGetir()
        {
            List<int> istatistikler = new List<int>();
            istatistikler.Add(DALDers.ToplamOgrenciSayisi());
            istatistikler.Add(DALDers.ToplamDersSayisi());
            istatistikler.Add(DALDers.ToplamBasvuruSayisi());
            return istatistikler;
        }

    }
}
