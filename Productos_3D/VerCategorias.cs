using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Journal
{
    public partial class VerCategorias : Form
    {
        /*Crea la base de datos global*/
        BaseDeDatos bd = new BaseDeDatos();
        /*datatable global en private para leer los datos*/
        private DataTable dt = new DataTable();
        public VerCategorias()
        {
            InitializeComponent();
            txtbVerNomCategoria.Enabled = true;
            btnActualizarCategoria.Enabled = false;
            dgvVerCategorias.DataSource = bd.SelectDataTable("select nombre_categoria Nombre, estado Estado from Categoria");
            todo_falso();
        }

        private void soloTexto(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void todo_falso()
        {
            checkModEstadoMaterial.Enabled = false;
        }
        private void dgvVerCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnActualizarCategoria.Enabled = true;

            txtbVerNomCategoria.Text = (string)dgvVerCategorias.CurrentRow.Cells["Nombre"].Value;
            string estado = ((string)dgvVerCategorias.CurrentRow.Cells["Estado"].Value);
            if (estado == "s")
            {
                checkModEstadoMaterial.Checked = true;
            }
            else
            {
                checkModEstadoMaterial.Checked = false;
            }

            txtbVerNomCategoria.Enabled = true;
            checkModEstadoMaterial.Enabled = true;
            btnAgregarCategoria.Enabled = false;
        }
        //Boton actualizar
        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            string estado = "s";
            if (txtbVerNomCategoria.Text == "")
            {
                erroractualizar.SetError(txtbVerNomCategoria, "El campo nombre aun no lleno");
            }
            else
            {
                if (checkModEstadoMaterial.Checked == false)
                {
                    estado = "n";
                }
                string categoria = (string)dgvVerCategorias.CurrentRow.Cells["Nombre"].Value;
                string Cadena = "UPDATE categoria SET nombre_categoria = '" + txtbVerNomCategoria.Text + "', estado = '" + estado + "'  where nombre_categoria = '" + categoria + "';";
                Console.WriteLine(Cadena);
                if (!string.IsNullOrEmpty(Cadena))// quitar en caso de no querer insertar un producto a la base de datos
                {
                    if (!bd.executecommand(Cadena))
                    {
                        MessageBox.Show("Error al actualizar Categoria");
                    }
                    else
                    {
                        MessageBox.Show("Categoria actualizado con exito");
                        errornombre.SetError(txtVerNombreMaterial, "");
                    }

                }

                dgvVerCategorias.DataSource = bd.SelectDataTable("select nombre_categoria Nombre, estado Estado from Categoria");
                txtbVerNomCategoria.Text = "";
                todo_falso();
                btnAgregarCategoria.Enabled = true;
                btnActualizarCategoria.Enabled = false;
            }
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string estado = "s";
            if (txtbVerNomCategoria.Text == "")
            {
                erroragregar.SetError(txtbVerNomCategoria, "El campo nombre aun no lleno");
            }
            else
            {
                string categoria = (string)dgvVerCategorias.CurrentRow.Cells["Nombre"].Value;
                string Cadena =  "INSERT INTO `categoria` (nombre_categoria, estado) VALUES ('" + txtbVerNomCategoria.Text + "', '"+estado+"');"; 

                if (!string.IsNullOrEmpty(Cadena))// quitar en caso de no querer insertar un producto a la base de datos
                {
                    if (!bd.executecommand(Cadena))
                    {
                        MessageBox.Show("Error al actualizar Categoria");
                    }
                    else
                    {
                        MessageBox.Show("Categoria ingresada con exito");
                        errornombre.SetError(txtVerNombreMaterial, "");
                    }

                }

                dgvVerCategorias.DataSource = bd.SelectDataTable("select nombre_categoria Nombre, estado Estado from Categoria");
                txtbVerNomCategoria.Text = "";
                todo_falso();
            }
        }

        private void validar(object sender, KeyEventArgs e)
        {
            if(txtbVerNomCategoria.Text != "")
            {
                errornombre.SetError(txtbVerNomCategoria, "");
                erroragregar.SetError(txtbVerNomCategoria, "");
                erroractualizar.SetError(txtbVerNomCategoria, "");
            }
        }
    }
}
