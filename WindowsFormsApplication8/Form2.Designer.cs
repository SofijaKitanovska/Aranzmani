namespace WindowsFormsApplication8
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
            this.Место = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bOtkazi = new System.Windows.Forms.Button();
            this.bVnesi = new System.Windows.Forms.Button();
            this.tbMesto1 = new System.Windows.Forms.TextBox();
            this.tbDrzava1 = new System.Windows.Forms.TextBox();
            this.nudVremetraenje1 = new System.Windows.Forms.NumericUpDown();
            this.nudCena1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudVremetraenje1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena1)).BeginInit();
            this.SuspendLayout();
            // 
            // Место
            // 
            this.Место.AutoSize = true;
            this.Место.Location = new System.Drawing.Point(13, 13);
            this.Место.Name = "Место";
            this.Место.Size = new System.Drawing.Size(45, 13);
            this.Место.TabIndex = 0;
            this.Место.Text = "Место: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Цена по лице:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Времетраење(денови):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Држава:";
            // 
            // bOtkazi
            // 
            this.bOtkazi.Location = new System.Drawing.Point(12, 241);
            this.bOtkazi.Name = "bOtkazi";
            this.bOtkazi.Size = new System.Drawing.Size(93, 23);
            this.bOtkazi.TabIndex = 4;
            this.bOtkazi.Text = "Откажи";
            this.bOtkazi.UseVisualStyleBackColor = true;
            this.bOtkazi.Click += new System.EventHandler(this.bOtkazi_Click);
            // 
            // bVnesi
            // 
            this.bVnesi.Location = new System.Drawing.Point(154, 241);
            this.bVnesi.Name = "bVnesi";
            this.bVnesi.Size = new System.Drawing.Size(89, 23);
            this.bVnesi.TabIndex = 5;
            this.bVnesi.Text = "Внеси";
            this.bVnesi.UseVisualStyleBackColor = true;
            this.bVnesi.Click += new System.EventHandler(this.bVnesi_Click);
            // 
            // tbMesto1
            // 
            this.tbMesto1.Location = new System.Drawing.Point(12, 29);
            this.tbMesto1.Name = "tbMesto1";
            this.tbMesto1.Size = new System.Drawing.Size(231, 20);
            this.tbMesto1.TabIndex = 6;
            // 
            // tbDrzava1
            // 
            this.tbDrzava1.Location = new System.Drawing.Point(12, 79);
            this.tbDrzava1.Name = "tbDrzava1";
            this.tbDrzava1.Size = new System.Drawing.Size(231, 20);
            this.tbDrzava1.TabIndex = 7;
            // 
            // nudVremetraenje1
            // 
            this.nudVremetraenje1.Location = new System.Drawing.Point(12, 132);
            this.nudVremetraenje1.Name = "nudVremetraenje1";
            this.nudVremetraenje1.Size = new System.Drawing.Size(120, 20);
            this.nudVremetraenje1.TabIndex = 8;
            // 
            // nudCena1
            // 
            this.nudCena1.Location = new System.Drawing.Point(12, 195);
            this.nudCena1.Name = "nudCena1";
            this.nudCena1.Size = new System.Drawing.Size(120, 20);
            this.nudCena1.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 297);
            this.Controls.Add(this.nudCena1);
            this.Controls.Add(this.nudVremetraenje1);
            this.Controls.Add(this.tbDrzava1);
            this.Controls.Add(this.tbMesto1);
            this.Controls.Add(this.bVnesi);
            this.Controls.Add(this.bOtkazi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Место);
            this.Name = "Form2";
            this.Text = "Нов аранжман";
            ((System.ComponentModel.ISupportInitialize)(this.nudVremetraenje1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Место;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bOtkazi;
        private System.Windows.Forms.Button bVnesi;
        private System.Windows.Forms.TextBox tbMesto1;
        private System.Windows.Forms.TextBox tbDrzava1;
        private System.Windows.Forms.NumericUpDown nudVremetraenje1;
        private System.Windows.Forms.NumericUpDown nudCena1;
    }
}