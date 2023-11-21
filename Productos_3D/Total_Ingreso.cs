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
    public partial class Total_Ingresos : Form
    {
        int i;
        bool agregar = false;

        /*Crea la base de datos global*/
        BaseDeDatos bd = new BaseDeDatos();
        /*datatable global en private para leer los datos*/
        private DataTable dt = new DataTable();

        public Total_Ingresos()
        {
            InitializeComponent();
            cargar_factura();
            /*cargamdo los nombres de los productos al combobox*/
            dt = bd.SelectDataTable("SELECT nombre_producto, estado from productos");
            for (i = 0; i < dt.Rows.Count; i++)
            {
                if ((string)dt.Rows[i]["estado"] == "s")
                {
                    //cmbProducto.Items.Add(dt.Rows[i]["nombre_producto"]);
                }     
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblhora.Text = DateTime.Now.ToString("h:mm:ss");
            //lblfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void SoloNum(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsControl(e.KeyChar)) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void llenar_campos(object sender, EventArgs e)
        {
            dt = bd.SelectDataTable("select nombre_producto, nombre_categoria, nombre_material, peso_producto, total  from productos A inner join categoria B on A.id_categoria = B.id_categoria inner join material C on A.id_material = C.id_material where nombre_producto = '");
            for (i = 0; i < dt.Rows.Count; i++)
            {
               /* if ((string)dt.Rows[i]["nombre_producto"] == cmbProducto.Text)
                {
                    txtmaterial.Text = Convert.ToString(dt.Rows[i]["nombre_material"]);
                    txtcategoria.Text = Convert.ToString(dt.Rows[i]["nombre_categoria"]);
                    txtpeso.Text = Convert.ToString(dt.Rows[i]["peso_producto"]);
                    txtprecioUni.Text = Convert.ToString(dt.Rows[i]["total"]);
                }*/
            }
        }

        /*Cargar numero_factura*/
        private void cargar_factura()
        {
            int id = 0, id_final = 0;
            string buscar;

            buscar = "SELECT id_factura FROM venta";
            dt = bd.SelectDataTable(buscar);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["id_factura"] != null)
                {
                    id = (int)dt.Rows[i]["id_factura"];
                }
            }
            if (id != 0)
            {
                id_final = id + 1;
            }
            else
            {
                id_final = 1;
            }

           // txtNumeroFactura.Text = id_final.ToString();
        }

        private void validarCampos(object sender, MouseEventArgs e)
        {
            /*if (!agregar)
            {
                if (cmbProducto.Text == "")
                {
                    errorproducto.SetError(cmbProducto, "Debe llenar este campo");
                }
                if (txtCantidad.Text == "")
                {
                    errorcantidad.SetError(txtCantidad, "Debe llenar este campo");
                }
            }
            agregar = false;
            erroragregar.SetError(btnAgregarCesta, "");*/
        }

        private void validar(object sender, EventArgs e)
        {
           /* if (cmbProducto.Text != "")
            {
                errorproducto.SetError(cmbProducto, "");
            }
            if (txtCantidad.Text != "")
            {
                errorcantidad.SetError(txtCantidad, "");
            }*/
        }

        private void btnAgregarCesta_Click(object sender, EventArgs e)
        {
            float total1 = 0, total_final = 0;
            
           /* if(cmbProducto.Text == "" || txtCantidad.Text == "")
            {
                erroragregar.SetError(btnAgregarCesta, "Uno o varios campos aun no llenos");
            }
            else
            {
                float totalPro = 0, cantidad = 0, precioproducto =0 ;
                cantidad = float.Parse(txtCantidad.Text);
                if (cantidad == 0)
                {
                    errorcantidad.SetError(txtCantidad, "La cantidad no puede ser cero");
                }
                else
                {
                    errorcantidad.SetError(txtCantidad, "");
                    string nombre = null, peso = null, total = null;

                    dt = bd.SelectDataTable("select nombre_producto, nombre_categoria, nombre_material, peso_producto, total  from productos A inner join categoria B on A.id_categoria = B.id_categoria inner join material C on A.id_material = C.id_material where nombre_producto = '" + cmbProducto.Text + "'; ");
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        nombre = dt.Rows[i]["nombre_producto"].ToString();
                        peso = dt.Rows[i]["peso_producto"].ToString();
                        total = dt.Rows[i]["total"].ToString();
                    }
                    
                     precioproducto = float.Parse(total);
                     totalPro = cantidad * precioproducto;
                     dgvVenta.Rows.Add(nombre, peso, total, cantidad, totalPro);
                   
                    
                    cmbProducto.SelectedIndex = -1;
                    txtCantidad.Text = "";
                    txtmaterial.Text = "";
                    txtcategoria.Text = "";
                    txtpeso.Text = "";
                    txtprecioUni.Text = "";
                    errorproducto.SetError(cmbProducto, "");
                    errorcantidad.SetError(txtCantidad, "");
                }
                agregar = true;
                numero_compras();
                //suma todo lo que hay en la columna total

                for (int i = 0; i < dgvVenta.Rows.Count; i++)
                {
                    if (dgvVenta.Rows[i].Cells["total_producto"].Value != null)
                    {
                        total1 = float.Parse(dgvVenta.Rows[i].Cells["total_producto"].Value.ToString());
                        total_final += total1;
                    }
                }
                txtTotalFactura.Text = total_final.ToString();*/
            }

        private void dgvVerTotal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

        /*numero de compras*/
        /*private void numero_compras()
        {
            int compras = dgvVenta.Rows.Count + 0;
            txtNumeroCompras.Text = compras.ToString();
        }*/


      /*  private void EliminarAlClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            float total1 = 0, total_final = 0;
            int pscCesta = 0;
            pscCesta = e.RowIndex;
            if (dgvVenta.CurrentRow.Cells["nom_producto"].Value != null)
            {
                dgvVenta.Rows.RemoveAt(pscCesta);
            }

            numero_compras();
            //suma todo lo que hay en la columna total

            for (int i = 0; i < dgvVenta.Rows.Count; i++)
            {
                if (dgvVenta.Rows[i].Cells["total_producto"].Value != null)
                {
                    total1 = float.Parse(dgvVenta.Rows[i].Cells["total_producto"].Value.ToString());
                    total_final += total1;
                }
            }
            txtTotalFactura.Text = total_final.ToString();
            pscCesta = -1;
        }*/

       /* private void btnRealizarCompra_Click(object sender, EventArgs e)
        {
            int id_pro;
            int numero_compras = Convert.ToInt32(txtNumeroCompras.Text);
            if (numero_compras == 0)
            {
                errorcompra.SetError(btnRealizarCompra, "No hay productos agegados a la cesta de compra");
            }
            else
            {
                string Cadena;
                
                for (int i = 0; i < dgvVenta.Rows.Count; i++)
                {
                    if (dgvVenta.Rows[i].Cells["nom_producto"].Value != null)
                    {
                        string validarnombre = dgvVenta.Rows[i].Cells["nom_producto"].Value.ToString();
                        dt = bd.SelectDataTable("select id_producto from productos where nombre_producto = '" + validarnombre+ "'; ");
                        id_pro = Convert.ToInt32(dt.Rows[i]["id_producto"]);
                        Cadena = "INSERT INTO `venta` (id_producto, id_factura, fecha, hora, precio_unitario, cantidad, total, total_factura, anulado) VALUES(" + id_pro + "," + txtNumeroFactura.Text + ",'"+lblfecha.Text + "',,'" + lblhora.Text + "'," + dgvVenta.Rows[i].Cells[3].Value + "," + dgvVenta.Rows[i].Cells[4].Value + "," + dgvVenta.Rows[i].Cells[5].Value + ","+ txtTotalFactura.Text +",'n')";
                        if (!bd.executecommand(Cadena)) // quitar en caso de no querer insertar un producto a la base de datos
                        {
                             MessageBox.Show("Error al agregar venta");
                        }
                        Console.WriteLine(Cadena); 
                    } 
                }
            }
        }*/
    }

