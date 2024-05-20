using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Evaluation_System
{
    public partial class anaMenu : Form
    {
        public anaMenu()
        {
            InitializeComponent();
        }

        private void anaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAkademik_Click(object sender, EventArgs e)
        {
            akademisyenler akademisyenler = new akademisyenler();
            akademisyenler.ShowDialog();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            ogrenciler ogrenciler = new ogrenciler();
            ogrenciler.ShowDialog();
        }

        private void btnBitProje_Click(object sender, EventArgs e)
        {
            projeDegerlendirme projeDegerlendirme = new projeDegerlendirme();
            projeDegerlendirme.ShowDialog();
        }

        private void btnGListe_Click(object sender, EventArgs e)
        {
            gListe gListe = new gListe();
            gListe.ShowDialog();
        }
    }
}
