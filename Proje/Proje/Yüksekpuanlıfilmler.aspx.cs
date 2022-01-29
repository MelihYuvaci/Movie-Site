using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje
{
    public partial class Popülerfilmler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool kontrol = Convert.ToBoolean(Session["giris"]);
            if (kontrol == false)
                Response.Redirect("ogrenciGiris.aspx?msg=Lutfen once giris yapiniz");
            else
            {

                System.Data.DataSet tavsiye = FilmIslemleri.FilmTavsiye();
                GridView1.DataSource = tavsiye.Tables[0];
                GridView1.DataBind();


            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}