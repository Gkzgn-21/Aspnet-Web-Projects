using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityBasvuruForm
    {
        private int basvuruid; // Küçük i kullanmaya dikkat
        public int BASVURUID { get => basvuruid; set => basvuruid = value; } // Özellik adı BÜYÜK HARF

        private int basdersid;
        public int BASDERSID { get => basdersid; set => basdersid = value; }

        private int basogrid;
        public int BASOGRID { get => basogrid; set => basogrid = value; }
    }
}
