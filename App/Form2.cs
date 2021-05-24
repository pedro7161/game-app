using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categorias f5 = new Categorias();
            f5.MdiParent = this;
            f5.Show();
        }

        private void suppTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
           support f50 = new support();
            f50.MdiParent = this;
            f50.Show();
        }

        private void mapasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mapa f1 = new mapa();
            f1.MdiParent = this;
            f1.Show();
        }
    }
}
