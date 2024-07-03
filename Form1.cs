using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jatekadatumokkal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IbIDatum_Click(object sender, EventArgs e)
        { }

        private DateTime ma = DateTime.Now;
        private DateTime szulDatum;
        private DateTime valasztottDatum;

        private void Form1_Load(object sender, EventArgs e)
        {
            IbIDatum.Text = ma.ToString("F");
            IbIGratulacio.Text = "";
            valasztottDatum = dateTimePicker1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IbIDatum.Text = DateTime.Now.ToString("F");
        }

        private void btnKiir_Click(object sender, EventArgs e)
        {
            txtkSzam.Text = (ma.Year - szulDatum.Year).ToString();
            txtnapSzul.Text = szulDatum.DayOfWeek.ToString();
            txtnapSzamaEvben.Text = valasztottDatum.DayOfYear.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            valasztottDatum = dateTimePicker1.Value;
            txtnapSzamaEvben.Text = valasztottDatum.DayOfYear.ToString();
        }

        private void txtNapSzam_TextChanged(object sender, EventArgs e)
        {
            int hossz = txtnapokSz.Text.Length;
            if ((hossz >= 2 && txtnapokSz.Text.ElementAt(0) == '-') ||
                (hossz >= 1 && txtnapokSz.Text.ElementAt(0) != '-'))
            {
                try
                {
                    int nap = int.Parse(txtnapokSz.Text);
                    txtnapokSzKesobb.Text = valasztottDatum.AddDays(nap).ToString("d");
                }
                catch (Exception)
                {
                    MessageBox.Show("nem szamot irt!!!", "hiba");
                }
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox) ((TextBox)item).Clear();
            }
            IbIGratulacio.Text = "";
            mskdTxtSzulD.Clear();
        }

        private void btnBezár_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("biztosan kilep?", "megerosites", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes) this.Close();
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!mskdTxtSzulD.MaskCompleted) throw new FormatException();
                else
                {
                    szulDatum = DateTime.Parse(mskdTxtSzulD.Text);
                    if (szulDatum.Month == ma.Month && szulDatum.Day == ma.Day)
                    {
                        IbIGratulacio.Text = "isten eltessen!:)";
                    }
                    else
                    {
                        IbIGratulacio.Text = "boldog hetkoznapot!:)";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hibas dátum", "hiba");
            }
        }

        private void mskdTxtSzulDatum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            try
            {
                if (!mskdTxtSzulD.MaskCompleted) throw new FormatException();
                else
                {
                    szulDatum = DateTime.Parse(mskdTxtSzulD.Text);
                    if (szulDatum.Month == ma.Month && szulDatum.Day == ma.Day)
                    {
                        IbIGratulacio.Text = "isten eltessen!:)";
                    }
                    else
                    {
                        IbIGratulacio.Text = "boldog hetkoznapot!:)";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hibas datum", "hiba");
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) Gratulacio();
        }

        private void Gratulacio()
        {
            try
            {
                if (!mskdTxtSzulD.MaskCompleted) throw new FormatException();
                else
                {
                    szulDatum = DateTime.Parse(mskdTxtSzulD.Text);
                    if (szulDatum.Month == ma.Month && szulDatum.Day == ma.Day)
                    {
                        IbIGratulacio.Text = "isten eltessen!:)";
                    }
                    else
                    {
                        IbIGratulacio.Text = "boldog hetkoznapot!:)";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("hibas datum", "hiba");
                mskdTxtSzulD.Focus();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
