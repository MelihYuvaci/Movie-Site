﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Proje
{
    public partial class Filmarama1 : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}