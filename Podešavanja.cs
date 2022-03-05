using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pelet
{
    public partial class Podešavanja : Form
    {
        public Podešavanja()
        {
            InitializeComponent();
        }

        private void button_Odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Snimi_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.p1_rad = float.Parse(textBox_radP1.Text);
                Properties.Settings.Default.p1_pauza = float.Parse(textBox_pauza_P1.Text);
                Properties.Settings.Default.p2_rad = float.Parse(textBox_radP2.Text);
                Properties.Settings.Default.p2_pauza = float.Parse(textBox_pauzaP2.Text);
                Properties.Settings.Default.p3_rad = float.Parse(textBox_radP3.Text);
                Properties.Settings.Default.p3_pauza = float.Parse(textBox_pauzaP3.Text);
                Properties.Settings.Default.kalorijska_moc = float.Parse(textBox_Kalorijskamocpeleta.Text);
                Properties.Settings.Default.kolicina_peleta = float.Parse(textBox_kolicinapeletaugramima.Text);
                Properties.Settings.Default.Save();
                this.Close();
            
            }
            catch
            {
                MessageBox.Show("Provjerite unesene vrijednosti!","Neispravan unos!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void Podešavanja_Load(object sender, EventArgs e)
        {
            textBox_radP1.Text = Properties.Settings.Default.p1_rad.ToString();
            textBox_pauza_P1.Text = Properties.Settings.Default.p1_pauza.ToString();
            textBox_radP2.Text = Properties.Settings.Default.p2_rad.ToString();
            textBox_pauzaP2.Text = Properties.Settings.Default.p2_pauza.ToString();
            textBox_radP3.Text = Properties.Settings.Default.p3_rad.ToString();
            textBox_pauzaP3.Text = Properties.Settings.Default.p3_pauza.ToString();
            textBox_Kalorijskamocpeleta.Text = Properties.Settings.Default.kalorijska_moc.ToString();
            textBox_kolicinapeletaugramima.Text = Properties.Settings.Default.kolicina_peleta.ToString();

        }
    }
}
