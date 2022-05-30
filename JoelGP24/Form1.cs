using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoelGP24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Form1 frm = new Form1();
         if (frm.ShowDialog() == DialogResult.OK)
             {
                 string cadena1 = frm.cad1;
                 string cadena1 = frm.cad2;
                 bool boleano1 = frm.bl1;
                 bool boleano2  = frm.bl2;
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Form1 frm = new Form1();
         if (frm.ShowDialog() == DialogResult.OK)
             {
                 string cadena1 = frm.cad1;
                 string cadena1 = frm.cad2;
                 bool boleano1 = frm.bl1;
                 bool boleano2  = frm.bl2;
             }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
