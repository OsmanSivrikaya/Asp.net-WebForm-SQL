using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class SiparisGir : System.Web.UI.Page
    {
        veri v = new veri();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            if (!IsPostBack)
            {
                PersonelGetir();
                MusteriGetir();
            }
            v.EmployeeID = Convert.ToInt32(drop1.SelectedValue);
            v.CustomerID = drop2.SelectedValue.ToString();
        }
        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            OrdersEkle();
        }
        public void PersonelGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Employees",
                @"server=DESKTOP-IN1QIJK\SQLEXPRESS;Database=Northwind;Integrated Security=True");
            DataTable dt = new DataTable();
            da.Fill(dt);
            drop1.DataSource = dt;
            drop1.DataValueField = "EmployeeID";
            drop1.DataTextField = "FirstName";
            drop1.DataBind();
        }
        public void MusteriGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Customers ",
                @"server=DESKTOP-IN1QIJK\SQLEXPRESS;Database=Northwind;Integrated Security=True");
            DataTable dt = new DataTable();
            da.Fill(dt);
            drop2.DataSource = dt;
            drop2.DataValueField = "CustomerID";
            drop2.DataTextField = "CompanyName";
            drop2.DataBind();
        }
        static string conString = "server=DESKTOP-IN1QIJK\\SQLEXPRESS;Database=Northwind;Integrated Security=True;";

        SqlConnection baglanti = new SqlConnection(conString);
        public void OrdersEkle()
        {
            //Connection1 con = new Connection1();
            //DataTable tablo = new DataTable();
            //con.con.Open();
            baglanti.Open();
            // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
            string kayit = "insert into Orders(CustomerID,EmployeeID,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry) values (@CustomerID,@EmployeeID,@ShipVia,@Freight,@ShipName,@ShipAddress,@ShipCity,@ShipRegion,@ShipPostalCode,@ShipCountry)";
            // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            //SqlCommand komut = newSqlCommand(kayit, baglanti);
            //con.komut = new SqlCommand("insert into Orders(CustomerID,EmployeeID,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry) values (@CustomerID,@EmployeeID,@ShipVia,@Freight,@ShipName,@ShipAddress,@ShipCity,@ShipRegion,@ShipPostalCode,@ShipCountry) ", con.con);
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            komut.Parameters.AddWithValue("@CustomerID", v.CustomerID);
            komut.Parameters.AddWithValue("@EmployeeID", v.EmployeeID);
            komut.Parameters.AddWithValue("@ShipVia", Convert.ToInt32(txt1.Text));
            komut.Parameters.AddWithValue("@Freight", Convert.ToDouble(txt2.Text));
            komut.Parameters.AddWithValue("@ShipName", txt3.Text.ToString());
            komut.Parameters.AddWithValue("@ShipAddress", txt4.Text.ToString());
            komut.Parameters.AddWithValue("@ShipCity", txt5.Text.ToString());
            komut.Parameters.AddWithValue("@ShipRegion", txt6.Text.ToString());
            komut.Parameters.AddWithValue("@ShipPostalCode", txt7.Text.ToString());
            komut.Parameters.AddWithValue("@ShipCountry", txt8.Text.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        class veri
        {
            public int EmployeeID { get; set; }
            public string CustomerID { get; set; }
        }

    }
    public class Connection1
    {
        public SqlConnection con = new SqlConnection("server=DESKTOP-IN1QIJK\\SQLEXPRESS;Database=Northwind;Integrated Security=True");
        public SqlDataAdapter adtr { get; set; }
        public SqlCommand komut { get; set; }

    }
}