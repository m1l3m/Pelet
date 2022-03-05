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
    public partial class Glavna_forma : Form
    {
        public Glavna_forma()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Snaga_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Glavna_forma_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel_DateTime.Text = DateTime.Now.ToString("d.MMMM yyyy.  HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_DateTime.Text = DateTime.Now.ToString("d.MMMM yyyy.  HH:mm:ss");
        }

        private void podešavanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Podešavanja podesi = new Podešavanja();
            podesi.ShowDialog();
        }

        private void btn_Izračunaj_Click(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox_Snaga.Text)
                {
                    case "P1":
                        lbl_potrošnja_sat.Text = (Properties.Settings.Default.kolicina_peleta / 1000 * Properties.Settings.Default.p1_rad * 60 / (Properties.Settings.Default.p1_rad + Properties.Settings.Default.p1_pauza)).ToString();
                        lbl_snaga_kW.Text = (Properties.Settings.Default.kolicina_peleta / 1000 * Properties.Settings.Default.p1_rad * 60 / (Properties.Settings.Default.p1_rad + Properties.Settings.Default.p1_pauza) * Properties.Settings.Default.kalorijska_moc).ToString();
                        lbl_potrošnja_dan.Text = (Properties.Settings.Default.kolicina_peleta / 1000 * Properties.Settings.Default.p1_rad * 60 / (Properties.Settings.Default.p1_rad + Properties.Settings.Default.p1_pauza) * Convert.ToDouble(txtbox_BrojSati.Text)).ToString();
                        break;
                    case "P2":
                        lbl_potrošnja_sat.Text = (Properties.Settings.Default.kolicina_peleta / 1000 * Properties.Settings.Default.p2_rad * 60 / (Properties.Settings.Default.p2_rad + Properties.Settings.Default.p2_pauza)).ToString();
                        lbl_snaga_kW.Text = (Properties.Settings.Default.kolicina_peleta / 1000 * Properties.Settings.Default.p2_rad * 60 / (Properties.Settings.Default.p2_rad + Properties.Settings.Default.p2_pauza) * Properties.Settings.Default.kalorijska_moc).ToString();
                        lbl_potrošnja_dan.Text = (Properties.Settings.Default.kolicina_peleta / 1000 * Properties.Settings.Default.p2_rad * 60 / (Properties.Settings.Default.p2_rad + Properties.Settings.Default.p2_pauza) * Convert.ToDouble(txtbox_BrojSati.Text)).ToString();
                        break;
                    case "P3":
                        lbl_potrošnja_sat.Text = (Properties.Settings.Default.kolicina_peleta / 1000 * Properties.Settings.Default.p3_rad * 60 / (Properties.Settings.Default.p3_rad + Properties.Settings.Default.p3_pauza)).ToString();
                        lbl_snaga_kW.Text = (Properties.Settings.Default.kolicina_peleta / 1000 * Properties.Settings.Default.p3_rad * 60 / (Properties.Settings.Default.p3_rad + Properties.Settings.Default.p3_pauza) * Properties.Settings.Default.kalorijska_moc).ToString();
                        lbl_potrošnja_dan.Text = (Properties.Settings.Default.kolicina_peleta / 1000 * Properties.Settings.Default.p3_rad * 60 / (Properties.Settings.Default.p3_rad + Properties.Settings.Default.p3_pauza) * Convert.ToDouble(txtbox_BrojSati.Text)).ToString();
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Provjerite unijete parametre!","Greška",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void izlazIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
