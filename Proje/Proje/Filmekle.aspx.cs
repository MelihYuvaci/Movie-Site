using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje
{
    public partial class Filmekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string filmAdı = Convert.ToString(TextBox1.Text);
            string filmKategorisi = Convert.ToString(TextBox2.Text);
            string filmYönetmeni = Convert.ToString(TextBox3.Text);
            string filmSenaristi = Convert.ToString(TextBox4.Text);
            FilmIslemleri.YöneticiFilmEkleme(filmAdı, filmKategorisi, filmYönetmeni, filmSenaristi);
            Response.Write("Film Eklendi");
        }
    }
}