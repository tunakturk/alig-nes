using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dlete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Sorgula(string tabloAd)
        {
            SqlConnection baglanti = new SqlConnection();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Ürünler";
            SqlDataAdapter adapter = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            baglanti.Open();
            adapter.Fill(ds, "Ürünler");
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString =
                @"Data Source=(local)\SQLEXPRESS;"+"Database=Bahçeişleri_;"+"Integrated Security=true";
            




        }

    }
}
