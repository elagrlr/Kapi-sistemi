using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-JAF8PNH\\SQLEXPRESS;Initial Catalog=denemeDB;Integrated Security=True");
            cmd = new SqlCommand("SELECT * FROM yonetici where kullaniciadi=@kullaniciadi AND sifre=@sifre", con);
            cmd.Parameters.AddWithValue("@kullaniciadi", textBox1.Text);
            cmd.Parameters.AddWithValue("@sifre", textBox2.Text);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı.");
                Form2 form2sec = new Form2();
                form2sec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş.");
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
