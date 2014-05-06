namespace WindowsFormsApplication8
{
    partial class Form1
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
            this.lbAranzmani = new System.Windows.Forms.ListBox();
            this.lbRezervacii = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.tbVremetraenje = new System.Windows.Forms.TextBox();
            this.tbDrzava = new System.Windows.Forms.TextBox();
            this.tbMesto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudDoplata = new System.Windows.Forms.NumericUpDown();
            this.nudLica = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dodadiRezervacija = new System.Windows.Forms.Button();
            this.bDodadiAranzman = new System.Windows.Forms.Button();
            this.bIzbrisi = new System.Windows.Forms.Button();
            this.bNajdolg = new System.Windows.Forms.Button();
            this.bIsprazniAranzmani = new System.Windows.Forms.Button();
            this.bIsprazniRezervacii = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbVkupnoLica = new System.Windows.Forms.TextBox();
            this.tbVkupnoCena = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoplata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLica)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAranzmani
            // 
            this.lbAranzmani.FormattingEnabled = true;
            this.lbAranzmani.Location = new System.Drawing.Point(2, 27);
            this.lbAranzmani.Name = "lbAranzmani";
            this.lbAranzmani.Size = new System.Drawing.Size(233, 355);
            this.lbAranzmani.TabIndex = 0;
            this.lbAranzmani.SelectedIndexChanged += new System.EventHandler(this.lbAranzmani_SelectedIndexChanged);
            // 
            // lbRezervacii
            // 
            this.lbRezervacii.FormattingEnabled = true;
            this.lbRezervacii.Location = new System.Drawing.Point(426, 27);
            this.lbRezervacii.Name = "lbRezervacii";
            this.lbRezervacii.Size = new System.Drawing.Size(235, 316);
            this.lbRezervacii.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCena);
            this.groupBox1.Controls.Add(this.tbVremetraenje);
            this.groupBox1.Controls.Add(this.tbDrzava);
            this.groupBox1.Controls.Add(this.tbMesto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(241, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 191);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информации за аранжманот";
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(6, 168);
            this.tbCena.Name = "tbCena";
            this.tbCena.ReadOnly = true;
            this.tbCena.Size = new System.Drawing.Size(166, 20);
            this.tbCena.TabIndex = 7;
            // 
            // tbVremetraenje
            // 
            this.tbVremetraenje.Location = new System.Drawing.Point(6, 126);
            this.tbVremetraenje.Name = "tbVremetraenje";
            this.tbVremetraenje.ReadOnly = true;
            this.tbVremetraenje.Size = new System.Drawing.Size(166, 20);
            this.tbVremetraenje.TabIndex = 6;
            // 
            // tbDrzava
            // 
            this.tbDrzava.Location = new System.Drawing.Point(6, 85);
            this.tbDrzava.Name = "tbDrzava";
            this.tbDrzava.ReadOnly = true;
            this.tbDrzava.Size = new System.Drawing.Size(166, 20);
            this.tbDrzava.TabIndex = 5;
            // 
            // tbMesto
            // 
            this.tbMesto.Location = new System.Drawing.Point(7, 37);
            this.tbMesto.Name = "tbMesto";
            this.tbMesto.ReadOnly = true;
            this.tbMesto.Size = new System.Drawing.Size(166, 20);
            this.tbMesto.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Држава: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Времетраење(денови): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена по лице: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudDoplata);
            this.groupBox2.Controls.Add(this.nudLica);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dodadiRezervacija);
            this.groupBox2.Location = new System.Drawing.Point(241, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 113);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Резервирај аранжман";
            // 
            // nudDoplata
            // 
            this.nudDoplata.Location = new System.Drawing.Point(10, 67);
            this.nudDoplata.Name = "nudDoplata";
            this.nudDoplata.Size = new System.Drawing.Size(120, 20);
            this.nudDoplata.TabIndex = 9;
            // 
            // nudLica
            // 
            this.nudLica.Location = new System.Drawing.Point(10, 28);
            this.nudLica.Name = "nudLica";
            this.nudLica.Size = new System.Drawing.Size(120, 20);
            this.nudLica.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Доплата за пат: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Лица: ";
            // 
            // dodadiRezervacija
            // 
            this.dodadiRezervacija.Location = new System.Drawing.Point(6, 90);
            this.dodadiRezervacija.Name = "dodadiRezervacija";
            this.dodadiRezervacija.Size = new System.Drawing.Size(167, 23);
            this.dodadiRezervacija.TabIndex = 7;
            this.dodadiRezervacija.Text = "Додади резервација";
            this.dodadiRezervacija.UseVisualStyleBackColor = true;
            this.dodadiRezervacija.Click += new System.EventHandler(this.button4_Click);
            // 
            // bDodadiAranzman
            // 
            this.bDodadiAranzman.Location = new System.Drawing.Point(242, 219);
            this.bDodadiAranzman.Name = "bDodadiAranzman";
            this.bDodadiAranzman.Size = new System.Drawing.Size(178, 23);
            this.bDodadiAranzman.TabIndex = 4;
            this.bDodadiAranzman.Text = "Додади нов аранжман";
            this.bDodadiAranzman.UseVisualStyleBackColor = true;
            this.bDodadiAranzman.Click += new System.EventHandler(this.bDodadiAranzman_Click);
            // 
            // bIzbrisi
            // 
            this.bIzbrisi.Location = new System.Drawing.Point(241, 248);
            this.bIzbrisi.Name = "bIzbrisi";
            this.bIzbrisi.Size = new System.Drawing.Size(178, 23);
            this.bIzbrisi.TabIndex = 5;
            this.bIzbrisi.Text = "Избриши аранжман";
            this.bIzbrisi.UseVisualStyleBackColor = true;
            this.bIzbrisi.Click += new System.EventHandler(this.bIzbrisi_Click);
            // 
            // bNajdolg
            // 
            this.bNajdolg.Location = new System.Drawing.Point(241, 277);
            this.bNajdolg.Name = "bNajdolg";
            this.bNajdolg.Size = new System.Drawing.Size(178, 23);
            this.bNajdolg.TabIndex = 6;
            this.bNajdolg.Text = "Најдолг аранжман";
            this.bNajdolg.UseVisualStyleBackColor = true;
            this.bNajdolg.Click += new System.EventHandler(this.bNajdolg_Click);
            // 
            // bIsprazniAranzmani
            // 
            this.bIsprazniAranzmani.Location = new System.Drawing.Point(2, 396);
            this.bIsprazniAranzmani.Name = "bIsprazniAranzmani";
            this.bIsprazniAranzmani.Size = new System.Drawing.Size(233, 23);
            this.bIsprazniAranzmani.TabIndex = 8;
            this.bIsprazniAranzmani.Text = "Испразни ја листата со аранжмани";
            this.bIsprazniAranzmani.UseVisualStyleBackColor = true;
            this.bIsprazniAranzmani.Click += new System.EventHandler(this.bIsprazniAranzmani_Click);
            // 
            // bIsprazniRezervacii
            // 
            this.bIsprazniRezervacii.Location = new System.Drawing.Point(426, 396);
            this.bIsprazniRezervacii.Name = "bIsprazniRezervacii";
            this.bIsprazniRezervacii.Size = new System.Drawing.Size(235, 23);
            this.bIsprazniRezervacii.TabIndex = 9;
            this.bIsprazniRezervacii.Text = "Испразни ја листата со резервации";
            this.bIsprazniRezervacii.UseVisualStyleBackColor = true;
            this.bIsprazniRezervacii.Click += new System.EventHandler(this.bIsprazniRezervacii_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Листа на резервации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Листа на аранжмани";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Вкупно цена: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(426, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Вкупно лица:";
            // 
            // tbVkupnoLica
            // 
            this.tbVkupnoLica.Location = new System.Drawing.Point(514, 346);
            this.tbVkupnoLica.Name = "tbVkupnoLica";
            this.tbVkupnoLica.ReadOnly = true;
            this.tbVkupnoLica.Size = new System.Drawing.Size(147, 20);
            this.tbVkupnoLica.TabIndex = 8;
            this.tbVkupnoLica.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // tbVkupnoCena
            // 
            this.tbVkupnoCena.Location = new System.Drawing.Point(514, 373);
            this.tbVkupnoCena.Name = "tbVkupnoCena";
            this.tbVkupnoCena.ReadOnly = true;
            this.tbVkupnoCena.Size = new System.Drawing.Size(147, 20);
            this.tbVkupnoCena.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 420);
            this.Controls.Add(this.tbVkupnoCena);
            this.Controls.Add(this.tbVkupnoLica);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bIsprazniRezervacii);
            this.Controls.Add(this.bIsprazniAranzmani);
            this.Controls.Add(this.bNajdolg);
            this.Controls.Add(this.bIzbrisi);
            this.Controls.Add(this.bDodadiAranzman);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbRezervacii);
            this.Controls.Add(this.lbAranzmani);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDoplata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAranzmani;
        private System.Windows.Forms.ListBox lbRezervacii;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCena;
        private System.Windows.Forms.TextBox tbVremetraenje;
        private System.Windows.Forms.TextBox tbDrzava;
        private System.Windows.Forms.TextBox tbMesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nudDoplata;
        private System.Windows.Forms.NumericUpDown nudLica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button dodadiRezervacija;
        private System.Windows.Forms.Button bDodadiAranzman;
        private System.Windows.Forms.Button bIzbrisi;
        private System.Windows.Forms.Button bNajdolg;
        private System.Windows.Forms.Button bIsprazniAranzmani;
        private System.Windows.Forms.Button bIsprazniRezervacii;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbVkupnoLica;
        private System.Windows.Forms.TextBox tbVkupnoCena;
    }
}

