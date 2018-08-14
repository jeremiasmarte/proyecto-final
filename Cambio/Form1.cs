using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cambio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dl, dl2, eu, eu2, yen, yen2, won, won2;

            dl = Convert.ToDouble(txtpesos.Text);
            dl2 = dl * 0.0200953;
            txtdolar.Text = dl2.ToString();

            eu = Convert.ToDouble(txtpesos.Text);

            eu2 = eu * 0.0176336;
            txteuro.Text = eu2.ToString();

            yen = Convert.ToDouble(txtpesos.Text);

            yen2 = yen * 2.21454;
            txtyen.Text = yen2.ToString();

            won = Convert.ToDouble(txtpesos.Text);

            won2 = won * 22.7820;
            txtwon.Text = won2.ToString();




        }

        }
    }

