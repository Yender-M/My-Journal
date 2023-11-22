using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace My_Journal
{
    public partial class Egresos_Varios: Form
    {
        float precioGramoMaterial = 0, porcenImpresion = 0, pesoProducto = 0, luz = 0, costo_material = 0, costoProducto = 0, porcen_venta = 0, total = 0, comision = 0;
        bool agregar = false;


        /*Crea la base de datos global*/
        BaseDeDatos bd = new BaseDeDatos();

        /*datatable global en private para leer los datos*/
        private DataTable dt = new DataTable();

        public Egresos_Varios()
        {
            int i;
            InitializeComponent();

            dgvVerEgresosVarios.DataSource = bd.SelectDataTable("select nombre_producto Nombre, nombre_categoria Categoria, nombre_material Material, costo_luz Luz, peso_producto Peso, total Precio from productos A inner join categoria B on A.id_categoria = B.id_categoria inner join material C on A.id_material = C.id_material; ");

            /*cargamdo los nombres de categoria al combobox*/
            dt = bd.SelectDataTable("SELECT nombre_categoria, estado from Categoria");
            for (i = 0;i<dt.Rows.Count;i++ )
            {
                /*if ((string)dt.Rows[i]["estado"] == "s")
                    cmbModCatProducto.Items.Add(dt.Rows[i]["nombre_categoria"]);*/
                
            }

            /*cargamdo los nombres de material al combobox*/
            dt = bd.SelectDataTable("SELECT nombre_material, estado from Material");
            for (i = 0; i < dt.Rows.Count; i++)
            {
                /*if((string)dt.Rows[i]["estado"] == "s")
                   // cmbModMatProducto.Items.Add(dt.Rows[i]["nombre_material"]);*/
            }
        }

        private void lineApellido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lineTelefono_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lineNomUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lineNombre_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lineDireccion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvVerUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Buscar_TextChanged(object sender, EventArgs e)
        {
            string buscarPorid;
            string dato = txtBuscar_egreVarios.Text;
            if (dato == "")
            {
                buscarPorid = "select nombre_producto Nombre, nombre_categoria Categoria, nombre_material Material, costo_luz Luz, peso_producto Peso, total Precio from productos A inner join categoria B on A.id_categoria = B.id_categoria inner join material C on A.id_material = C.id_material where A.estado = 's' ORDER BY id_productos ASC";
                //  buscarPorid = "select nombre_producto, id_categoria, id_material, peso_producto, total from Productos ORDER BY id_productos ASC";
            }
            else
            {
                buscarPorid = "select nombre_producto Nombre, nombre_categoria Categoria, nombre_material Material, costo_luz Luz, peso_producto Peso, total Precio from productos A inner join categoria B on A.id_categoria = B.id_categoria inner join material C on A.id_material = C.id_material where nombre_producto LIKE '%" + dato + "%' ORDER BY nombre_producto ASC";
                // buscarPorid = "select nombre_producto, id_categoria, id_material, peso_producto, total from Productos where nombre_producto LIKE '%" + dato + "%' ORDER BY nombre_producto ASC";
            }

            dgvVerEgresosVarios.DataSource = bd.SelectDataTable(buscarPorid);
        }

     

        private void AgregarProducto_Load(object sender, EventArgs e)
        {

        }



        //evennto keypress para solo ingresar letras en el nombre del producto
        private async void txtbNombreProducto_KeyPress(object senderTxtb, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                await Task.Delay(1200);
            }
        }

        //evento keypress para solo pasar numeros a al peso y al costo_luz
        private void SoloNum(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && !(char.IsDigit(e.KeyChar)) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.')> -1))
            {
                e.Handled = true;
            }
        }
        // evento keyup que realiza los  calculos
        public void calculos(object sender, KeyEventArgs e)
        {
            //string dato = cmbModMatProducto.Text, buscar;

            /*if (txtbModPesoProducto.Text != "" && dato != "")
            {
                pesoProducto = float.Parse(txtbModPesoProducto.Text);
                buscar = "SELECT precio_gramo FROM Material where nombre_material LIKE '%" + dato + "%'";
                dt = bd.SelectDataTable(buscar);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    precioGramoMaterial = (float)dt.Rows[i]["precio_gramo"];
                }

                costo_material = precioGramoMaterial * pesoProducto;
            }*/

            if(pesoProducto>0 && pesoProducto<50)
            {
                comision = 10;
            }
            else if(pesoProducto>50)
            {
                comision = 15;
            }

           /* if (txtApellido.Text != "")
            {
                luz = float.Parse(txtApellido.Text);
                porcenImpresion = (float)(0.2 + 1); // 20% de impresion por producto*//*
                costoProducto = (luz + costo_material) * porcenImpresion;
            }
            porcen_venta = (float)(costoProducto * 0.75); // 75% de ganancia en todoso los productos
            total = costoProducto + porcen_venta + comision;*/

            //txtbModPrecioTotal.Text = Convert.ToString(total);
        }

        /*Buscar la id del material y de la categoria*/
        int id_categoria()
        {
            int id_cat = 0;
            /*string dato = this.cmbModCatProducto.Text, buscar;

            buscar = "SELECT id_categoria FROM Categoria where nombre_categoria LIKE '%" + dato + "%'";
            dt = bd.SelectDataTable(buscar);*/

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id_cat = (int)dt.Rows[i]["id_categoria"];
            }

            return id_cat;
        }
        int id_material()
        {
            int id_mat = 0;
            /*string dato = this.cmbModMatProducto.Text, buscar;

            buscar = "SELECT id_material FROM Material where nombre_material LIKE '%" + dato + "%'";
            dt = bd.SelectDataTable(buscar);*/

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id_mat = (int)dt.Rows[i]["id_material"];
            }

            return id_mat;
        }

        // agregar a la base de datos
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            /*if (txtNombre.Text == "" || txtApellido.Text == "" || txtbModPesoProducto.Text == "" || string.IsNullOrEmpty(cmbModMatProducto.Text) || string.IsNullOrEmpty(cmbModCatProducto.Text))
            {
                
            }
            else
            {
                //erroragregar.SetError(btnAgregarProducto, "");
                int id_mat = id_material(), id_cat = id_categoria();
                string Cadena;

                Cadena = "INSERT INTO Productos (nombre_producto, id_categoria, id_material, porcent_impresion, peso_producto, costo_luz, costo_material, costo_producto, porcentaje_venta, comision_venta, total, estado) VALUES ('" + txtNombre.Text + "', " + id_cat +" ," + id_mat + "," + porcenImpresion + ", " + pesoProducto + "," + luz + "," + precioGramoMaterial + "," + costoProducto + "," + porcen_venta + "," + comision + "," + total + ", 's');";
             
                if (!string.IsNullOrEmpty(Cadena))// quitar en caso de no querer insertar un producto a la base de datos
                {
                    if (!bd.executecommand(Cadena))
                    {
                        MessageBox.Show("Error al ingresar producto");
                    }
                    else
                    {
                        MessageBox.Show("Producto ingresado con exito");
                        /*errornombre.SetError(txtNombreProducto, "");
                        errorluz.SetError(txtApellito, "");
                        errorPeso.SetError(txtbModPesoProducto, "");
                        errormaterial.SetError(cmbModMatProducto, "");
                        errorcategoria.SetError(cmbModCatProducto, "");
                        erroragregar.SetError(btnAgregarProducto, "");
                    }
                    
                }

                agregar = true;

               /* this.txtApellido.Text = "";
                this.txtbModPesoProducto.Text = "";
                this.cmbModCatProducto.SelectedIndex = -1;
                this.cmbModMatProducto.SelectedIndex = -1;
                this.txtbModPrecioTotal.Text = "0.0";
                this.txtNombre.Text = "";
                dgvVerUsuarios.DataSource = bd.SelectDataTable("select nombre_producto Nombre, nombre_categoria Categoria, nombre_material Material, costo_luz Luz, peso_producto Peso, total Precio from productos A inner join categoria B on A.id_categoria = B.id_categoria inner join material C on A.id_material = C.id_material; ");
            }
        }
        private void validarCampos(object sender, MouseEventArgs e)
        {
            if (!agregar)
            {
                if (txtNombre.Text == "")
                {
                    //errornombre.SetError(txtNombreProducto, "Debe llenar este campo");
                }
                if (txtApellido.Text == "")
                {
                    //errorluz.SetError(txtApellito, "Debe llenar este campo");
                }
                /*if (txtbModPesoProducto.Text == "")
                {
                    //errorPeso.SetError(txtbModPesoProducto, "Debe llenar este campo");
                }*/
                /*if (string.IsNullOrEmpty(cmbModMatProducto.Text))
                {
                    //errormaterial.SetError(cmbModMatProducto, "Debe selecionar uno de los campos");
                }
                if (string.IsNullOrEmpty(cmbModCatProducto.Text))
                {
                    //errorcategoria.SetError(cmbModCatProducto, "Debe selecionar uno de los campos");
                }
            }
            agregar = false;
        }

        private void validar(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                //errornombre.SetError(txtNombreProducto, "");
            }
            if (txtApellido.Text != "")
            {
                //errorluz.SetError(txtApellito, "");
            }
            /*if (txtbModPesoProducto.Text != "")
            {
                //errorPeso.SetError(txtbModPesoProducto, "");
            }
            if(cmbModCatProducto.Text != "")
            {
                //errorcategoria.SetError(cmbModCatProducto, "");
            }
            if (cmbModMatProducto.Text != "")
            {
                //errormaterial.SetError(cmbModMatProducto, "");
            }*/
        }
    }
}
