using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje
{
    public partial class Kayıtekle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string kullanıcıAdı = Convert.ToString(TextBox1.Text);
            string Adı = Convert.ToString(TextBox2.Text);
            string SoyAdı = Convert.ToString(TextBox3.Text);
            string şifre = Convert.ToString(TextBox4.Text);
            FilmIslemleri.YöneticiKayıtEkleme(kullanıcıAdı, Adı, SoyAdı, şifre);
            Response.Write("Kayıt Eklendi");
        }
    }
}