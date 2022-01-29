using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje
{
    public partial class Filmepuanverme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                bool kontrol = Convert.ToBoolean(Session["giris"]);
                if (kontrol == false)
                    Response.Redirect("giriş.aspx?msg=Lutfen once giris yapiniz");
                else
                {
                    string arananKelime = Convert.ToString(TextBox1.Text);
                    System.Data.DataSet ds = FilmIslemleri.filmArama(arananKelime);
                    GridView1.DataSource = ds.Tables[0];
                    GridView1.DataBind();
                }
            }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string filmAdı = Convert.ToString(TextBox1.Text);
            string filmKategorisi = Convert.ToString(TextBox2.Text);
            string filmYönetmeni = Convert.ToString(TextBox3.Text);
            string filmSenaristi = Convert.ToString(TextBox4.Text);
            int filmPuanı = Convert.ToInt32(TextBox5.Text);
            FilmIslemleri.PuanVer(filmAdı, filmKategorisi, filmYönetmeni, filmSenaristi, filmPuanı);
            Response.Write("Puan verildi");
        }
    }
    }
