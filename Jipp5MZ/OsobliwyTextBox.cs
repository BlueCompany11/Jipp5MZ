using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jipp5MZ
{
    public partial class OsobliwyTextBox : RichTextBox
    {
        public int DopuszczalnaIloscZnakow { get => 2; }    //ilosc znakow jakie mozesz wpisac do textboxow (pozniej zamienilem, ze jesli 2 znak to . to mozna wpisac ich dowoli
        //przykladowo mozna wpisac 1 53 0.2314124124, ale juz nie wpiszesz 14134
        public OsobliwyTextBox()
        {
            InitializeComponent();
            TextChanged += OsobliwyTextBox_TextChanged;
        }

        private void OsobliwyTextBox_TextChanged(object sender, EventArgs e)
        {   //text.lenght to ilosc znakow w textboxie
            if(Text.Length > DopuszczalnaIloscZnakow && Text[1] != '.') //tutaj jest to miejsce ktore definiuje kiedy zostanie wywolane zdarzenie ZaDlugiTekst
            {
                if(ZaDlugiTekst != null)
                {
                    ZaDlugiTekst();
                }
            }
        }

        public delegate void PozbywanieSieTekstu(); //typ funkcji jaki moze zostac wywolany przy zdarzeniu ZaDlugiTekst 
        public event PozbywanieSieTekstu ZaDlugiTekst;
    }
}
