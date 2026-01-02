using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer;

public partial class Kontenjanlar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
    {
            List<EntityDers> dersListe = BLLDers.BllKontenjanListele();
            Repeater1.DataSource = dersListe;
            Repeater1.DataBind();
        }
    }
}