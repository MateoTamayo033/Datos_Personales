using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REGISTRO_Y_LOGIN
{
    public partial class RYL: Form
    {
        public RYL()
        {
            InitializeComponent();
        }
        
        private void btnregistro_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Pprincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BtnMouseEnter(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control ctr in Pprincipal.Controls)
            {
                if (ctr is Button)
                {
                    bt.ForeColor = Color.Black;
                }
            }
        }
                
                private void BtnMouseLeave(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            foreach (Control ctr in Pprincipal.Controls)
            {
                if (ctr is Button)
                {
                    bt.ForeColor = Color.White;
                }
            }
        }

        private void pNombre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void RYL_Load(object sender, EventArgs e)
        {

        }
        private void txtEnter(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in PReg.Controls)
            {
                if(ctr is Panel && ctr.Name == "p" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Black;
                }
            }
        }
        private void txtLeave(object sender, EventArgs e)
        {
            TextBox tx = sender as TextBox;
            foreach (Control ctr in PReg.Controls)
            {
                if (ctr is Panel && ctr.Name == "p" + tx.Tag.ToString())
                {
                    ctr.BackColor = Color.Silver;
                }
            }
        }
        private bool controlTimer = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!controlTimer)
            {
                PContenedor.Left += 10;
                PReg.BringToFront();
                if (PContenedor.Left == 400)
                {
                    timer1.Stop();
                    controlTimer = true;
                }
            }
            else
            {
                PContenedor.Left -= 10;
                pAcceder.BringToFront();
                if (PContenedor.Left == 0)
                {
                    timer1.Stop();
                    controlTimer = false;
                }
            }
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
