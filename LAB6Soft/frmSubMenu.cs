using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using formsLab6;

namespace LAB6Soft
{
    public partial class frmSubMenu : Form
    {
        private IconButton btnActual;
        private Panel pnlIzq;
        private Form hijoAct=null;
        public frmSubMenu()
        {
            InitializeComponent();
            pdiseno();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            pnlIzq = new Panel();
            pnlIzq.Size = new Size(7, 40);

            pnlMenulateral.Controls.Add(pnlIzq);
           // this.Text = string.Empty;
            //this.DoubleBuffered = true;
            //this.ShowDialog();

        }
        private struct Colores
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            //172, 126, 241
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void pdiseno() {
            pnlSubComp.Visible = false;
            pnlSubProveedor.Visible = false;
            pnlSubReps.Visible = false;
            pnlSubUsuarios.Visible = false;
            pnlSubVencer.Visible = false;
        }
        private void ocultar() { 
            if (pnlSubComp.Visible == true)
                pnlSubComp.Visible = false;
            if (pnlSubProveedor.Visible ==true)
                pnlSubProveedor.Visible = false;
            if (pnlSubReps.Visible == true)
                pnlSubReps.Visible = false;
            if (pnlSubUsuarios.Visible ==true )
                pnlSubUsuarios.Visible = false;
            if (pnlSubVencer.Visible == true)
                pnlSubVencer.Visible = false;
        }
        private void mostrar(Panel submenu) {
            if (submenu.Visible == false)
            {
                ocultar();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        private void ActivarBoton(object sender, Color color) {
            //int i = 0;
            if (sender != null)
            {
                DesactivarBoton();
                btnActual = (IconButton)sender;
                btnActual.BackColor = Color.FromArgb(37, 36, 81);
                btnActual.ForeColor = color;
                btnActual.TextAlign = ContentAlignment.MiddleCenter;
                btnActual.IconColor = color;
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;
                btnActual.ImageAlign = ContentAlignment.MiddleRight;              
                pnlIzq.BackColor = color;
                pnlIzq.Location = new Point(0, btnActual.Location.Y);
                pnlIzq.Visible = true;
                pnlIzq.BringToFront();
                iconActual.IconChar = btnActual.IconChar;
                iconActual.IconColor = color;
             //   i = 1;
                
            }
           // return i;
        }
        private void DesactivarBoton() {
            if (btnActual != null) {
                btnActual.BackColor = Color.DarkSlateBlue;
                btnActual.ForeColor = Color.White;
                btnActual.TextAlign = ContentAlignment.MiddleLeft;
                btnActual.IconColor = Color.White;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActual.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        private void AbrirHijo(Form hijo) {
            if (hijoAct != null) {
                hijoAct.Close(); 
            }
            hijoAct = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            pnlVentana.Controls.Add(hijo);
            pnlVentana.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();
            lblActual.Text = btnActual.Text;

        }
        private void btnOC_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colores.color1);
            ocultar();
            //mostrar(pnlSubComp);
            //AbrirHijo(new frmOrdenCompra());
            //comentario
        }

        private void btnCompPago_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colores.color2);
        }

        private void btnVencer_Click(object sender, EventArgs e)
        {
             ActivarBoton(sender, Colores.color3);
        }

        private void btnDocPago_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colores.color4);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
             ActivarBoton(sender, Colores.color5);
            AbrirHijo(new FrmGestionReportes());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colores.color6);
          //  btnProveedores.Location = new Point(0, 379);
          //  btnMoneda.Location = new Point(0, 419);
          //  pnlSubUsuarios.Visible = true;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colores.color1);
            AbrirHijo(new frmProveedorAgregar());
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colores.color2);
            AbrirHijo(new frmActualizarTipoCambio());
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRest.Visible = false;
            btnMaximizar.Visible = true;
        }
        private void limpiar()
        {
            DesactivarBoton();
            pnlIzq.Visible = false;
            iconActual.IconChar = IconChar.HouseUser;
            iconActual.IconColor = Color.White;
            lblActual.Text = "Inicio";
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (hijoAct != null)
            {
                hijoAct.Close();
            }
            limpiar();


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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRest.Enabled = true;
            btnRest.Visible = Enabled;
            btnMaximizar.Visible = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVencer_Click_1(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colores.color3);
            //mostrar(pnlSubComp);
            //AbrirHijo(new frmOrdenCompra());
            //comentario
        }

        

        private void btnCompPago_Click_1(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colores.color2);
            ocultar();
            //mostrar(pnlSubComp);
            //AbrirHijo(new frmOrdenCompra());
            //comentario
        }

        private void btnDocPago_Click_1(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colores.color4);
            //mostrar(pnlSubComp);
            //AbrirHijo(new frmOrdenCompra());
            //comentario
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colores.color5);
            mostrar(pnlSubReps);
            //mostrar(pnlSubComp);
            //AbrirHijo(new frmOrdenCompra());
            //comentario
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colores.color6);
            mostrar(pnlSubUsuarios);

           // DesactivarBoton();
            //mostrar(pnlSubComp);
            //AbrirHijo(new frmOrdenCompra());
            //comentario
        }

        private void btnProveedores_Click_1(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colores.color1);
            mostrar(pnlSubProveedor);
            lblActual.Text = btnActual.Text;
            //mostrar(pnlSubComp);
            //AbrirHijo(new frmOrdenCompra());
            //comentario
        }

        private void btnMoneda_Click(object sender, EventArgs e)
        {
            ActivarBoton(sender, Colores.color2);
            ocultar();
            //mostrar(pnlSubComp);
            //AbrirHijo(new frmOrdenCompra());
            //comentario
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            //comentario
            ocultar();
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            //comentario
            ocultar();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            //comentario
            AbrirHijo(new frmProveedorAgregar());
            lblActual.Text = btnAgregarProveedor.Text;
            // ocultar();
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            //comentario
            ocultar();
        }

        private void btnRepOC_Click(object sender, EventArgs e)
        {
            //comentario
            ocultar();
        }

        private void btnRepEf_Click(object sender, EventArgs e)
        {
            //comentario
            ocultar();

        }
    }
}
