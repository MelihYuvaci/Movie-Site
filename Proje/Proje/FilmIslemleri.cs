using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Proje
{
    public class FilmIslemleri
    {
        static string baglantı= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Melih\Desktop\Film Sitesi Proje Ödevi\FilmSitesi.mdf;Integrated Security=True;Connect Timeout=30";
        static SqlConnection baglantiYolu = new SqlConnection(baglantı);

        public static bool girisYap(string KullanıcıAdı, string Şifre)
        {
            string sql = "select * from Kullanıcılar where KullanıcıAdı=@pKul and Şifre=@pŞfr";
            SqlCommand komut = new SqlCommand(sql, baglantiYolu);
            komut.Parameters.AddWithValue("@pkul", KullanıcıAdı);
            komut.Parameters.AddWithValue("@pŞfr", Şifre);
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            baglantiYolu.Open();
            adaptor.Fill(ds);
            baglantiYolu.Close();
            bool sonuc = false;
            if (ds.Tables[0].Rows.Count > 0)
                sonuc = true;
            return sonuc;
        }
        public static DataSet filmArama(string arananKelime)
        {
            string komutStr = @"select Filmadı,FilmKategorisi,FilmYönetmeni,FilmSenaristi from Filmler where Filmadı like '%' + @arananKelime + '%' ";
            SqlCommand komut = new SqlCommand(komutStr, baglantiYolu);
            komut.Parameters.AddWithValue("@arananKelime", arananKelime);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = komut;
            DataSet aramads = new DataSet();
            baglantiYolu.Open();
            adapter.Fill(aramads);
            baglantiYolu.Close();
            return aramads;
        }
        public static DataSet kullanıcıArama(string arananKelime)
        {
            string sql = @"select KullanıcıAdı,Adı,Soyadı from Kullanıcılar where Adı like '%' + @arananKelime + '%' ";
            SqlCommand komut = new SqlCommand(sql, baglantiYolu);
            komut.Parameters.AddWithValue("@arananKelime", arananKelime);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = komut;
            DataSet aramads = new DataSet();
            baglantiYolu.Open();
            adapter.Fill(aramads);
            baglantiYolu.Close();
            return aramads;
        }
        public static DataSet senaristArama(string arananKelime)
        {
            string sql = @"select Adı,Soyadı,Filmadı,Kategori from Senarist where Adı like '%' + @arananKelime + '%' ";
            SqlCommand sqlkomut = new SqlCommand(sql, baglantiYolu);
            sqlkomut.Parameters.AddWithValue("@arananKelime", arananKelime);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlkomut;
            DataSet aramads = new DataSet();
            baglantiYolu.Open();
            adapter.Fill(aramads);
            baglantiYolu.Close();
            return aramads;
        }
        public static DataSet yönetmenArama(string arananKelime)
        {
            string sql = @"select Adı,Soyadı,Filmadı,Kategori from Yönetmen where Adı like '%' + @arananKelime + '%' ";
            SqlCommand sqlkomutu = new SqlCommand(sql, baglantiYolu);
            sqlkomutu.Parameters.AddWithValue("@arananKelime", arananKelime);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlkomutu;
            DataSet aramads = new DataSet();
            baglantiYolu.Open();
            adapter.Fill(aramads);
            baglantiYolu.Close();
            return aramads;
        }
        public static DataSet kategorileriCek()
        {
            string sql = "select * from kategoriler ";
            SqlCommand cmd = new SqlCommand(sql, baglantiYolu);
            SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
            DataSet kategorilerDS = new DataSet();
            baglantiYolu.Open();
            adaptor.Fill(kategorilerDS);
            baglantiYolu.Close();
            return kategorilerDS;
        }
        public static void PuanVer( string filmAdı,string filmKategorisi,string filmyönetmeni,string filmsenaristi, int puan)
        {
            string commandStr = "INSERT INTO FilmPuanı(Filmadı,Filmkategorisi,Filmyönetmeni,Filmsenaristi,Filmpuanı) values (@pFad,@pFktgr,@pFyntmn,@pFsnrst,@pFpuan)";
            SqlCommand command = new SqlCommand(commandStr, baglantiYolu);
            command.Parameters.AddWithValue("@pFad", filmAdı);
            command.Parameters.AddWithValue("@pFktgr",filmKategorisi);
            command.Parameters.AddWithValue("@pFyntmn", filmyönetmeni);
            command.Parameters.AddWithValue("@pFsnrst", filmsenaristi);
            command.Parameters.AddWithValue("@pFpuan", puan);
            baglantiYolu.Open();
            command.ExecuteNonQuery();
            baglantiYolu.Close();
        }
        public static bool YoneticiGirisYap(string tc, string sifre)
        {
            string sql = "select * from YöneticiGiriş where Tckimlikno=@pTc and şifre=@pŞfr";
            SqlCommand komut = new SqlCommand(sql, baglantiYolu);
            komut.Parameters.AddWithValue("@pTc", tc);
            komut.Parameters.AddWithValue("@pŞfr", sifre);
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            DataSet yöneticiDS = new DataSet();
            baglantiYolu.Open();
            adaptor.Fill(yöneticiDS);
            baglantiYolu.Close();
            bool sonuc = false;
            if (yöneticiDS.Tables[0].Rows.Count > 0)
                sonuc = true;
            return sonuc;
        }
        public static void YöneticiFilmEkleme(string filmAdı,string filmKategorisi,string filmYönetmeni,string filmSenaristi)
        {
            string sql = "insert into Filmler(Filmadı,Filmkategorisi,Filmyönetmeni,Filmsenaristi) values (@pAd,@pKatgr,@pYöntmn,@pSenarst)";
            SqlCommand komut = new SqlCommand(sql, baglantiYolu);
            komut.Parameters.AddWithValue("@pAd", filmAdı);
            komut.Parameters.AddWithValue("@pKatgr", filmKategorisi);
            komut.Parameters.AddWithValue("@pYöntmn", filmYönetmeni);
            komut.Parameters.AddWithValue("@pSenarst", filmSenaristi);
            baglantiYolu.Open();
            komut.ExecuteNonQuery();
            baglantiYolu.Close();
        }
        public static void YöneticiKayıtEkleme(string kullanıcıAdı,string Adı,string soyAdı,string şifre)
        {
            string sql = "insert into Kullanıcılar (KullanıcıAdı,Adı,Soyadı,Şifre) values (@pklncAD,@pAdı,@pSadı,@pşfr)";
            SqlCommand komut = new SqlCommand(sql, baglantiYolu);
            komut.Parameters.AddWithValue("@pklncAD", kullanıcıAdı);
            komut.Parameters.AddWithValue("@pAdı", Adı);
            komut.Parameters.AddWithValue("@pSadı", soyAdı);
            komut.Parameters.AddWithValue("@pşfr", şifre);
            baglantiYolu.Open();
            komut.ExecuteNonQuery();
            baglantiYolu.Close();
        }
        public static DataSet FilmTavsiye()
        {
            string sql = "select * from FilmPuanı order by Filmpuanı desc";
            SqlCommand komut = new SqlCommand(sql, baglantiYolu);
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            DataSet filmTavsiyeDS = new DataSet();
            baglantiYolu.Open();
            adaptor.Fill(filmTavsiyeDS);
            baglantiYolu.Close();
            return filmTavsiyeDS;
        }
    }
}