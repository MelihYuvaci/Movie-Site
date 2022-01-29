using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje
{
    public partial class Kullanıcıarama : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool kontrol = Convert.ToBoolean(Session["giris"]);
            if (kontrol == false)
                Response.Redirect("giriş.aspx?msg=Lutfen once giris yapiniz");
            else
            {
                string arananKelime = Convert.ToString(TextBox1.Text);
                System.Data.DataSet ds = FilmIslemleri.kullanıcıArama(arananKelime);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
        }
    }
}