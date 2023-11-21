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
    public partial class RegistroVentas : Form
    {
        int id_venta= 0;
        /*Crea la base de datos global*/
        BaseDeDatos bd = new BaseDeDatos();
        /*datatable global en private para leer los datos*/
        private DataTable dt = new DataTable();
        public RegistroVentas()
        {
            InitializeComponent();
            dgvListaRegistroVentas.DataSource = bd.SelectDataTable("select * from Venta where anulado = 'n'");
        }

        /*Anular venta*/
        private void anular_venta()
        {
            string Cadena;

            if(id_venta != 0)
            {
                Cadena = "UPDATE `venta` SET anulado= 's' where id_factura = " + id_venta;
                if (!bd.executecommand(Cadena)) // quitar en caso de no querer insertar un producto a la base de datos
                    MessageBox.Show("Error anular venta");
                id_venta = 0;
                
            }
            else
            {
                Console.Write("Falta seleccionar venta");
            }

            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtVerEstadoVenta_Click(object sender, EventArgs e)
        {

        }

        private async void btnAnularMaterial_Click(object sender, EventArgs e)
        {
            if (id_venta != 0)
            {
                anular_venta();
                dgvListaRegistroVentas.DataSource = bd.SelectDataTable("select * from Venta where anulado = 'n'");
                this.txtAdvertencia.Text = "Venta anulada.";
                await Task.Delay(1200);
                this.txtAdvertencia.Text = "";
                this.txtVerNumeroVenta.Text = "Número de Venta";
                this.txtVerIDVenta.Text = "---";
                this.txtVerFechaRegistroVenta.Text = "---";
                this.txtVerIDProductoVenta.Text = "---";
                this.txtVerPreciouniVenta.Text = "---";
                this.txtVerCantidadVenta.Text = "---";
                this.txtVerTotalVenta.Text = "---";
                this.txtVerEstadoVenta.Text = "---";
                this.txtVerProductoVenta.Text = "---";
                id_venta = 0;
            }
            
        }

        private void dgvListaRegistroVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int temp = 0;
            if (int.TryParse(dgvListaRegistroVentas.CurrentRow.Cells[2].Value.ToString(), out temp))
            {
                id_venta =  Convert.ToInt32(dgvListaRegistroVentas.CurrentRow.Cells[2].Value);
            }
               
        }
    }
}
