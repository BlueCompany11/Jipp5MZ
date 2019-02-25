using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jipp5MZLib;

namespace Jipp5MZ
{
    public partial class Form1 : Form
    {
        Cola cola;
        Cappy cappy;

        public Form1()
        {
            InitializeComponent();
            osobliwyTextBoxCola.ZaDlugiTekst += OsobliwyTextBox1_ZaDlugiTekst;
            cola = new Cola();
            cappy = new Cappy();
        }

        private void OsobliwyTextBox1_ZaDlugiTekst()
        {
            osobliwyTextBoxCola.Text = "Na pewno tyle nie wypijesz";
        }

        private void buttonCola_Click(object sender, EventArgs e)
        {
            if (osobliwyTextBoxCola.Text != "")
            {
                double wartoscLiczbowaPola;
                try
                {
                    wartoscLiczbowaPola = Convert.ToDouble(osobliwyTextBoxCola.Text);
                    cola.Wypij(wartoscLiczbowaPola);
                }
                catch (Exception) { MessageBox.Show(osobliwyTextBoxCola.Text + " nie jest wartoscia liczbowa"); };
            }
            
        }

        private void buttonSok_Click(object sender, EventArgs e)
        {
            if (osobliwyTextBoxSok.Text != "")
            {
                double wartoscLiczbowaPola;
                try
                {
                    wartoscLiczbowaPola = Convert.ToDouble(osobliwyTextBoxSok.Text);
                    cappy.Wypij(wartoscLiczbowaPola);
                }
                catch (Exception) { MessageBox.Show(osobliwyTextBoxSok.Text + " nie jest wartoscia liczbowa"); };
            }
        }
    }
}
