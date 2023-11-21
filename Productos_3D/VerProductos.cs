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
    public partial class VerProductos : Form
    {
        /*Crea la base de datos global*/
        BaseDeDatos bd = new BaseDeDatos();
        /*datatable global en private para leer los datos*/
        private DataTable dt = new DataTable();

        /*Inicializa dgv*/
        public VerProductos()
        {
            InitializeComponent();
            dgvVerProductos.DataSource = bd.SelectDataTable("select nombre_producto Nombre, nombre_categoria Categoria, nombre_material Material, peso_producto Peso, total Precio from productos A inner join categoria B on A.id_categoria = B.id_categoria inner join material C on A.id_material = C.id_material where A.estado = 's'; ");
        }

        /*Slecciona y agarra datos del dgv*/
        private void dgvVerProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //nombre del producto
            txtNProducto.Text = (string)dgvVerProductos.CurrentRow.Cells["Nombre"].Value;
            //categoria del producto
            txtCategoriaProducto.Text = (string)dgvVerProductos.CurrentRow.Cells["Categoria"].Value;
            //material del producto
            txtMaterialProducto.Text = (string)dgvVerProductos.CurrentRow.Cells["Material"].Value;
            //peso producto
            txtPesoproducto.Text = ((float)dgvVerProductos.CurrentRow.Cells["Peso"].Value).ToString();
            //Total
            txtTotalProducto.Text = ((float)dgvVerProductos.CurrentRow.Cells["Precio"].Value).ToString();
        }

        /*Busqueda dinamica*/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string buscarPorid;
            string dato = Buscar.Text;
            if (dato == "")
            {
                buscarPorid = "select nombre_producto Nombre, nombre_categoria Categoria, nombre_material Material, peso_producto Peso, total Precio from productos A inner join categoria B on A.id_categoria = B.id_categoria inner join material C on A.id_material = C.id_material where A.estado = 's' ORDER BY id_productos ASC";
              //  buscarPorid = "select nombre_producto, id_categoria, id_material, peso_producto, total from Productos ORDER BY id_productos ASC";
            }
            else
            { 
                buscarPorid = "select nombre_producto Nombre, nombre_categoria Categoria, nombre_material Material, peso_producto Peso, total Precio from productos A inner join categoria B on A.id_categoria = B.id_categoria inner join material C on A.id_material = C.id_material where nombre_producto LIKE '%" + dato + "%' ORDER BY nombre_producto ASC";
               // buscarPorid = "select nombre_producto, id_categoria, id_material, peso_producto, total from Productos where nombre_producto LIKE '%" + dato + "%' ORDER BY nombre_producto ASC";
            }

            dgvVerProductos.DataSource = bd.SelectDataTable(buscarPorid);
        }

        private void solotex(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsWhiteSpace(e.KeyChar)) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }
}
