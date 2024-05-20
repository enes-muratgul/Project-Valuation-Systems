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
    public partial class akademisyenler : Form
    {
        MySqlConnection baglanti = new MySqlConnection("Server = localhost;Database = gorselprogram; user=root;");
        public akademisyenler()
        {
            InitializeComponent();
        }

        private void akademisyenler_Load(object sender, EventArgs e)
        {
            listele();

        }
        private void listele()
        {
            baglanti.Open();
            MySqlDataAdapter adaptor = new MySqlDataAdapter("SELECT * FROM akademisyenler ORDER BY akademik_id", baglanti);
            DataTable dt = new DataTable();
            dt.Clear();
            adaptor.Fill(dt);
            dataGridView1.DataSource = dt;
            adaptor.Dispose();
            baglanti.Close();  
        }
    }
}
