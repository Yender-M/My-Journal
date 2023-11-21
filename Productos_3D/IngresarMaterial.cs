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
    public partial class IngresarMaterial : Form
    {
        bool agregar = false;
        float precio = 0, exitencia = 0, precio_gramo = 0;

        /*Crea la base de datos global*/
        BaseDeDatos bd = new BaseDeDatos();
        public IngresarMaterial()
        {
            InitializeComponent();
            dgvAgregarMaterial.DataSource = bd.SelectDataTable("select nombre_material Nombre, marca Marca, precio_gramo Precio_Gramo, precio_material Precio, existencia Existencia  from Material");
        }

        //evento keypress para solo pasar numeros a al peso y al costo_luz
        private void SoloNum(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && !(char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void solotex(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void validarCampos(object sender, MouseEventArgs e)
        {
            if (!agregar)
            {
                if (txtbIngMatNombre.Text == "")
                {
                    errornombre.SetError(txtbIngMatNombre, "Debe llenar este campo");
                }
                if (txtbIngMatMarca.Text == "")
                {
                    errormarca.SetError(txtbIngMatMarca, "Debe llenar este campo");
                }
                if (txtbIngMatPreciomaterial.Text == "")
                {
                    errorprecio.SetError(txtbIngMatPreciomaterial, "Debe llenar este campo");
                }
                if (txtbIngMatExistencia.Text == "")
                {
                    errorexistencia.SetError(txtbIngMatExistencia, "Debe llenar este campo");
                }
            }
            agregar = false;
        }

        private void calculos(object sender, KeyEventArgs e)
        {
            if (txtbIngMatPreciomaterial.Text != "" && txtbIngMatExistencia.Text != "")
            {
                precio = float.Parse(txtbIngMatPreciomaterial.Text);
                exitencia = float.Parse(txtbIngMatExistencia.Text);
                if (precio == 0)
                {
                    precio_gramo = 1;
                }
                if (exitencia > 1)
                {
                    precio_gramo = precio / exitencia;
                }
                else
                {
                    MessageBox.Show("La existencia no puede ser menor o igual a cero");
                }
            }
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            string buscarPorid;
            string dato = Buscar.Text;
            if (dato == "")
            {
                buscarPorid = "select nombre_material Nombre, marca Marca, precio_material Precio_kg, existencia Existencia  from Material ORDER BY id_material ASC";
                //  buscarPorid = "select nombre_producto, id_categoria, id_material, peso_producto, total from Productos ORDER BY id_productos ASC";
            }
            else
            {
                buscarPorid = "select nombre_material Nombre, marca Marca, precio_material Precio_kg, existencia Existencia  from Material  where nombre_material LIKE '%" + dato + "%' ORDER BY nombre_material ASC";
                // buscarPorid = "select nombre_producto, id_categoria, id_material, peso_producto, total from Productos where nombre_producto LIKE '%" + dato + "%' ORDER BY nombre_producto ASC";
            }

            dgvAgregarMaterial.DataSource = bd.SelectDataTable(buscarPorid);
        }

        private void txtVerNombreMaterial_Click(object sender, EventArgs e)
        {

        }

        private void validar(object sender, EventArgs e)
        {
            if (txtbIngMatNombre.Text != "")
            {
                errornombre.SetError(txtbIngMatNombre, "");
            }
            if (txtbIngMatMarca.Text != "")
            {
                errormarca.SetError(txtbIngMatMarca, "");
            }
            if (txtbIngMatPreciomaterial.Text != "")
            {
                errorprecio.SetError(txtbIngMatPreciomaterial, "");
            }
            if (txtbIngMatExistencia.Text != "")
            {
                errorexistencia.SetError(txtbIngMatExistencia, "");
            }
        }

        private void btnAgregarMaterial_Click(object sender, EventArgs e)
        {
            if (txtbIngMatNombre.Text == "" || txtbIngMatMarca.Text == "" || txtbIngMatExistencia.Text == "" || txtbIngMatPreciomaterial.Text == "")
            {
                erroragregar.SetError(btnAgregarMaterial, "Uno o varios campos aun no llenos");
            }
            else
            {
                erroragregar.SetError(btnAgregarMaterial, "");
                string Cadena;

                Cadena = "INSERT INTO `Material` (nombre_material, marca, precio_gramo, precio_material, existencia, estado) VALUES ('" + txtbIngMatNombre.Text + "','" + txtbIngMatMarca.Text + "'," + precio_gramo + "," + precio + "," + exitencia + ", 's');";

                if (!string.IsNullOrEmpty(Cadena))// quitar en caso de no querer insertar un producto a la base de datos
                {
                    if (!bd.executecommand(Cadena))
                    {
                        MessageBox.Show("Error al ingresar producto");
                    }
                    else
                    {
                        MessageBox.Show("Material ingresado con exito");
                        errornombre.SetError(txtbIngMatNombre, "");
                        errormarca.SetError(txtbIngMatMarca, "");
                        errorexistencia.SetError(txtbIngMatExistencia, "");
                        errorprecio.SetError(txtbIngMatPreciomaterial, "");
                    }

                }

                agregar = true;

                this.txtbIngMatPreciomaterial.Text = "0.0";
                this.txtbIngMatNombre.Text = "";
                this.txtbIngMatMarca.Text = "";
                this.txtbIngMatExistencia.Text = "";
                dgvAgregarMaterial.DataSource = bd.SelectDataTable("select nombre_material Nombre, marca Marca, precio_gramo Precio_Gramo, precio_material Precio, existencia Existencia  from Material");
            }
        }
    }
}
