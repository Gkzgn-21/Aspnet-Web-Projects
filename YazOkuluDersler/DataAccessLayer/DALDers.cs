using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALDers
    {
        public static List<EntityDers> KDersListesi()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut2 = new SqlCommand("Select DERSID, DERSAD, DERSMINKONT, DERSMAKSKONT From TBLDERS", Baglanti.bgl);

            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }

            SqlDataReader dr = komut2.ExecuteReader() ;
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.ID = Convert.ToInt32(dr["DERSID"].ToString());
                ent.DERSAD = dr["DERSAD"].ToString();
                ent.MIN = int.Parse(dr["DERSMINKONT"].ToString());
                ent.MAX = int.Parse(dr["DERSMAKSKONT"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static List<EntityDers> KontenjanListele()
        {
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut3 = new SqlCommand("SELECT DERSID, DERSAD, DERSMINKONT, DERSMAKSKONT, (SELECT COUNT(*) FROM TBLBASVURUFORM WHERE DERSID = TBLDERS.DERSID) AS 'KAYITLI' FROM TBLDERS", Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open) { komut3.Connection.Open(); }
            SqlDataReader dr = komut3.ExecuteReader();
            while (dr.Read())
            {
                EntityDers ent = new EntityDers();
                ent.ID = Convert.ToInt32(dr["DERSID"].ToString());
                ent.DERSAD = dr["DERSAD"].ToString();
                ent.MIN = int.Parse(dr["DERSMINKONT"].ToString());
                ent.MAX = int.Parse(dr["DERSMAKSKONT"].ToString());
                ent.DERSKAYITLISAYISI = int.Parse(dr["KAYITLI"].ToString()); // Yeni alan
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBLBASVURUFORM (OGRENCIID, DERSID) VALUES (@p1, @p2)", Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1", parametre.BASOGRID);
            komut.Parameters.AddWithValue("@p2", parametre.BASDERSID);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }


            int sonuc = komut.ExecuteNonQuery();
            komut.Connection.Close();

            return sonuc;
        }

        public static int ToplamOgrenciSayisi()
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM TBLOGRENCI", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open) { komut.Connection.Open(); }
            int sayi = Convert.ToInt32(komut.ExecuteScalar());
            komut.Connection.Close();
            return sayi;
        }

        public static int ToplamDersSayisi()
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM TBLDERS", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open) { komut.Connection.Open(); }
            int sayi = Convert.ToInt32(komut.ExecuteScalar());
            komut.Connection.Close();
            return sayi;
        }

        public static int ToplamBasvuruSayisi()
        {
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM TBLBASVURUFORM", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open) { komut.Connection.Open(); }
            int sayi = Convert.ToInt32(komut.ExecuteScalar());
            komut.Connection.Close();
            return sayi;
        }

        public static List<EntityLayer.EntityDers> GrafikVerisiGetir()
        {
            List<EntityLayer.EntityDers> degerler = new List<EntityLayer.EntityDers>();
            // SQL Sorgusu: Her dersin adını ve o derse ait toplam başvuru sayısını getirir
            SqlCommand komut = new SqlCommand("SELECT DERSAD, (SELECT COUNT(*) FROM TBLBASVURUFORM WHERE DERSID = TBLDERS.DERSID) as Adet FROM TBLDERS", Baglanti.bgl);

            if (komut.Connection.State != ConnectionState.Open) { komut.Connection.Open(); }

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityLayer.EntityDers ent = new EntityLayer.EntityDers();
                ent.DERSAD = dr["DERSAD"].ToString();
                ent.DERSKAYITLISAYISI = int.Parse(dr["Adet"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
