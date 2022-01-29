using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proje
{
    public partial class Yöneticigiriş : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string TcKimlik = Convert.ToString(TextBox1.Text);
            string Sifre = Convert.ToString(TextBox2.Text);

            bool sessionCtrl = FilmIslemleri.YoneticiGirisYap(TcKimlik, Sifre);

            if (sessionCtrl == false)
                Response.Write("Yanlis kullanıcı adı ve/veya sifre");
            else
            {

                Session["isLoggedasAdmin"] = true;
                Session["TcKimlik"] = TcKimlik;
                Response.Redirect("Yöneticimenü.aspx?");
            }
        }
    }
}

    
