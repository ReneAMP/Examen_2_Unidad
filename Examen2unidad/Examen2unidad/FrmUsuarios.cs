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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        UsuarioDA usuarioDA = new UsuarioDA();
        string operacion = string.Empty;
        Usuario user = new Usuario();

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            UsuariosdataGridView1.DataSource = usuarioDA.ListarUsuarios();
        }

        private void Nuevobutton1_Click(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void HabilitarControles()
        {
            CodigotextBox1.Enabled = true;
            NombretextBox2.Enabled = true;
            ClavetextBox4.Enabled = true;
            RolcomboBox.Enabled = true;

            Nuevobutton1.Enabled = false;
            Guardarbutton3.Enabled = true;
            Cancelarbutton5.Enabled = true;
        }

        private void DesabilitarControles()
        {
            CodigotextBox1.Enabled = false;
            NombretextBox2.Enabled = false;
            ClavetextBox4.Enabled = false;
            RolcomboBox.Enabled = false;

            Nuevobutton1.Enabled = true;
            Guardarbutton3.Enabled = false;
            Cancelarbutton5.Enabled = false;
        }

        private void LimpiarControles()
        {
            CodigotextBox1.Clear();
            NombretextBox2.Text = "";
            ClavetextBox4.Text = string.Empty;
            RolcomboBox.Text = string.Empty;
        }

        private void Guardarbutton3_Click(object sender, EventArgs e)
        {
            user.Codigo = CodigotextBox1.Text;
            user.Nombre = NombretextBox2.Text;
            user.Clave = ClavetextBox4.Text;
            user.Rol = RolcomboBox.Text;

            if (operacion == "Nuevo")
            {

                bool inserto = usuarioDA.InsertarUsuario(user);

                if (inserto)
                {
                    MessageBox.Show("Usuario Creado");
                    ListarUsuarios();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Usuario no se puede crear");
                }
            }
            else if (operacion == "Modificar")
            {
                bool modifico = usuarioDA.ModificarUsuario(user);
                if (modifico)
                {
                    MessageBox.Show("Usuario Modificado");
                    ListarUsuarios();
                    LimpiarControles();
                    DesabilitarControles();
                }
                else
                {
                    MessageBox.Show("Usuario no se puede modificar");
                }
            }
        }

        private void Modificarbutton2_Click(object sender, EventArgs e)
        {
            operacion = "Modificar";

            if (UsuariosdataGridView1.SelectedRows.Count > 0)
            {
                CodigotextBox1.Text = UsuariosdataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                NombretextBox2.Text = UsuariosdataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                ClavetextBox4.Text = UsuariosdataGridView1.CurrentRow.Cells["Clave"].Value.ToString();
                RolcomboBox.Text = UsuariosdataGridView1.CurrentRow.Cells["Rol"].Value.ToString();
                HabilitarControles();
            }
        }

        private void Eliminarbutton4_Click(object sender, EventArgs e)
        {
            if (UsuariosdataGridView1.SelectedRows.Count > 0)
            {
                bool elimino = usuarioDA.EliminarUsuario(UsuariosdataGridView1.CurrentRow.Cells["Codigo"].Value.ToString());
                if (elimino)
                {
                    MessageBox.Show("Usuario Eliminado");
                    ListarUsuarios();
                }
                else
                {
                    MessageBox.Show("Usuario no se puede eliminar");
                }

            }
        }

        private void Cancelarbutton5_Click(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }
    }
}
