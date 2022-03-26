namespace Examen2unidad
{
    partial class FrmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CodigotextBox1 = new System.Windows.Forms.TextBox();
            this.DescripciontextBox2 = new System.Windows.Forms.TextBox();
            this.PreciotextBox3 = new System.Windows.Forms.TextBox();
            this.ExistenciatextBox4 = new System.Windows.Forms.TextBox();
            this.BuscarImagenbutton1 = new System.Windows.Forms.Button();
            this.Cancelarbutton5 = new System.Windows.Forms.Button();
            this.Eliminarbutton4 = new System.Windows.Forms.Button();
            this.Guardarbutton3 = new System.Windows.Forms.Button();
            this.Modificarbutton2 = new System.Windows.Forms.Button();
            this.Nuevobutton1 = new System.Windows.Forms.Button();
            this.ProductosdataGridView1 = new System.Windows.Forms.DataGridView();
            this.ImagenpictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenpictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencia:";
            // 
            // CodigotextBox1
            // 
            this.CodigotextBox1.Enabled = false;
            this.CodigotextBox1.Location = new System.Drawing.Point(142, 53);
            this.CodigotextBox1.MaxLength = 45;
            this.CodigotextBox1.Name = "CodigotextBox1";
            this.CodigotextBox1.Size = new System.Drawing.Size(196, 22);
            this.CodigotextBox1.TabIndex = 4;
            // 
            // DescripciontextBox2
            // 
            this.DescripciontextBox2.Enabled = false;
            this.DescripciontextBox2.Location = new System.Drawing.Point(142, 87);
            this.DescripciontextBox2.Name = "DescripciontextBox2";
            this.DescripciontextBox2.Size = new System.Drawing.Size(196, 22);
            this.DescripciontextBox2.TabIndex = 5;
            // 
            // PreciotextBox3
            // 
            this.PreciotextBox3.Enabled = false;
            this.PreciotextBox3.Location = new System.Drawing.Point(142, 120);
            this.PreciotextBox3.Name = "PreciotextBox3";
            this.PreciotextBox3.Size = new System.Drawing.Size(196, 22);
            this.PreciotextBox3.TabIndex = 6;
            this.PreciotextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreciotextBox3_KeyPress);
            // 
            // ExistenciatextBox4
            // 
            this.ExistenciatextBox4.Enabled = false;
            this.ExistenciatextBox4.Location = new System.Drawing.Point(142, 153);
            this.ExistenciatextBox4.Name = "ExistenciatextBox4";
            this.ExistenciatextBox4.Size = new System.Drawing.Size(196, 22);
            this.ExistenciatextBox4.TabIndex = 7;
            this.ExistenciatextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExistenciatextBox4_KeyPress);
            // 
            // BuscarImagenbutton1
            // 
            this.BuscarImagenbutton1.Enabled = false;
            this.BuscarImagenbutton1.Location = new System.Drawing.Point(484, 181);
            this.BuscarImagenbutton1.Name = "BuscarImagenbutton1";
            this.BuscarImagenbutton1.Size = new System.Drawing.Size(25, 24);
            this.BuscarImagenbutton1.TabIndex = 9;
            this.BuscarImagenbutton1.Text = "...";
            this.BuscarImagenbutton1.UseVisualStyleBackColor = true;
            this.BuscarImagenbutton1.Click += new System.EventHandler(this.BuscarImagenbutton1_Click);
            // 
            // Cancelarbutton5
            // 
            this.Cancelarbutton5.Enabled = false;
            this.Cancelarbutton5.Location = new System.Drawing.Point(405, 214);
            this.Cancelarbutton5.Name = "Cancelarbutton5";
            this.Cancelarbutton5.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton5.TabIndex = 18;
            this.Cancelarbutton5.Text = "Cancelar";
            this.Cancelarbutton5.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton4
            // 
            this.Eliminarbutton4.Location = new System.Drawing.Point(323, 215);
            this.Eliminarbutton4.Name = "Eliminarbutton4";
            this.Eliminarbutton4.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton4.TabIndex = 17;
            this.Eliminarbutton4.Text = "Eliminar";
            this.Eliminarbutton4.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton3
            // 
            this.Guardarbutton3.Enabled = false;
            this.Guardarbutton3.Location = new System.Drawing.Point(242, 215);
            this.Guardarbutton3.Name = "Guardarbutton3";
            this.Guardarbutton3.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton3.TabIndex = 16;
            this.Guardarbutton3.Text = "Guardar";
            this.Guardarbutton3.UseVisualStyleBackColor = true;
            this.Guardarbutton3.Click += new System.EventHandler(this.Guardarbutton3_Click);
            // 
            // Modificarbutton2
            // 
            this.Modificarbutton2.Location = new System.Drawing.Point(161, 215);
            this.Modificarbutton2.Name = "Modificarbutton2";
            this.Modificarbutton2.Size = new System.Drawing.Size(75, 23);
            this.Modificarbutton2.TabIndex = 15;
            this.Modificarbutton2.Text = "Modificar";
            this.Modificarbutton2.UseVisualStyleBackColor = true;
            this.Modificarbutton2.Click += new System.EventHandler(this.Modificarbutton2_Click);
            // 
            // Nuevobutton1
            // 
            this.Nuevobutton1.Location = new System.Drawing.Point(80, 215);
            this.Nuevobutton1.Name = "Nuevobutton1";
            this.Nuevobutton1.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton1.TabIndex = 14;
            this.Nuevobutton1.Text = "Nuevo";
            this.Nuevobutton1.UseVisualStyleBackColor = true;
            this.Nuevobutton1.Click += new System.EventHandler(this.Nuevobutton1_Click);
            // 
            // ProductosdataGridView1
            // 
            this.ProductosdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosdataGridView1.Location = new System.Drawing.Point(12, 251);
            this.ProductosdataGridView1.Name = "ProductosdataGridView1";
            this.ProductosdataGridView1.Size = new System.Drawing.Size(506, 150);
            this.ProductosdataGridView1.TabIndex = 19;
            // 
            // ImagenpictureBox1
            // 
            this.ImagenpictureBox1.BackColor = System.Drawing.Color.White;
            this.ImagenpictureBox1.Location = new System.Drawing.Point(378, 53);
            this.ImagenpictureBox1.Name = "ImagenpictureBox1";
            this.ImagenpictureBox1.Size = new System.Drawing.Size(131, 122);
            this.ImagenpictureBox1.TabIndex = 8;
            this.ImagenpictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 413);
            this.Controls.Add(this.ProductosdataGridView1);
            this.Controls.Add(this.Cancelarbutton5);
            this.Controls.Add(this.Eliminarbutton4);
            this.Controls.Add(this.Guardarbutton3);
            this.Controls.Add(this.Modificarbutton2);
            this.Controls.Add(this.Nuevobutton1);
            this.Controls.Add(this.BuscarImagenbutton1);
            this.Controls.Add(this.ImagenpictureBox1);
            this.Controls.Add(this.ExistenciatextBox4);
            this.Controls.Add(this.PreciotextBox3);
            this.Controls.Add(this.DescripciontextBox2);
            this.Controls.Add(this.CodigotextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenpictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CodigotextBox1;
        private System.Windows.Forms.TextBox DescripciontextBox2;
        private System.Windows.Forms.TextBox PreciotextBox3;
        private System.Windows.Forms.TextBox ExistenciatextBox4;
        private System.Windows.Forms.PictureBox ImagenpictureBox1;
        private System.Windows.Forms.Button BuscarImagenbutton1;
        private System.Windows.Forms.Button Cancelarbutton5;
        private System.Windows.Forms.Button Eliminarbutton4;
        private System.Windows.Forms.Button Guardarbutton3;
        private System.Windows.Forms.Button Modificarbutton2;
        private System.Windows.Forms.Button Nuevobutton1;
        private System.Windows.Forms.DataGridView ProductosdataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}