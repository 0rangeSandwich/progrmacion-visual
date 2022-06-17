namespace Productos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtFechaEntrada = new System.Windows.Forms.TextBox();
            this.txtPresentacion = new System.Windows.Forms.TextBox();
            this.txtPrecioPublico = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.txtPrecioProveedor = new System.Windows.Forms.TextBox();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.Datos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.registrarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(909, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.registrarToolStripMenuItem.Text = "Registrar";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.txtCategoria);
            this.Datos.Controls.Add(this.txtFechaEntrada);
            this.Datos.Controls.Add(this.txtPresentacion);
            this.Datos.Controls.Add(this.txtPrecioPublico);
            this.Datos.Controls.Add(this.txtPrecioUnitario);
            this.Datos.Controls.Add(this.txtPrecioProveedor);
            this.Datos.Controls.Add(this.txtUnidades);
            this.Datos.Controls.Add(this.txtDescripcion);
            this.Datos.Controls.Add(this.txtNombre);
            this.Datos.Controls.Add(this.txtCodigo);
            this.Datos.Controls.Add(this.label10);
            this.Datos.Controls.Add(this.label9);
            this.Datos.Controls.Add(this.label8);
            this.Datos.Controls.Add(this.label7);
            this.Datos.Controls.Add(this.label5);
            this.Datos.Controls.Add(this.label6);
            this.Datos.Controls.Add(this.label4);
            this.Datos.Controls.Add(this.label3);
            this.Datos.Controls.Add(this.label2);
            this.Datos.Controls.Add(this.label1);
            this.Datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datos.Location = new System.Drawing.Point(13, 32);
            this.Datos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Datos.Name = "Datos";
            this.Datos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Datos.Size = new System.Drawing.Size(881, 458);
            this.Datos.TabIndex = 1;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoria.Location = new System.Drawing.Point(117, 398);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(261, 30);
            this.txtCategoria.TabIndex = 20;
            // 
            // txtFechaEntrada
            // 
            this.txtFechaEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaEntrada.Location = new System.Drawing.Point(188, 346);
            this.txtFechaEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFechaEntrada.Name = "txtFechaEntrada";
            this.txtFechaEntrada.Size = new System.Drawing.Size(261, 30);
            this.txtFechaEntrada.TabIndex = 19;
            // 
            // txtPresentacion
            // 
            this.txtPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPresentacion.Location = new System.Drawing.Point(143, 289);
            this.txtPresentacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPresentacion.Name = "txtPresentacion";
            this.txtPresentacion.Size = new System.Drawing.Size(261, 30);
            this.txtPresentacion.TabIndex = 18;
            // 
            // txtPrecioPublico
            // 
            this.txtPrecioPublico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioPublico.Location = new System.Drawing.Point(727, 228);
            this.txtPrecioPublico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioPublico.Name = "txtPrecioPublico";
            this.txtPrecioPublico.Size = new System.Drawing.Size(111, 30);
            this.txtPrecioPublico.TabIndex = 17;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(456, 228);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(111, 30);
            this.txtPrecioUnitario.TabIndex = 16;
            // 
            // txtPrecioProveedor
            // 
            this.txtPrecioProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioProveedor.Location = new System.Drawing.Point(176, 228);
            this.txtPrecioProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioProveedor.Name = "txtPrecioProveedor";
            this.txtPrecioProveedor.Size = new System.Drawing.Size(111, 30);
            this.txtPrecioProveedor.TabIndex = 15;
            // 
            // txtUnidades
            // 
            this.txtUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidades.Location = new System.Drawing.Point(175, 169);
            this.txtUnidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(169, 30);
            this.txtUnidades.TabIndex = 14;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(139, 89);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(519, 57);
            this.txtDescripcion.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(399, 38);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(288, 30);
            this.txtNombre.TabIndex = 12;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(105, 38);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(169, 30);
            this.txtCodigo.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 346);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fecha de entrada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Presentacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(584, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Precio Publico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(308, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio Unitario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Num. Unidades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(23, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 23);
            this.label20.TabIndex = 0;
            this.label20.Text = "Codigo";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(117, 52);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(169, 30);
            this.txtBuscar.TabIndex = 11;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 506);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(881, 105);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 656);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(881, 272);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(868, 236);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 942);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecioPublico;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.TextBox txtPrecioProveedor;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtFechaEntrada;
        private System.Windows.Forms.TextBox txtPresentacion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

