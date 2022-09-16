using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problemas_2._1y2._2.Presentacion
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Pila Frm_Pila = new Frm_Pila();

            Frm_Pila.Show();

            this.Close();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cola Frm_Cola = new Frm_Cola();

            Frm_Cola.Show();

            this.Close();
        }
    }
}
