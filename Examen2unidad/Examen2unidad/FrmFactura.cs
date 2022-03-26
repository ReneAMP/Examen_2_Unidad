using Datos.Accesos;
using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2unidad
{
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }

        ProductoDA productoDA = new ProductoDA();
        Factura factura = new Factura();
        Producto producto;
        FacturaDA facturaDA = new FacturaDA();

        List<DetalleFactura> detalleFacturaLista = new List<DetalleFactura>();

        decimal subTotal = decimal.Zero;
        decimal isv = decimal.Zero;
        decimal totalAPagar = decimal.Zero;

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            DetalledataGridView1.DataSource = detalleFacturaLista;
        }

        private void CodigoProductotextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                producto = new Producto();
                producto = productoDA.GetProductoPorCodigo(CodigoProductotextBox2.Text);
                DescripcionProductotextBox1.Text = producto.Descripcion;
                CantidadtextBox1.Focus();
            }
            else
            {
                producto = null;
                DescripcionProductotextBox1.Clear();
                CantidadtextBox1.Clear();
            }
        }

        private void CantidadtextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadtextBox1.Text))
            {
                DetalleFactura detalleFactura = new DetalleFactura();
                detalleFactura.CodigoProducto = producto.Codigo;
                detalleFactura.Descripcion = producto.Descripcion;
                detalleFactura.Cantidad = Convert.ToInt32(CantidadtextBox1.Text);
                detalleFactura.Precio = producto.Precio;
                detalleFactura.Total = producto.Precio * Convert.ToInt32(CantidadtextBox1.Text);

                subTotal += detalleFactura.Total;
                isv = subTotal * 0.15M;
                totalAPagar = subTotal + isv;

                SubtotaltextBox2.Text = subTotal.ToString();
                ISVtextBox1.Text = isv.ToString();
                TotaltextBox3.Text = totalAPagar.ToString();

                detalleFacturaLista.Add(detalleFactura);
                DetalledataGridView1.DataSource = null;
                DetalledataGridView1.DataSource = detalleFacturaLista;
            }
        }

        private void Guardarbutton1_Click(object sender, EventArgs e)
        {
            factura.IdentidadCliente = IdentidadmaskedTextBox1.Text;
            factura.Cliente = NombretextBox1.Text;
            factura.Fecha = FechadateTimePicker1.Value;
            factura.SubTotal = Convert.ToDecimal(SubtotaltextBox2.Text);
            factura.ISV = Convert.ToDecimal(TotaltextBox3.Text);
            factura.Total = Convert.ToDecimal(TotaltextBox3.Text);

            int idFactura = 0;

            idFactura = facturaDA.InsertarFactura(factura);

            if (idFactura != 0)
            {
                foreach (var item in detalleFacturaLista)
                {
                    item.IdFactura = idFactura;
                    facturaDA.InsertarDetalle(item);
                }
            }
        }
    }
}
