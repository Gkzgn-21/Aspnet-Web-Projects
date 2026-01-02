using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccessLayer;
using BusinessLogicLayer;

public partial class _Default : System.Web.UI.Page
{
    public string dersAdlari = "";
    public string dersBasvuruSayilari = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            List<int> veriler = BLLDers.IstatistikGetir();
            lblOgr.Text = veriler[0].ToString();
            lblDers.Text = veriler[1].ToString();
            lblBasvuru.Text = veriler[2].ToString();

            List<EntityLayer.EntityDers> grafikListesi = DALDers.GrafikVerisiGetir();
            foreach (var item in grafikListesi)
            {
                dersAdlari += "'" + item.DERSAD + "',";
                dersBasvuruSayilari += item.DERSKAYITLISAYISI + ",";
            }
            dersAdlari = dersAdlari.TrimEnd(',');
            dersBasvuruSayilari = dersBasvuruSayilari.TrimEnd(',');
        }
    }

   
}