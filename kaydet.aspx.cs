using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class kaydet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string yazar = Request.Form["TextBox1"].ToString();
        string baslik = Request.Form["TextBox2"].ToString();
        string mesaj = Request.Form["TextBox3"].ToString();

        // baglanti nesnesi
        string b_metni = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection baglanti = new SqlConnection(b_metni);

        // Komut nesnesi eklendi
        string sql = "INSERT INTO mesajlar (mesaj_yazan, mesaj_baslik, mesaj, mesaj_tarihi) ";
        sql += "VALUES(@yazar, @baslik, @mesaj, @tarih)";
        SqlCommand sql_komutu = new SqlCommand(sql, baglanti);
        sql_komutu.Parameters.Add("@yazar", SqlDbType.VarChar, 150).Value = yazar;
        sql_komutu.Parameters.Add("@baslik", SqlDbType.VarChar, 150).Value = baslik;
        sql_komutu.Parameters.Add("@mesaj", SqlDbType.Text,500).Value = mesaj;
        sql_komutu.Parameters.Add("@tarih", SqlDbType.DateTime).Value = DateTime.Now;
        sql_komutu.CommandType = CommandType.Text;
        baglanti.Open();
        sql_komutu.ExecuteNonQuery();
    }
}