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
        public int DopuszczalnaIloscZnakow { get => 2; }
        public OsobliwyTextBox()
        {
            InitializeComponent();
            TextChanged += OsobliwyTextBox_TextChanged;
        }

        private void OsobliwyTextBox_TextChanged(object sender, EventArgs e)
        {
            if(Text.Length > DopuszczalnaIloscZnakow && Text[1] != '.')
            {
                if(ZaDlugiTekst != null)
                {
                    ZaDlugiTekst();
                }
            }
        }

        public delegate void PozbywanieSieTekstu();
        public event PozbywanieSieTekstu ZaDlugiTekst;
    }
}
