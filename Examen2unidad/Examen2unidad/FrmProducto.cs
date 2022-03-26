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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        string operacion = string.Empty;
        ProductoDA productoDA = new ProductoDA();

        private void Nuevobutton1_Click(object sender, EventArgs e)
        {
            operacion = "Nuevo";
            HabilitarControles();
        }

        private void HabilitarControles()
        {
            CodigotextBox1.Enabled = true;
            DescripciontextBox2.Enabled = true;
            PreciotextBox3.Enabled = true;
            ExistenciatextBox4.Enabled = true;
            BuscarImagenbutton1.Enabled = true;
            Guardarbutton3.Enabled = true;
            Cancelarbutton5.Enabled = true;
            Nuevobutton1.Enabled = false;
            Modificarbutton2.Enabled = false;
        }

        private void DesabilitarControles()
        {
            CodigotextBox1.Enabled = false;
            DescripciontextBox2.Enabled = false;
            PreciotextBox3.Enabled = false;
            ExistenciatextBox4.Enabled = false;
            BuscarImagenbutton1.Enabled = false;
            Guardarbutton3.Enabled = false;
            Cancelarbutton5.Enabled = false;
            Nuevobutton1.Enabled = true;
            Modificarbutton2.Enabled = true;
        }

        private void LimpiarControles()
        {
            CodigotextBox1.Clear();
            DescripciontextBox2.Clear();
            PreciotextBox3.Clear();
            ExistenciatextBox4.Clear();
            ImagenpictureBox1.Image = null ;
            
        }

        private void Guardarbutton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(CodigotextBox1.Text))
                {
                    errorProvider1.SetError(CodigotextBox1, "Ingrese el codigo");
                    CodigotextBox1.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(CodigotextBox1.Text))
                {
                    errorProvider1.SetError(DescripciontextBox2, "Ingrese una descripcion");
                    DescripciontextBox2.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(PreciotextBox3.Text))
                {
                    errorProvider1.SetError(PreciotextBox3, "Ingrese un precio");
                    PreciotextBox3.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(ExistenciatextBox4.Text))
                {
                    errorProvider1.SetError(ExistenciatextBox4, "Ingrese una existencia");
                    ExistenciatextBox4.Focus();
                    return;
                }

                Producto producto = new Producto();
                producto.Codigo = CodigotextBox1.Text;
                producto.Descripcion = DescripciontextBox2.Text;
                producto.Precio = (int)Convert.ToDecimal(PreciotextBox3.Text);
                producto.Existencia = Convert.ToInt32(ExistenciatextBox4.Text);

                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                ImagenpictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                producto.Imagen = ms.GetBuffer();

                if (operacion == "Nuevo")
                {
                    bool inserto = productoDA.InsertarProducto(producto);

                    if (inserto)
                    {
                        DesabilitarControles();
                        LimpiarControles();
                        ListarProductos();
                        MessageBox.Show("Producto Insertado");
                    }
                }
                else if (operacion == "Modificar")
                {
                    bool modifico = productoDA.ModificarProducto(producto);
                    if (modifico)
                    {
                        LimpiarControles();
                        DesabilitarControles();
                        ListarProductos();
                        MessageBox.Show("Producto Modificado");
                    }
                }
            }
            catch (Exception)
            {

          
            }
            
        }

        private void BuscarImagenbutton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                ImagenpictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void ListarProductos()
        {
            ProductosdataGridView1.DataSource = productoDA.ListarProductos();
        }

        private void PreciotextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1) 
            {
                e.Handled = true;
            }
        }

        private void ExistenciatextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void Modificarbutton2_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (ProductosdataGridView1.SelectedRows.Count > 0)
            {
                CodigotextBox1.Text = ProductosdataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                DescripciontextBox2.Text = ProductosdataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                PreciotextBox3.Text = ProductosdataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                ExistenciatextBox4.Text = ProductosdataGridView1.CurrentRow.Cells["Existencia"].Value.ToString();

                var temporal = productoDA.SeleccionarImagen(ProductosdataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());

                if (temporal.Length > 0)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(temporal);
                    ImagenpictureBox1.Image = System.Drawing.Image.FromStream(ms);
                }
                else
                {
                    ImagenpictureBox1.Image = null;
                }
                HabilitarControles();
                CodigotextBox1.Focus();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void Eliminarbutton4_Click(object sender, EventArgs e)
        {
            if (ProductosdataGridView1.SelectedRows.Count > 0)
            {
                bool elimino = productoDA.EliminarProducto(ProductosdataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());

                if (elimino)
                {
                    ListarProductos();
                    MessageBox.Show("Producto eliminado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede eliminar el producto", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto","Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Cancelarbutton5_Click(object sender, EventArgs e)
        {

        }
    }
}
