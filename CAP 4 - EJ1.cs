using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static c4c4.TablaMul;

namespace c4c4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNumeroMul.Text);
            ClaseTablaM tablaMultiplicacion = new ClaseTablaM(); 
            tablaMultiplicacion.Mul(num1);
        }
    }
}
