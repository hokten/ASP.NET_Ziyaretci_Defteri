using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class oku : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string b_metni = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection baglanti = new SqlConnection(b_metni);
        string sql = "SELECT * FROM mesajlar";
        SqlCommand sql_komutu = new SqlCommand(sql, baglanti);
        baglanti.Open();
        SqlDataReader oku = sql_komutu.ExecuteReader();
        while (oku.Read())
        {
            TableRow ustsatir = new TableRow();
            Table1.Rows.Add(ustsatir);
            TableCell hucremesaj = new TableCell();
            hucremesaj.Text = oku["mesaj"].ToString();
            hucremesaj.ColumnSpan = 2;
            ustsatir.Cells.Add(hucremesaj);
            TableRow satir = new TableRow();
            Table1.Rows.Add(satir);
            satir.Attributes["style"] = "border-bottom:1px solid black";
            TableCell hucresol = new TableCell();
            hucresol.Text = "Yazan : " + oku["mesaj_yazan"].ToString();
            hucresol.Style.Add("padding-bottom", "15px");
            satir.Cells.Add(hucresol);
            TableCell hucresag = new TableCell();
            hucresag.Style.Add("padding-bottom", "15px");
            hucresag.Text = "Tarih : " + oku["mesaj_tarihi"].ToString();
            hucresag.Attributes["align"] = "right";
            satir.Cells.Add(hucresag);
         
        }
    }
}