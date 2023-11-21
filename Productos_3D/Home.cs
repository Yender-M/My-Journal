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

namespace My_Journal
{
    public partial class Home : Form
    {
        private IconButton botonactual;
        private Form formularioactual;

        //constructor
        public Home()
        {
            InitializeComponent();
            this.Text = string.Empty;
        }

        /*Crea la base de datos global*/
        BaseDeDatos bd = new BaseDeDatos();

        //metodos
        private void AbrirFormularioHijo(Form formhijo)
        {
            if(formularioactual != null)
            {
                //Abrir
                formularioactual.Close();
            }
            formularioactual = formhijo;
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            panel_contenedor.Controls.Add(formhijo);
            panel_contenedor.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();
        }

        private void reset() /**/
        {
            Desactivarboton();
            icbtn_iglesia.IconChar = IconChar.Church;
            icbtn_iglesia.IconColor = Color.White;
            icbtn_iglesia.Text = "Iglesia";
        }

        //Abrir y cerrar botones
        private void Activarboton(object senderBtn)
        {
            if (senderBtn != null)
            {
                Desactivarboton();
                botonactual = (IconButton)senderBtn;
                botonactual.BackColor = Color.FromArgb(39, 60, 65);
                botonactual.ForeColor = Color.FromArgb(255, 255, 255);
                botonactual.IconColor = Color.FromArgb(255, 255, 255);
                //borde del boton
                botonactual.FlatAppearance.BorderColor = Color.FromArgb(166, 145, 68);
                botonactual.FlatAppearance.BorderSize = 1;
                icbtn_iglesia.IconChar = botonactual.IconChar;
                icbtn_iglesia.IconColor = Color.FromArgb(255, 255, 255);
                icbtn_iglesia.ForeColor = Color.FromArgb(255, 255, 255);
                icbtn_iglesia.Text = botonactual.Text;
            }
        }

        private void Desactivarboton()
        {
            if (botonactual != null)
            {
                botonactual.BackColor = Color.FromArgb(20, 37, 44);
                botonactual.ForeColor = Color.Gainsboro;
                botonactual.TextAlign = ContentAlignment.MiddleLeft;
                botonactual.IconColor = Color.Gainsboro;
                botonactual.TextImageRelation = TextImageRelation.ImageBeforeText;
                botonactual.ImageAlign = ContentAlignment.MiddleLeft;
                botonactual.FlatAppearance.BorderColor = Color.FromArgb(20, 37, 44);
            }
        }

        //Arrastrar Formulario
        [DllImport("user32.DLL",EntryPoint = "RealseCapture")]
        private extern static void RealseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg,int wParam, int lparam);

        private void panel_barra_MouseDown(object sender, MouseEventArgs e)
        {
            RealseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void icbtn_Usuario_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Usuario());
            Activarboton(sender);
        }

        private void icbtn_modificarUsuario_Click(object sender, EventArgs e)
        {
            Activarboton(sender);
            //AbrirFormularioHijo(new ModificarProducto());
        }

        private void icbtnEgresos_Click(object sender, EventArgs e)
        {
            //AbrirFormularioHijo(new VerCategorias());
            Activarboton(sender);
        }

        private void icbtn_Ingresos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Total_Ingresos());
            Activarboton(sender);
        }

        private void icbtn_saldo_total_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Saldo_total());
            Activarboton(sender);
        }

        private void icbtn_Ofrendas_Click(object sender, EventArgs e)
        {
            Activarboton(sender);
        }

        private void icbtn_Diezmo_Click(object sender, EventArgs e)
        {
            Activarboton(sender);
        }

        private void icbtn_Varios_Click(object sender, EventArgs e)
        {
            Activarboton(sender);
        }

        private void icbtn_Pagos_basicos_Click(object sender, EventArgs e)
        {
            Activarboton(sender);
        }

        private void icbtn_Ofrenda_Pastoral_Click(object sender, EventArgs e)
        {
            Activarboton(sender);
        }

        private void icbtn_Egresos_varios_Click(object sender, EventArgs e)
        {
            Activarboton(sender);
        }

        private void icbtn_reporte_Click(object sender, EventArgs e)
        {
            Activarboton(sender);
        }

        private void icbtn_iglesia_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
