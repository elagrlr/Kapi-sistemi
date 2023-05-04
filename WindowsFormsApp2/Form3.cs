using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        private bool _kaydedilsinmi;
        private string data;
        string text;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;                    //textBox1'i yalnızca okunabilir şekilde ayarla
            string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
            foreach (string port in ports)
                comboBox1.Items.Add(port);
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived); //DataReceived eventini oluşturma
            
        }
        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort1.ReadExisting();                     //Veriyi al
            this.Invoke(new EventHandler(DisplayData_event));
        }
        private void DisplayData_event(object sender, EventArgs e)
        {
            textBox1.Text = data;
            con = new SqlConnection("Data Source=DESKTOP-JAF8PNH\\SQLEXPRESS;Initial Catalog=denemeDB;Integrated Security=True");
            cmd = new SqlCommand("SELECT * FROM kartbilgi where kartid=@kartid", con);
            cmd.Parameters.AddWithValue("@kartid", textBox1.Text);
          
            con.Open();
            dr = cmd.ExecuteReader();

           
            if (dr.Read())
            {
               
                textBox2.Text = dr["adi"].ToString();
                textBox3.Text = dr["soyadi"].ToString();
            
                text = textBox2.Text + "" + textBox3.Text;
                serialPort1.Write("1");
               
            }
            else
            {
                serialPort1.Write("0");

            }
            con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

            serialPort1.Close();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            Form1 form1sec = new Form1();
            form1sec.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
    }
    


