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
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlDataAdapter da = new SqlDataAdapter("Select * from Products",
            //    @"server=DESKTOP-IN1QIJK\SQLEXPRESS;Database=Northwind;Integrated Security=True");
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //rptUrunler.DataSource = dt;
            //rptUrunler.DataBind();

            string BaglantiAdresi = "server=DESKTOP-IN1QIJK\\SQLEXPRESS;Database=Northwind;Integrated Security=True";
            SqlConnection con = new SqlConnection(BaglantiAdresi);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Employees";
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Repeater1.DataSource = dr;
            Repeater1.DataBind();
            con.Close();
            dr.Close();
            
        }
            protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Suppliers s = new Suppliers();
            s.ProductName = txtUrunAdi.Text;
            s.SupplersID = Convert.ToInt32(txtSupplierID.Text);
            s.CategoryID = Convert.ToInt32(txtCategoryID.Text);
            s.UnitsInStock = Convert.ToInt32(txtUnitInStock.Text);
            s.UnitPrice = Convert.ToDouble(txtUnitPrice.Text);
            
            s.YeniKayitEkle();
            s.YeniKayitEkle();
           
            //KayitGoster();
        }




    }
    public class Connection
    {
        public SqlConnection con = new SqlConnection("Data Source=DESKTOP-IN1QIJK\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
        public SqlDataAdapter adtr { get; set; }
        public SqlCommand komut { get; set; }

    }
    public class Suppliers
    {
        public int UnitsInStock { get; set; }
        public int SupplersID { get; set; }
        public double UnitPrice { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public virtual void YeniKayitEkle()
        {
            Connection con = new Connection();
            DataTable tablo = new DataTable();
            con.con.Open();
            con.komut = new SqlCommand("psYeniKullaniciEkle", con.con);
            con.komut.CommandType = CommandType.StoredProcedure;
            con.komut.Parameters.AddWithValue("@ProductName", ProductName);
            con.komut.Parameters.AddWithValue("@SupplierID", SupplersID);
            con.komut.Parameters.AddWithValue("@CategoryID", CategoryID);
            con.komut.Parameters.AddWithValue("@UnitsInStock", UnitsInStock);
            con.komut.Parameters.AddWithValue("@UnitPrice", UnitPrice);
            con.komut.ExecuteNonQuery();
            con.con.Close();
        }

    }
}