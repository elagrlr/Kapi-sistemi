
namespace WindowsFormsApp2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.durum = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.edit = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.mail = new System.Windows.Forms.Label();
            this.telno = new System.Windows.Forms.Label();
            this.soyadi = new System.Windows.Forms.Label();
            this.adi = new System.Windows.Forms.Label();
            this.kartid = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(918, 482);
            this.dataGridView1.TabIndex = 0;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(143, 234);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(126, 40);
            this.ekle.TabIndex = 1;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Başlat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // durum
            // 
            this.durum.AutoSize = true;
            this.durum.Location = new System.Drawing.Point(41, 57);
            this.durum.Name = "durum";
            this.durum.Size = new System.Drawing.Size(50, 17);
            this.durum.TabIndex = 3;
            this.durum.Text = "Durum";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(44, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Durdur";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.durum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BAĞLANTI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(312, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(976, 518);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TABLO";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.edit);
            this.groupBox3.Controls.Add(this.sil);
            this.groupBox3.Controls.Add(this.mail);
            this.groupBox3.Controls.Add(this.telno);
            this.groupBox3.Controls.Add(this.soyadi);
            this.groupBox3.Controls.Add(this.adi);
            this.groupBox3.Controls.Add(this.kartid);
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.ekle);
            this.groupBox3.Location = new System.Drawing.Point(13, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 373);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "KULLANICI BİLGİ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(6, 291);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(126, 40);
            this.edit.TabIndex = 7;
            this.edit.Text = "Güncelle";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(143, 291);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(126, 39);
            this.sil.TabIndex = 6;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Location = new System.Drawing.Point(7, 193);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(85, 17);
            this.mail.TabIndex = 5;
            this.mail.Text = "Mail Adresi :";
            // 
            // telno
            // 
            this.telno.AutoSize = true;
            this.telno.Location = new System.Drawing.Point(6, 153);
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(86, 17);
            this.telno.TabIndex = 5;
            this.telno.Text = "Telefon No :";
            // 
            // soyadi
            // 
            this.soyadi.AutoSize = true;
            this.soyadi.Location = new System.Drawing.Point(6, 107);
            this.soyadi.Name = "soyadi";
            this.soyadi.Size = new System.Drawing.Size(59, 17);
            this.soyadi.TabIndex = 5;
            this.soyadi.Text = "Soyadı :";
            // 
            // adi
            // 
            this.adi.AutoSize = true;
            this.adi.Location = new System.Drawing.Point(6, 72);
            this.adi.Name = "adi";
            this.adi.Size = new System.Drawing.Size(36, 17);
            this.adi.TabIndex = 5;
            this.adi.Text = "Adı :";
            // 
            // kartid
            // 
            this.kartid.AutoSize = true;
            this.kartid.Location = new System.Drawing.Point(7, 34);
            this.kartid.Name = "kartid";
            this.kartid.Size = new System.Drawing.Size(59, 17);
            this.kartid.TabIndex = 5;
            this.kartid.Text = "Kart ID :";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(111, 188);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(158, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(111, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(158, 22);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(111, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 22);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 22);
            this.textBox2.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 557);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label durum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.Label telno;
        private System.Windows.Forms.Label soyadi;
        private System.Windows.Forms.Label adi;
        private System.Windows.Forms.Label kartid;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button sil;
    }
}