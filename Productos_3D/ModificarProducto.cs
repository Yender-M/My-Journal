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
    public partial class ModificarProducto : Form
    {
        float precioGramoMaterial = 0, porcenImpresion = 0, pesoProducto = 0, luz = 0, costo_material = 0, costoProducto = 0, porcen_venta = 0, total = 0, comision = 0;
        bool agregar = false;
        string NombreProValidar, estado = "s";
        string luztxt, peso;

        /*Crea la base de datos global*/
        BaseDeDatos bd = new BaseDeDatos();
        /*datatable global en private para leer los datos*/
        private DataTable dt = new DataTable();

        public ModificarProducto()
        {
            InitializeComponent();
            int i;
            dtgmodificarproducto.DataSource = bd.SelectDataTable("select nombre_producto Nombre, nombre_categoria Categoria, nombre_material Material, costo_luz Luz, peso_producto Peso, A.estado Estado, total Precio from productos A inner join categoria B on A.id_categoria = B.id_categoria inner join material C on A.id_material = C.id_material; ");
            /*cargamdo los nombres de categoria al combobox*/
            dt = bd.SelectDataTable("SELECT nombre_categoria, estado from Categoria");
            for (i = 0; i < dt.Rows.Count; i++)
            {
                if ((string)dt.Rows[i]["estado"] == "s")
                    cmbModCatProducto.Items.Add(dt.Rows[i]["nombre_categoria"]);
            }
            /*cargamdo los nombres de material al combobox*/
            dt = bd.SelectDataTable("SELECT nombre_material, estado from Material");
            for (i = 0; i < dt.Rows.Count; i++)
            {
                if ((string)dt.Rows[i]["estado"] == "s")
                    cmbModMatProducto.Items.Add(dt.Rows[i]["nombre_material"]);
            }
            todo_falso();
        }

        private void todo_falso()
        {
            txtbModCostoLuz.Enabled = false;
            txtbModPesoProducto.Enabled = false;
            txtbModNomProducto.Enabled = false;
            cmbModCatProducto.Enabled = false;
            cmbModMatProducto.Enabled = false;
            checkModEstadoProducto.Enabled = false;
        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            string buscarPorid;
            string dato = Buscar.Text;
            if (dato == "")
            {
                buscarPorid = "select nombre_producto Nombre, nombre_categoria Categoria, nombre_material Material, costo_luz Luz, peso_producto Peso, A.estado Estado, total Precio from productos A inner join categoria B on A.id_categoria = B.id_categoria inner join material C on A.id_material = C.id_material ORDER BY id_productos ASC";
                //  buscarPorid = "select nombre_producto, id_categoria, id_material, peso_producto, total from Productos ORDER BY id_productos ASC";
            }
            else
            {
                buscarPorid = "select nombre_producto Nombre, nombre_categoria Categoria, nombre_material Material, costo_luz Luz, peso_producto Peso, A.estado Estado, total Precio from productos A inner join categoria B on A.id_categoria = B.id_categoria inner join material C on A.id_material = C.id_material where nombre_producto LIKE '%" + dato + "%' ORDER BY nombre_producto ASC";
                // buscarPorid = "select nombre_producto, id_categoria, id_material, peso_producto, total from Productos where nombre_producto LIKE '%" + dato + "%' ORDER BY nombre_producto ASC";
            }

            dtgmodificarproducto.DataSource = bd.SelectDataTable(buscarPorid);
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            if (txtbModNomProducto.Text == "" || txtbModCostoLuz.Text == "" || txtbModPesoProducto.Text == "" || string.IsNullOrEmpty(cmbModMatProducto.Text) || string.IsNullOrEmpty(cmbModCatProducto.Text))
            {
                erroractualizar.SetError(btnActualizarProducto, "Uno o varios campos aun no llenos");
            }
            else
            {
                if(checkModEstadoProducto.Checked == false)
                {
                    estado = "n";
                }
                erroractualizar.SetError(btnActualizarProducto, "");
                int id_mat = id_material(), id_cat = id_categoria();
                string NombreProValidar = (string)dtgmodificarproducto.CurrentRow.Cells["Nombre"].Value;
                string Cadena;
                Cadena =  "UPDATE `Productos` SET nombre_producto = '" + this.txtbModNomProducto.Text + "',id_categoria = " + id_cat + " ,id_material = " + id_mat + ",porcent_impresion = " + porcenImpresion + " ,peso_producto = " + pesoProducto + ",costo_luz = " + luz + ",costo_material = " + costo_material + " ,costo_producto = " + costoProducto + ",porcentaje_venta = " + porcen_venta + ",comision_venta = " + comision + ",total = " + total + ",estado = '"+ estado+"' where nombre_producto = '" + NombreProValidar + "';";
                //Cadena = "INSERT INTO Productos (nombre_producto, id_categoria, id_material, porcent_impresion, peso_producto, costo_luz, costo_material, costo_producto, porcentaje_venta, comision_venta, total, estado) VALUES ('" + txtbModNomProducto.Text + "', " + id_cat + " ," + id_mat + "," + porcenImpresion + ", " + pesoProducto + "," + luz + "," + precioGramoMaterial + "," + costoProducto + "," + porcen_venta + "," + comision + "," + total + ", 's');";

                if (!string.IsNullOrEmpty(Cadena))// quitar en caso de no querer insertar un producto a la base de datos
                {
                    if (!bd.executecommand(Cadena))
                    {
                        MessageBox.Show("Error al actualizar producto");
                    }
                    else
                    {
                        MessageBox.Show("Producto actualizado con exito");
                        errornombre.SetError(txtbModNomProducto, "");
                        errorluz.SetError(txtbModCostoLuz, "");
                        errorPeso.SetError(txtbModPesoProducto, "");
                        erroractualizar.SetError(btnActualizarProducto, "");
                    }

                }
                agregar = true;

                this.txtbModCostoLuz.Text = "";
                this.txtbModPesoProducto.Text = "";
                this.cmbModCatProducto.SelectedIndex = -1;
                this.cmbModMatProducto.SelectedIndex = -1;
                this.txtTotalProducto.Text = "0.0";
                this.txtbModNomProducto.Text = "";
                dtgmodificarproducto.DataSource = bd.SelectDataTable("select nombre_producto Nombre, nombre_categoria Categoria, nombre_material Material, costo_luz Luz, peso_producto Peso, A.estado Estado, total Precio from productos A inner join categoria B on A.id_categoria = B.id_categoria inner join material C on A.id_material = C.id_material; ");
                todo_falso();
            }
        }

        /*Buscar la id del material y de la categoria y id del producto*/
        int id_categoria()
        {
            int id_cat = 0;
            string dato = this.cmbModCatProducto.Text, buscar;

            buscar = "SELECT id_categoria FROM Categoria where nombre_categoria LIKE '%" + dato + "%'";
            dt = bd.SelectDataTable(buscar);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id_cat = (int)dt.Rows[i]["id_categoria"];
            }

            return id_cat;
        }

        int id_material()
        {
            int id_mat = 0;
            string dato = this.cmbModMatProducto.Text, buscar;

            buscar = "SELECT id_material FROM Material where nombre_material LIKE '%" + dato + "%'";
            dt = bd.SelectDataTable(buscar);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id_mat = (int)dt.Rows[i]["id_material"];
            }

            return id_mat;
        }


        private void selecionar_todo(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            //cargamdo los nombres de material y categoria a la tabla
            string luztxt = txtbModCostoLuz.Text, peso = txtbModPesoProducto.Text;

            string id_categoria = (string)dtgmodificarproducto.CurrentRow.Cells["Categoria"].Value;
            string id_material = (string)dtgmodificarproducto.CurrentRow.Cells["Material"].Value;
            
            for (i = 0; i < cmbModCatProducto.Items.Count; i++)
            {
                if (cmbModCatProducto.Items[i].ToString() == id_categoria)
                {
                    cmbModCatProducto.SelectedIndex = i;
                }
            }
            for (i = 0; i < cmbModMatProducto.Items.Count; i++)
            {
                if (cmbModMatProducto.Items[i].ToString() == id_material)
                {
                    cmbModMatProducto.SelectedIndex = i;
                }
            }

            //nombre del producto
            txtbModNomProducto.Text = (string)dtgmodificarproducto.CurrentRow.Cells["Nombre"].Value;
            //peso producto
            txtbModPesoProducto.Text = ((float)dtgmodificarproducto.CurrentRow.Cells["Peso"].Value).ToString();
            //Total
            txtTotalProducto.Text = ((float)dtgmodificarproducto.CurrentRow.Cells["Precio"].Value).ToString();
            //luz
            txtbModCostoLuz.Text = ((float)dtgmodificarproducto.CurrentRow.Cells["Luz"].Value).ToString();
            //estado
            string estado = ((string)dtgmodificarproducto.CurrentRow.Cells["Estado"].Value);
            if (estado == "s")
            {
                checkModEstadoProducto.Checked = true;
            }
            else
            {
                checkModEstadoProducto.Checked = false;
            }
            txtbModCostoLuz.Enabled = true;
            txtbModPesoProducto.Enabled = true;
            txtbModNomProducto.Enabled = true;
            cmbModCatProducto.Enabled = true;
            cmbModMatProducto.Enabled = true;
            checkModEstadoProducto.Enabled = true;
        }

        private void Calculos(object sender, KeyEventArgs e)
        {
            string dato = cmbModMatProducto.Text, buscar;
            

            luz = Convert.ToInt32(luztxt);
            pesoProducto = Convert.ToInt32(peso);

            if (txtbModPesoProducto.Text != "" && dato != "")
            {
                pesoProducto = float.Parse(txtbModPesoProducto.Text);
                buscar = "SELECT precio_gramo FROM Material where nombre_material LIKE '%" + dato + "%'";
                dt = bd.SelectDataTable(buscar);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    precioGramoMaterial = (float)dt.Rows[i]["precio_gramo"];
                }

                costo_material = precioGramoMaterial * pesoProducto;
            }

            if (pesoProducto > 0 && pesoProducto < 50)
            {
                comision = 10;
            }
            else if (pesoProducto > 50)
            {
                comision = 15;
            }

            if (txtbModCostoLuz.Text != "")
            {
                luz = float.Parse(txtbModCostoLuz.Text);
                porcenImpresion = (float)(0.2 + 1); // 20% de impresion por producto
                costoProducto = (luz + costo_material) * porcenImpresion;
            }
            porcen_venta = (float)(costoProducto * 0.75); // 75% de ganancia en todoso los productos
            total = costoProducto + porcen_venta + comision;

            txtTotalProducto.Text = Convert.ToString(total);
        }


        private void soloNum(object sender, KeyPressEventArgs e)
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

        private void valirCampos(object sender, MouseEventArgs e)
        {
            if (!agregar)
            {
                if (txtbModNomProducto.Text == "")
                {
                    errornombre.SetError(txtbModNomProducto, "Debe llenar este campo con un nombre");
                }
                if (txtbModCostoLuz.Text == "")
                {
                    errorluz.SetError(txtbModCostoLuz, "Debe llenar este campo con el costo de luz");
                }
                if (txtbModPesoProducto.Text == "")
                {
                    errorPeso.SetError(txtbModPesoProducto, "Debe llenar este campo con el peso del producto");
                }
            }
            agregar = false;
        }

        private void validar(object sender, EventArgs e)
        {
            if (txtbModNomProducto.Text != "")
            {
                errornombre.SetError(txtbModNomProducto, "");
            }
            if (txtbModCostoLuz.Text != "")
            {
                errorluz.SetError(txtbModCostoLuz, "");
            }
            if (txtbModPesoProducto.Text != "")
            {
                errorPeso.SetError(txtbModPesoProducto, "");
            }
        }
    }
}
