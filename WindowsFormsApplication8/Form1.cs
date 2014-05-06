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
    public partial class Form1 : Form
    {
        LinkedList<Aranzmani> lista;
        Aranzmani aranz;
        public int vkupno;
        public Form1()
        {
            
            InitializeComponent();
            vkupno = 0;
            lista = new LinkedList<Aranzmani>();
            aranz = new Aranzmani("Мајорка", "Шпанија",10,15000);
            lbAranzmani.Items.Add(aranz);
            lista.AddLast(aranz);
            aranz = new Aranzmani("Париз", "Франција", 5, 12000);
            lbAranzmani.Items.Add(aranz);
            lista.AddLast(aranz);
            aranz = new Aranzmani("Крф", "Грција", 12, 10000);
            lbAranzmani.Items.Add(aranz);
            lista.AddLast(aranz);
            aranz = new Aranzmani("Дубровник", "Хрватска", 6, 7000);
            lbAranzmani.Items.Add(aranz);
            lista.AddLast(aranz);
        }

        private void lbAranzmani_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbAranzmani.SelectedIndex;
            if (index != -1) {
                Aranzmani ar = (Aranzmani)lbAranzmani.SelectedItem;
                tbCena.Text = ar.cena.ToString();
                tbDrzava.Text = ar.drzava;
                tbMesto.Text = ar.mesto;
                tbVremetraenje.Text = ar.vremetraenje.ToString();
            }
        }

        private void bIsprazniAranzmani_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Dali ste sigurni?", "Potvrda", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes) {
                lbAranzmani.Items.Clear();
            }
        }

        private void bIsprazniRezervacii_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Dali ste sigurni?", "Potvrda", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                lbRezervacii.Items.Clear();
            }

        }
        public int vkupno1(){
            
            vkupno += (int.Parse(nudLica.Value.ToString()) * int.Parse(tbCena.Text)) + int.Parse(nudDoplata.Value.ToString());
            return vkupno;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int index = lbAranzmani.SelectedIndex;
            if (index != -1) {
                Rezervacii rez = new Rezervacii(tbMesto.Text, int.Parse(nudLica.Value.ToString()), int.Parse(nudDoplata.Value.ToString()), int.Parse(tbCena.Text), vkupno1());
                lbRezervacii.Items.Add(rez);
            }
            tbVkupnoLica.Text = nudLica.Value.ToString();
            tbVkupnoCena.Text = vkupno1().ToString();
        }

        private void bIzbrisi_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Dali ste sigurni deka sakate da go izbrisete aranzmanot?", "Potvrda", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {

                lbAranzmani.Items.Remove(lbAranzmani.SelectedItem);
            }
            
        }

        private void bDodadiAranzman_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            DialogResult res = form2.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.Yes) {
                lbAranzmani.Items.Add(form2.ar);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void bNajdolg_Click(object sender, EventArgs e)
        {
            int max = 0;
            string str = "";
            foreach(Aranzmani ar in lista){
                if (ar.vremetraenje > max) {
                    max = aranz.vremetraenje;
                    str = ar.mesto + " " + ar.drzava;
                }
            }
            MessageBox.Show("Најдолг аранжман е "+str);
            
            
        }
    }
    public class Aranzmani {
        public string mesto { get; set; }
        public string drzava { get; set; }
        public int vremetraenje { get; set; }
        public int cena { get; set; }

        public Aranzmani() { }
        public Aranzmani(string mesto, string drzava, int vremetraenje, int cena) {
            this.mesto = mesto;
            this.drzava = drzava;
            this.vremetraenje = vremetraenje;
            this.cena = cena;
        }
        public override string ToString()
        {
            return mesto + " - " + drzava + " " + vremetraenje + " дена";
        }
    }
    public class Rezervacii {
        public string mesto { get; set; }
        public int lica { get; set; }
        public int doplata { get; set; }
        public int cena { get; set; }
        public int vkupno { get; set; }
        public Rezervacii() { }
        public Rezervacii(string mesto, int lica, int doplata, int cena, int vkupno) {
            this.mesto = mesto;
            this.lica = lica;
            this.doplata = doplata;
            this.cena = cena;
            this.vkupno = vkupno;
        }
        public override string ToString()
        {
            
            return String.Format("{0}  {1:0} x {2:0.0} + {3:0.0} = {4:0.0}",mesto,lica,cena,doplata,lica * cena + doplata);
               
        }


    }
}
