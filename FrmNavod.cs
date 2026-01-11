using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootbalGamble
{
    public partial class FrmNavod: Form
    {
        public FrmNavod()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmNavod_Load(object sender, EventArgs e)
        {
            lblNavodTxt.Text = "Návod ke hře Football Gamble\r\n\r\nPo spuštění hry dostaneš počáteční částku peněz\r\n\r\nV každém kole se vylosují dva fotbalové týmy\r\n\r\nVybereš si, který tým podle tebe vyhraje, nebo zvolíš remízu\r\n\r\nZadáš částku, kterou chceš vsadit\r\n\r\nPotvrdíš sázku tlačítkem pro spuštění zápasu\r\n\r\nHra náhodně vygeneruje výsledek zápasu\r\n\r\nPokud se tvůj tip shoduje s výsledkem, vyhraješ peníze a získáš XP\r\n\r\nPokud se netrefíš, o vsazené peníze přijdeš\r\n\r\nTýmy za zápasy sbírají body do ligové tabulky\r\n\r\nZa získané XP se zvyšuje tvůj level\r\n\r\nPo každém zápase pokračuješ do dalšího kola\r\n\r\nHra končí po odehrání celé ligy nebo pokud dojdou peníze\r\n\r\nCílem hry je vydělat co nejvíce peněz a dosáhnout cílové částky";
        }
    }
}
