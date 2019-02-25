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
            osobliwyTextBoxCola.ZaDlugiTekst += OsobliwyTextBox1_ZaDlugiTekst;  //dodaje metody do zdarzen kontrolki
            osobliwyTextBoxSok.ZaDlugiTekst += OsobliwyTextBoxSok_ZaDlugiTekst;
            cola = new Cola();  //tworze obiekty z komponentu JIPP5MZLib
            cappy = new Cappy();
        }

        private void OsobliwyTextBoxSok_ZaDlugiTekst()  //implementacja tych metod które wywołane zostaną gdy zostanie wywołane zdarzenie ZaDlugiTekst
        {
            osobliwyTextBoxCola.Text = "Na pewno tyle nie wypijesz soku";
        }

        private void OsobliwyTextBox1_ZaDlugiTekst()    //to samo
        {
            osobliwyTextBoxCola.Text = "Na pewno tyle nie wypijesz coli";
        }

        private void buttonCola_Click(object sender, EventArgs e)
        {
            if (osobliwyTextBoxCola.Text != "")
            {
                double wartoscLiczbowaPola;
                try
                {//jest to w try catchu na wypadek gdyby ktos nie wpisal liczby ktora da sie zrzutowac do doubla np. "asd", wtedy przejdzie do catcha i pojawi sie ten komunikat
                    wartoscLiczbowaPola = Convert.ToDouble(osobliwyTextBoxCola.Text);
                    cola.Wypij(wartoscLiczbowaPola);
                }
                catch (Exception) { MessageBox.Show(osobliwyTextBoxCola.Text + " nie jest wartoscia liczbowa"); };
            }
            
        }

        private void buttonSok_Click(object sender, EventArgs e)
        {
            if (osobliwyTextBoxSok.Text != "")  //to samo co wyżej
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
