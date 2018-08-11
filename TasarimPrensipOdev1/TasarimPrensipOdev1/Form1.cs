using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasarimPrensipOdev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Player Oynatici = new Player();
        Resim Img = new Resim();
        Video Vd = new Video();
        private void btnResimOynat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Oynatici.Oynat(Img));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnResimDurdur_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Oynatici.Durdur(Img)); 
        }

        private void btnVideoOynat_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Oynatici.Oynat(Vd));
        }

        private void btnVideoDurdur_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Oynatici.Durdur(Vd));            
        }
    }
}
