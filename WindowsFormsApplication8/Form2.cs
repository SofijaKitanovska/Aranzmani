using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form2 : Form
    {
        public Aranzmani ar;
        public Form2()
        {
            InitializeComponent();
        }

        private void bOtkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void bVnesi_Click(object sender, EventArgs e)
        {
            if (tbDrzava1.Text.Trim() == "") {
                MessageBox.Show("Vnesete drzava!");
            }
            if (tbMesto1.Text.Trim() == "")
            {
                MessageBox.Show("Vnesete mesto!");
            }
            if (tbDrzava1.Text.Trim() != "" && tbMesto1.Text.Trim() != "") {
                ar = new Aranzmani(tbMesto1.Text, tbDrzava1.Text, int.Parse(nudVremetraenje1.Value.ToString()), int.Parse(nudCena1.Value.ToString()));
                this.DialogResult = System.Windows.Forms.DialogResult.Yes;
                

            }

        }
    }
}
