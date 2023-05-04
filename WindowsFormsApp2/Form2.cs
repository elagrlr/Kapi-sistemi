using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        private string data;
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        SqlDataReader dr;
        SqlCommandBuilder cmdb;
        void Griddoldur()
        {
            con = new SqlConnection("Data Source=DESKTOP-JAF8PNH\\SQLEXPRESS;Initial Catalog=denemeDB;Integrated Security=True");
            da = new SqlDataAdapter("Select *From kartbilgi", con);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "kartbilgi");
            dataGridView1.DataSource = ds.Tables["kartbilgi"];
            con.Close();

        }


        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadExisting();                     //Veriyi al
            this.Invoke(new EventHandler(DisplayData_event));
        }

        private void DisplayData_event(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {  //Gelen değeri ProgressBar'ın değerine eşitle
                textBox1.Text += data; //Gelen veriyi textBox içine güncel zaman ile ekle
            }
            else {
                textBox1.Clear();
                textBox1.Text += data;
            }  
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();    //Seri port açıksa kapat
        }
        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Close();           //textBox1'i sıfırla
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Griddoldur();
            textBox1.ReadOnly = true;                    //textBox1'i yalnızca okunabilir şekilde ayarla
            string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
            foreach (string port in ports)
                comboBox1.Items.Add(port);               //Seri portları comboBox1'e ekleme

            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived); //DataReceived eventini oluşturma
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            try { 
            con = new SqlConnection("Data Source=DESKTOP-JAF8PNH\\SQLEXPRESS;Initial Catalog=denemeDB;Integrated Security=True");
                con.Open();
                if (!_kaydedilsinmi)
                {
                    MessageBox.Show("Bu kayıt veritabanında zaten var.");
                    return;
                }

                cmd = new SqlCommand("insert into  kartbilgi " +
                    " (kartid,adi,soyadi,telno,email)values" +
                    " ( @kartid,@adi,@soyadi,@telno,@email )", con);
                
              
                    cmd.Parameters.AddWithValue("@kartid", textBox1.Text);
                    cmd.Parameters.AddWithValue("@adi", textBox2.Text);
                    cmd.Parameters.AddWithValue("@soyadi", textBox3.Text);
                    cmd.Parameters.AddWithValue("@telno", textBox4.Text);
                    cmd.Parameters.AddWithValue("@email", textBox5.Text);
               
                dr = cmd.ExecuteReader();
                    MessageBox.Show("Ekleme Başarılı.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                
            }
          catch(Exception ex)
            {
                MessageBox.Show("Ekleme Başarısız..");
            }
        



            Griddoldur();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort1.PortName = comboBox1.Text;  //ComboBox1'de seçili nesneyi port ismine ata
                serialPort1.BaudRate = 9600;            //BaudRate 9600 olarak ayarla
                serialPort1.Open();                     //Seri portu aç
                durum.Text = "Bağlandı";                      //Başlatma butonunu pasif hale getir
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");    //Hata mesajı göster
            }
        }
        void KayıtSil(int id)
        {
            string sql = "DELETE FROM kartbilgi WHERE id=@id";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        private void sil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(id);
            }
            Griddoldur();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            da.Update(ds, "kartbilgi");
            MessageBox.Show("Kayıt güncellendi");
           
            Griddoldur();
            //

        }
        private bool _kaydedilsinmi;
        private void textBox1_Leave(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select * from kartbilgi where kartid=@kartid", con);

            komut.Parameters.AddWithValue("@kartid", textBox1.Text);
            if (Convert.ToInt32(komut.ExecuteScalar()) > 0)
            {
                MessageBox.Show("Bu kayıt veritabanında zaten var.");
            }
            else
            {
                _kaydedilsinmi = true;
            }
            con.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}