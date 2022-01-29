using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje
{
    public partial class giriş : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = Convert.ToString(TextBox1.Text);
            string Sifre = TextBox2.Text;

            bool sessionCtrl =FilmIslemleri.girisYap(KullaniciAdi, Sifre);

            if (sessionCtrl == false)
                Response.Write("Yanlis kullanıcı adı veya sifre");
            else
            {

                Session["giris"] = true;
                Session["KullaniciAdi"] = KullaniciAdi;
                Response.Redirect("Menü.aspx?");
            }
        }
    }
}