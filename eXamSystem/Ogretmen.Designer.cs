namespace eXamSystem
{
    partial class Ogretmen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogretmen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCıkıs = new System.Windows.Forms.Button();
            this.btnSoruSil = new System.Windows.Forms.Button();
            this.btnSoruEkle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlSoruEkle = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblCevap = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.lblkonuAd = new System.Windows.Forms.Label();
            this.txtkonuAd = new System.Windows.Forms.TextBox();
            this.lbldersAdi = new System.Windows.Forms.Label();
            this.txtdersAd = new System.Windows.Forms.TextBox();
            this.lbluniteAd = new System.Windows.Forms.Label();
            this.txtuniteAd = new System.Windows.Forms.TextBox();
            this.lblsinifDuzeyi = new System.Windows.Forms.Label();
            this.txtsinifDuzeyi = new System.Windows.Forms.TextBox();
            this.lblsoruNo = new System.Windows.Forms.Label();
            this.txtsoruNo = new System.Windows.Forms.TextBox();
            this.lblkonuNo = new System.Windows.Forms.Label();
            this.txtkonuNo = new System.Windows.Forms.TextBox();
            this.lbluniteNo = new System.Windows.Forms.Label();
            this.txtunıteNo = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSoruEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btnCıkıs);
            this.panel1.Controls.Add(this.btnSoruSil);
            this.panel1.Controls.Add(this.btnSoruEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 722);
            this.panel1.TabIndex = 0;
            // 
            // btnCıkıs
            // 
            this.btnCıkıs.BackColor = System.Drawing.Color.Brown;
            this.btnCıkıs.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCıkıs.ForeColor = System.Drawing.Color.PeachPuff;
            this.btnCıkıs.Location = new System.Drawing.Point(3, 589);
            this.btnCıkıs.Name = "btnCıkıs";
            this.btnCıkıs.Size = new System.Drawing.Size(198, 95);
            this.btnCıkıs.TabIndex = 7;
            this.btnCıkıs.Text = "Çıkış Yap";
            this.btnCıkıs.UseVisualStyleBackColor = false;
            this.btnCıkıs.Click += new System.EventHandler(this.btnCıkıs_Click);
            // 
            // btnSoruSil
            // 
            this.btnSoruSil.BackColor = System.Drawing.Color.Firebrick;
            this.btnSoruSil.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoruSil.ForeColor = System.Drawing.Color.White;
            this.btnSoruSil.Location = new System.Drawing.Point(0, 376);
            this.btnSoruSil.Name = "btnSoruSil";
            this.btnSoruSil.Size = new System.Drawing.Size(198, 106);
            this.btnSoruSil.TabIndex = 4;
            this.btnSoruSil.Text = "Soru Silme";
            this.btnSoruSil.UseVisualStyleBackColor = false;
            this.btnSoruSil.Click += new System.EventHandler(this.btnSoruSil_Click);
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.BackColor = System.Drawing.Color.Firebrick;
            this.btnSoruEkle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSoruEkle.ForeColor = System.Drawing.Color.White;
            this.btnSoruEkle.Location = new System.Drawing.Point(0, 166);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(198, 103);
            this.btnSoruEkle.TabIndex = 2;
            this.btnSoruEkle.Text = "Soru Ekle";
            this.btnSoruEkle.UseVisualStyleBackColor = false;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 160);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hoş Geldiniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "● Öğretmen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(573, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 44);
            this.label4.TabIndex = 2;
            this.label4.Text = "HOŞ GELDİNİZ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(555, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(358, 44);
            this.label5.TabIndex = 3;
            this.label5.Text = "SORU SİSTEMİNE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(433, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(693, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bu bölümde soru ekleyip çıkarabilir soru silebilirsin";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1206, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(34, 38);
            this.button7.TabIndex = 6;
            this.button7.Text = "X";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlSoruEkle
            // 
            this.pnlSoruEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSoruEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSoruEkle.BackgroundImage")));
            this.pnlSoruEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSoruEkle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSoruEkle.Controls.Add(this.button1);
            this.pnlSoruEkle.Controls.Add(this.btnKaydet);
            this.pnlSoruEkle.Controls.Add(this.btnEkle);
            this.pnlSoruEkle.Controls.Add(this.lblCevap);
            this.pnlSoruEkle.Controls.Add(this.txtCevap);
            this.pnlSoruEkle.Controls.Add(this.lblkonuAd);
            this.pnlSoruEkle.Controls.Add(this.txtkonuAd);
            this.pnlSoruEkle.Controls.Add(this.lbldersAdi);
            this.pnlSoruEkle.Controls.Add(this.txtdersAd);
            this.pnlSoruEkle.Controls.Add(this.lbluniteAd);
            this.pnlSoruEkle.Controls.Add(this.txtuniteAd);
            this.pnlSoruEkle.Controls.Add(this.lblsinifDuzeyi);
            this.pnlSoruEkle.Controls.Add(this.txtsinifDuzeyi);
            this.pnlSoruEkle.Controls.Add(this.lblsoruNo);
            this.pnlSoruEkle.Controls.Add(this.txtsoruNo);
            this.pnlSoruEkle.Controls.Add(this.lblkonuNo);
            this.pnlSoruEkle.Controls.Add(this.txtkonuNo);
            this.pnlSoruEkle.Controls.Add(this.lbluniteNo);
            this.pnlSoruEkle.Controls.Add(this.txtunıteNo);
            this.pnlSoruEkle.Controls.Add(this.pictureBox2);
            this.pnlSoruEkle.Location = new System.Drawing.Point(0, 0);
            this.pnlSoruEkle.Name = "pnlSoruEkle";
            this.pnlSoruEkle.Size = new System.Drawing.Size(1264, 722);
            this.pnlSoruEkle.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(72, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 41);
            this.button1.TabIndex = 20;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(1001, 337);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(170, 62);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.ForeColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(96, 331);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(170, 62);
            this.btnEkle.TabIndex = 17;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.BackColor = System.Drawing.Color.Transparent;
            this.lblCevap.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCevap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCevap.Location = new System.Drawing.Point(644, 650);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(98, 28);
            this.lblCevap.TabIndex = 16;
            this.lblCevap.Text = "Cevap :";
            // 
            // txtCevap
            // 
            this.txtCevap.BackColor = System.Drawing.Color.Gray;
            this.txtCevap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCevap.ForeColor = System.Drawing.Color.White;
            this.txtCevap.Location = new System.Drawing.Point(768, 651);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(244, 32);
            this.txtCevap.TabIndex = 15;
            this.txtCevap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblkonuAd
            // 
            this.lblkonuAd.AutoSize = true;
            this.lblkonuAd.BackColor = System.Drawing.Color.Transparent;
            this.lblkonuAd.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkonuAd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblkonuAd.Location = new System.Drawing.Point(628, 584);
            this.lblkonuAd.Name = "lblkonuAd";
            this.lblkonuAd.Size = new System.Drawing.Size(128, 28);
            this.lblkonuAd.TabIndex = 14;
            this.lblkonuAd.Text = "Konu Adı:";
            // 
            // txtkonuAd
            // 
            this.txtkonuAd.BackColor = System.Drawing.Color.Gray;
            this.txtkonuAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkonuAd.ForeColor = System.Drawing.Color.White;
            this.txtkonuAd.Location = new System.Drawing.Point(768, 584);
            this.txtkonuAd.Name = "txtkonuAd";
            this.txtkonuAd.Size = new System.Drawing.Size(244, 32);
            this.txtkonuAd.TabIndex = 13;
            this.txtkonuAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbldersAdi
            // 
            this.lbldersAdi.AutoSize = true;
            this.lbldersAdi.BackColor = System.Drawing.Color.Transparent;
            this.lbldersAdi.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldersAdi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbldersAdi.Location = new System.Drawing.Point(644, 517);
            this.lbldersAdi.Name = "lbldersAdi";
            this.lbldersAdi.Size = new System.Drawing.Size(121, 28);
            this.lbldersAdi.TabIndex = 12;
            this.lbldersAdi.Text = "Ders Adı:";
            // 
            // txtdersAd
            // 
            this.txtdersAd.BackColor = System.Drawing.Color.Gray;
            this.txtdersAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdersAd.ForeColor = System.Drawing.Color.White;
            this.txtdersAd.Location = new System.Drawing.Point(768, 513);
            this.txtdersAd.Name = "txtdersAd";
            this.txtdersAd.Size = new System.Drawing.Size(244, 32);
            this.txtdersAd.TabIndex = 11;
            this.txtdersAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbluniteAd
            // 
            this.lbluniteAd.AutoSize = true;
            this.lbluniteAd.BackColor = System.Drawing.Color.Transparent;
            this.lbluniteAd.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluniteAd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbluniteAd.Location = new System.Drawing.Point(624, 453);
            this.lbluniteAd.Name = "lbluniteAd";
            this.lbluniteAd.Size = new System.Drawing.Size(132, 28);
            this.lbluniteAd.TabIndex = 10;
            this.lbluniteAd.Text = "Unite Adı:";
            // 
            // txtuniteAd
            // 
            this.txtuniteAd.BackColor = System.Drawing.Color.Gray;
            this.txtuniteAd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtuniteAd.ForeColor = System.Drawing.SystemColors.Window;
            this.txtuniteAd.Location = new System.Drawing.Point(768, 449);
            this.txtuniteAd.Name = "txtuniteAd";
            this.txtuniteAd.Size = new System.Drawing.Size(244, 32);
            this.txtuniteAd.TabIndex = 9;
            this.txtuniteAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblsinifDuzeyi
            // 
            this.lblsinifDuzeyi.AutoSize = true;
            this.lblsinifDuzeyi.BackColor = System.Drawing.Color.Transparent;
            this.lblsinifDuzeyi.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsinifDuzeyi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsinifDuzeyi.Location = new System.Drawing.Point(105, 650);
            this.lblsinifDuzeyi.Name = "lblsinifDuzeyi";
            this.lblsinifDuzeyi.Size = new System.Drawing.Size(161, 28);
            this.lblsinifDuzeyi.TabIndex = 8;
            this.lblsinifDuzeyi.Text = "Sınıf Duzeyi:";
            // 
            // txtsinifDuzeyi
            // 
            this.txtsinifDuzeyi.BackColor = System.Drawing.Color.Gray;
            this.txtsinifDuzeyi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsinifDuzeyi.ForeColor = System.Drawing.Color.White;
            this.txtsinifDuzeyi.Location = new System.Drawing.Point(277, 651);
            this.txtsinifDuzeyi.Name = "txtsinifDuzeyi";
            this.txtsinifDuzeyi.Size = new System.Drawing.Size(244, 32);
            this.txtsinifDuzeyi.TabIndex = 7;
            this.txtsinifDuzeyi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblsoruNo
            // 
            this.lblsoruNo.AutoSize = true;
            this.lblsoruNo.BackColor = System.Drawing.Color.Transparent;
            this.lblsoruNo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsoruNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsoruNo.Location = new System.Drawing.Point(153, 584);
            this.lblsoruNo.Name = "lblsoruNo";
            this.lblsoruNo.Size = new System.Drawing.Size(113, 28);
            this.lblsoruNo.TabIndex = 6;
            this.lblsoruNo.Text = "Soru No:";
            // 
            // txtsoruNo
            // 
            this.txtsoruNo.BackColor = System.Drawing.Color.Gray;
            this.txtsoruNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsoruNo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtsoruNo.Location = new System.Drawing.Point(277, 584);
            this.txtsoruNo.Name = "txtsoruNo";
            this.txtsoruNo.Size = new System.Drawing.Size(244, 32);
            this.txtsoruNo.TabIndex = 5;
            this.txtsoruNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblkonuNo
            // 
            this.lblkonuNo.AutoSize = true;
            this.lblkonuNo.BackColor = System.Drawing.Color.Transparent;
            this.lblkonuNo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkonuNo.ForeColor = System.Drawing.Color.White;
            this.lblkonuNo.Location = new System.Drawing.Point(153, 517);
            this.lblkonuNo.Name = "lblkonuNo";
            this.lblkonuNo.Size = new System.Drawing.Size(121, 28);
            this.lblkonuNo.TabIndex = 4;
            this.lblkonuNo.Text = "Konu No:";
            // 
            // txtkonuNo
            // 
            this.txtkonuNo.BackColor = System.Drawing.Color.Gray;
            this.txtkonuNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkonuNo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtkonuNo.Location = new System.Drawing.Point(277, 517);
            this.txtkonuNo.Name = "txtkonuNo";
            this.txtkonuNo.Size = new System.Drawing.Size(244, 32);
            this.txtkonuNo.TabIndex = 3;
            this.txtkonuNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbluniteNo
            // 
            this.lbluniteNo.AutoSize = true;
            this.lbluniteNo.BackColor = System.Drawing.Color.Transparent;
            this.lbluniteNo.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbluniteNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbluniteNo.Location = new System.Drawing.Point(153, 453);
            this.lbluniteNo.Name = "lbluniteNo";
            this.lbluniteNo.Size = new System.Drawing.Size(125, 28);
            this.lbluniteNo.TabIndex = 2;
            this.lbluniteNo.Text = "Unite No:";
            // 
            // txtunıteNo
            // 
            this.txtunıteNo.BackColor = System.Drawing.Color.Gray;
            this.txtunıteNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtunıteNo.ForeColor = System.Drawing.SystemColors.Window;
            this.txtunıteNo.Location = new System.Drawing.Point(277, 453);
            this.txtunıteNo.Name = "txtunıteNo";
            this.txtunıteNo.Size = new System.Drawing.Size(244, 32);
            this.txtunıteNo.TabIndex = 1;
            this.txtunıteNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(318, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(655, 368);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Ogretmen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1262, 722);
            this.ControlBox = false;
            this.Controls.Add(this.pnlSoruEkle);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ogretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ogretmen";
            this.Load += new System.EventHandler(this.Ogretmen_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlSoruEkle.ResumeLayout(false);
            this.pnlSoruEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSoruEkle;
        private System.Windows.Forms.Button btnSoruSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCıkıs;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel pnlSoruEkle;
        private System.Windows.Forms.TextBox txtunıteNo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbluniteNo;
        private System.Windows.Forms.Label lblsinifDuzeyi;
        private System.Windows.Forms.TextBox txtsinifDuzeyi;
        private System.Windows.Forms.Label lblsoruNo;
        private System.Windows.Forms.TextBox txtsoruNo;
        private System.Windows.Forms.Label lblkonuNo;
        private System.Windows.Forms.TextBox txtkonuNo;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Label lblkonuAd;
        private System.Windows.Forms.TextBox txtkonuAd;
        private System.Windows.Forms.Label lbldersAdi;
        private System.Windows.Forms.TextBox txtdersAd;
        private System.Windows.Forms.Label lbluniteAd;
        private System.Windows.Forms.TextBox txtuniteAd;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}