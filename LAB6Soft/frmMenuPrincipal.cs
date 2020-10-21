using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6Soft
{
    public partial class frmMenuPrincipal : Form
    {
        
        public frmMenuPrincipal()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRest.Enabled = true;
            btnRest.Visible = Enabled;
            btnMaximizar.Visible = false;
            //CAMBIAR POSICICION AL MAXIMIZAR
            //Logo
            imgUmil.Location = new Point(960, 51);
            //SOPORTE

            // pnlSoporte.Location = new Point(1000, 107);
            lblSoporte.Location = new Point(1000, 115);
            btnUsuario.Location = new Point(1000, 361);
            btnProveedor.Location = new Point(1000, 255);
            btnMoneda.Location = new Point(1000, 153);
            



        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRest.Visible = false;
            btnMaximizar.Visible = true;

            imgUmil.Location = new Point(566, 51);
            //SOPORTE

            // pnlSoporte.Location = new Point(1000, 107);
            lblSoporte.Location = new Point(667, 115);
            btnMoneda.Location = new Point(598, 153);
            btnUsuario.Location = new Point(598,361);
            btnProveedor.Location = new Point(598, 255);

            //GESTION REPORTES

            //GESTION COMERCIAL


        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnOC_Click(object sender, EventArgs e)
        {
            
            frmSubMenu form = new frmSubMenu();
            form.ShowDialog();
            this.WindowState = FormWindowState.Minimized;



        }

        private void btnMoneda_Click(object sender, EventArgs e)
        {

        }
    }
}
