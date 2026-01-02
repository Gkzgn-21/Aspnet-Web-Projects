using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer;

public partial class OgrenciKayit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        EntityOgrenci ent = new EntityOgrenci();
        ent.Ad = TxtAd.Text;
        ent.Soyad = TxtSoyad.Text;
        ent.Numara = TxtNumara.Text;
        ent.Sifre = TxtSifre.Text;

        if (FileUpload1.HasFile) // Kullanıcı bir dosya seçti mi?
        {
            // Dosya adını alıp projedeki Images klasörüne yolu oluşturuyoruz
            string dosyaAdi = Path.GetFileName(FileUpload1.FileName);
            string kayitYolu = "~/Images/" + dosyaAdi;

            // Dosyayı sunucuya fiziksel olarak kaydet
            FileUpload1.SaveAs(Server.MapPath(kayitYolu));

            // Veritabanına kaydedilecek dosya yolunu nesneye ata
            ent.Fotograf = kayitYolu;
        }
        else
        {
            // Dosya seçilmediyse varsayılan bir yol atanabilir veya boş bırakılabilir
            ent.Fotograf = "";
        }

        BLLOgrenci.OgrenciEkleBLL(ent);

        Response.Write("<script>alert('Öğrenci Başarıyla Kaydedildi')</script>");
    }
}