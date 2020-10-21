using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6Soft
{
    public partial class FrmGestionReportes : Form
    {
        private int num=0;

        public int Num { get => num; set => num = value; }

        public FrmGestionReportes()
        {
            InitializeComponent();
        }

        private void ButtonOrdenCompra_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmReporteOrdenCompra form = new FrmReporteOrdenCompra();
            
            form.ShowDialog();


        }

        private void ButtonActOperadores_Click(object sender, EventArgs e)
        {
            FrmReporteActividadOperador form = new FrmReporteActividadOperador();
            form.ShowDialog();
            
            
        }

        private void ButtonMetodosPago_Click(object sender, EventArgs e)
        {
            FrmReporteMetodoPago form = new FrmReporteMetodoPago();
            form.ShowDialog();
        }

        private void ButtonDetraccion_Click(object sender, EventArgs e)
        {
            FrmReporteMetodoPago form = new FrmReporteMetodoPago();
            form.ShowDialog();

        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal form = new frmMenuPrincipal();
            form.ShowDialog();

        }

        private void lblListado_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ButtonOrdenCompra_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ButtonActOperadores_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void ButtonMetodosPago_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ButtonDetraccion_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
