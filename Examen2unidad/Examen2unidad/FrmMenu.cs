using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Examen2unidad
{
    public partial class FrmMenu : Syncfusion.Windows.Forms.Office2010Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        FrmUsuarios frmUsuarios = null;
        FrmProducto frmProducto = null;
        FrmFactura frmFactura = null;

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void UsuariostoolStripButton1_Click(object sender, EventArgs e)
        {
            if (frmUsuarios == null)
            {
                frmUsuarios = new FrmUsuarios();
                frmUsuarios.MdiParent = this;
                frmUsuarios.FormClosed += FrmUsuarios_FormClosed;
                frmUsuarios.Show();
            }
            else
            {
                frmUsuarios.Activate();
            }

            
        }

        private void FrmUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmUsuarios = null;
        }

        private void ListaProductostoolStripButton1_Click(object sender, EventArgs e)
        {
            if (frmProducto == null)
            {
                frmProducto = new FrmProducto();
                frmProducto.MdiParent = this;
                frmProducto.FormClosed += FrmProducto_FormClosed;
                frmProducto.Show();
            }
            else
            {
                frmProducto.Activate();
            }
        }

        private void FrmProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmProducto = null;
        }

        private void NuevaFacturatoolStripButton1_Click(object sender, EventArgs e)
        {
            if (frmFactura == null)
            {
                frmFactura = new FrmFactura();
                frmFactura.MdiParent = this;
                frmFactura.FormClosed += FrmFactura_FormClosed;
                frmFactura.Show();
            }
            else
            {
                frmFactura.Activate();
            }
        }

        private void FrmFactura_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmFactura = null;
        }
    }
}
