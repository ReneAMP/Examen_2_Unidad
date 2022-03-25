namespace Examen2unidad
{
    partial class FrmUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CodigotextBox1 = new System.Windows.Forms.TextBox();
            this.NombretextBox2 = new System.Windows.Forms.TextBox();
            this.ClavetextBox4 = new System.Windows.Forms.TextBox();
            this.RolcomboBox = new System.Windows.Forms.ComboBox();
            this.Nuevobutton1 = new System.Windows.Forms.Button();
            this.Modificarbutton2 = new System.Windows.Forms.Button();
            this.Guardarbutton3 = new System.Windows.Forms.Button();
            this.Eliminarbutton4 = new System.Windows.Forms.Button();
            this.Cancelarbutton5 = new System.Windows.Forms.Button();
            this.UsuariosdataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rol:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clave:";
            // 
            // CodigotextBox1
            // 
            this.CodigotextBox1.Enabled = false;
            this.CodigotextBox1.Location = new System.Drawing.Point(166, 58);
            this.CodigotextBox1.Name = "CodigotextBox1";
            this.CodigotextBox1.Size = new System.Drawing.Size(309, 20);
            this.CodigotextBox1.TabIndex = 4;
            // 
            // NombretextBox2
            // 
            this.NombretextBox2.Enabled = false;
            this.NombretextBox2.Location = new System.Drawing.Point(166, 98);
            this.NombretextBox2.Name = "NombretextBox2";
            this.NombretextBox2.Size = new System.Drawing.Size(309, 20);
            this.NombretextBox2.TabIndex = 5;
            // 
            // ClavetextBox4
            // 
            this.ClavetextBox4.Enabled = false;
            this.ClavetextBox4.Location = new System.Drawing.Point(166, 181);
            this.ClavetextBox4.Name = "ClavetextBox4";
            this.ClavetextBox4.Size = new System.Drawing.Size(309, 20);
            this.ClavetextBox4.TabIndex = 7;
            // 
            // RolcomboBox
            // 
            this.RolcomboBox.Enabled = false;
            this.RolcomboBox.FormattingEnabled = true;
            this.RolcomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.RolcomboBox.Location = new System.Drawing.Point(166, 140);
            this.RolcomboBox.Name = "RolcomboBox";
            this.RolcomboBox.Size = new System.Drawing.Size(309, 21);
            this.RolcomboBox.TabIndex = 8;
            // 
            // Nuevobutton1
            // 
            this.Nuevobutton1.Location = new System.Drawing.Point(110, 235);
            this.Nuevobutton1.Name = "Nuevobutton1";
            this.Nuevobutton1.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton1.TabIndex = 9;
            this.Nuevobutton1.Text = "Nuevo";
            this.Nuevobutton1.UseVisualStyleBackColor = true;
            this.Nuevobutton1.Click += new System.EventHandler(this.Nuevobutton1_Click);
            // 
            // Modificarbutton2
            // 
            this.Modificarbutton2.Location = new System.Drawing.Point(191, 235);
            this.Modificarbutton2.Name = "Modificarbutton2";
            this.Modificarbutton2.Size = new System.Drawing.Size(75, 23);
            this.Modificarbutton2.TabIndex = 10;
            this.Modificarbutton2.Text = "Modificar";
            this.Modificarbutton2.UseVisualStyleBackColor = true;
            this.Modificarbutton2.Click += new System.EventHandler(this.Modificarbutton2_Click);
            // 
            // Guardarbutton3
            // 
            this.Guardarbutton3.Enabled = false;
            this.Guardarbutton3.Location = new System.Drawing.Point(272, 235);
            this.Guardarbutton3.Name = "Guardarbutton3";
            this.Guardarbutton3.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton3.TabIndex = 11;
            this.Guardarbutton3.Text = "Guardar";
            this.Guardarbutton3.UseVisualStyleBackColor = true;
            this.Guardarbutton3.Click += new System.EventHandler(this.Guardarbutton3_Click);
            // 
            // Eliminarbutton4
            // 
            this.Eliminarbutton4.Location = new System.Drawing.Point(353, 235);
            this.Eliminarbutton4.Name = "Eliminarbutton4";
            this.Eliminarbutton4.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton4.TabIndex = 12;
            this.Eliminarbutton4.Text = "Eliminar";
            this.Eliminarbutton4.UseVisualStyleBackColor = true;
            this.Eliminarbutton4.Click += new System.EventHandler(this.Eliminarbutton4_Click);
            // 
            // Cancelarbutton5
            // 
            this.Cancelarbutton5.Enabled = false;
            this.Cancelarbutton5.Location = new System.Drawing.Point(435, 234);
            this.Cancelarbutton5.Name = "Cancelarbutton5";
            this.Cancelarbutton5.Size = new System.Drawing.Size(75, 23);
            this.Cancelarbutton5.TabIndex = 13;
            this.Cancelarbutton5.Text = "Cancelar";
            this.Cancelarbutton5.UseVisualStyleBackColor = true;
            this.Cancelarbutton5.Click += new System.EventHandler(this.Cancelarbutton5_Click);
            // 
            // UsuariosdataGridView1
            // 
            this.UsuariosdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosdataGridView1.Location = new System.Drawing.Point(12, 264);
            this.UsuariosdataGridView1.Name = "UsuariosdataGridView1";
            this.UsuariosdataGridView1.Size = new System.Drawing.Size(588, 174);
            this.UsuariosdataGridView1.TabIndex = 14;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.UsuariosdataGridView1);
            this.Controls.Add(this.Cancelarbutton5);
            this.Controls.Add(this.Eliminarbutton4);
            this.Controls.Add(this.Guardarbutton3);
            this.Controls.Add(this.Modificarbutton2);
            this.Controls.Add(this.Nuevobutton1);
            this.Controls.Add(this.RolcomboBox);
            this.Controls.Add(this.ClavetextBox4);
            this.Controls.Add(this.NombretextBox2);
            this.Controls.Add(this.CodigotextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CodigotextBox1;
        private System.Windows.Forms.TextBox NombretextBox2;
        private System.Windows.Forms.TextBox ClavetextBox4;
        private System.Windows.Forms.ComboBox RolcomboBox;
        private System.Windows.Forms.Button Nuevobutton1;
        private System.Windows.Forms.Button Modificarbutton2;
        private System.Windows.Forms.Button Guardarbutton3;
        private System.Windows.Forms.Button Eliminarbutton4;
        private System.Windows.Forms.Button Cancelarbutton5;
        private System.Windows.Forms.DataGridView UsuariosdataGridView1;
    }
}