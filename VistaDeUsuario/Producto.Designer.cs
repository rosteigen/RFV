
namespace VistaDeUsuario
{
    partial class Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producto));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gboxStock = new System.Windows.Forms.GroupBox();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.gboxProducto = new System.Windows.Forms.GroupBox();
            this.cmbSabor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEnvase = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pboxProducto = new System.Windows.Forms.PictureBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.gboxStock.SuspendLayout();
            this.gboxProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(44, 337);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 87);
            this.btnGuardar.TabIndex = 74;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gboxStock
            // 
            this.gboxStock.Controls.Add(this.txtMaximo);
            this.gboxStock.Controls.Add(this.label7);
            this.gboxStock.Controls.Add(this.txtMinimo);
            this.gboxStock.Controls.Add(this.label6);
            this.gboxStock.Controls.Add(this.txtUnidades);
            this.gboxStock.Controls.Add(this.label4);
            this.gboxStock.Location = new System.Drawing.Point(44, 231);
            this.gboxStock.Name = "gboxStock";
            this.gboxStock.Size = new System.Drawing.Size(497, 100);
            this.gboxStock.TabIndex = 68;
            this.gboxStock.TabStop = false;
            this.gboxStock.Text = "Stock";
            // 
            // txtMaximo
            // 
            this.txtMaximo.Location = new System.Drawing.Point(293, 57);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(100, 20);
            this.txtMaximo.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Maximo";
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(143, 58);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(74, 20);
            this.txtMinimo.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Minimo";
            // 
            // txtUnidades
            // 
            this.txtUnidades.ForeColor = System.Drawing.Color.Lime;
            this.txtUnidades.Location = new System.Drawing.Point(197, 23);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(100, 20);
            this.txtUnidades.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Unidades";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(671, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 87);
            this.button2.TabIndex = 73;
            this.button2.Text = "Salir";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gboxProducto
            // 
            this.gboxProducto.Controls.Add(this.cmbSabor);
            this.gboxProducto.Controls.Add(this.label9);
            this.gboxProducto.Controls.Add(this.cmbEnvase);
            this.gboxProducto.Controls.Add(this.label8);
            this.gboxProducto.Controls.Add(this.btnBuscar);
            this.gboxProducto.Controls.Add(this.cmbProveedor);
            this.gboxProducto.Controls.Add(this.label5);
            this.gboxProducto.Controls.Add(this.pictureBox2);
            this.gboxProducto.Controls.Add(this.txtDescripcion);
            this.gboxProducto.Controls.Add(this.txtCodigo);
            this.gboxProducto.Controls.Add(this.cmbCategoria);
            this.gboxProducto.Controls.Add(this.label3);
            this.gboxProducto.Controls.Add(this.label2);
            this.gboxProducto.Controls.Add(this.label1);
            this.gboxProducto.Location = new System.Drawing.Point(43, 26);
            this.gboxProducto.Name = "gboxProducto";
            this.gboxProducto.Size = new System.Drawing.Size(498, 191);
            this.gboxProducto.TabIndex = 67;
            this.gboxProducto.TabStop = false;
            this.gboxProducto.Text = "Datos";
            // 
            // cmbSabor
            // 
            this.cmbSabor.FormattingEnabled = true;
            this.cmbSabor.Items.AddRange(new object[] {
            "Bidón"});
            this.cmbSabor.Location = new System.Drawing.Point(340, 145);
            this.cmbSabor.Name = "cmbSabor";
            this.cmbSabor.Size = new System.Drawing.Size(121, 21);
            this.cmbSabor.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Sabor";
            // 
            // cmbEnvase
            // 
            this.cmbEnvase.FormattingEnabled = true;
            this.cmbEnvase.Items.AddRange(new object[] {
            "Bidón"});
            this.cmbEnvase.Location = new System.Drawing.Point(340, 106);
            this.cmbEnvase.Name = "cmbEnvase";
            this.cmbEnvase.Size = new System.Drawing.Size(121, 21);
            this.cmbEnvase.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(291, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Envase";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(467, 64);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 27);
            this.btnBuscar.TabIndex = 66;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Items.AddRange(new object[] {
            "Bidón"});
            this.cmbProveedor.Location = new System.Drawing.Point(157, 142);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(121, 21);
            this.cmbProveedor.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Proveedor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(128, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 13);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(157, 70);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(304, 20);
            this.txtDescripcion.TabIndex = 33;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(157, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 31;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Bidón"});
            this.cmbCategoria.Location = new System.Drawing.Point(157, 106);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Categoria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Código";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(247, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 87);
            this.button3.TabIndex = 72;
            this.button3.Text = "Cancelar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(351, 337);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 87);
            this.btnEliminar.TabIndex = 71;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(454, 337);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 87);
            this.button5.TabIndex = 70;
            this.button5.Text = "Editar";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.Location = new System.Drawing.Point(143, 337);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 87);
            this.button6.TabIndex = 69;
            this.button6.Text = "Nuevo";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pboxProducto
            // 
            this.pboxProducto.Image = ((System.Drawing.Image)(resources.GetObject("pboxProducto.Image")));
            this.pboxProducto.Location = new System.Drawing.Point(573, 80);
            this.pboxProducto.Name = "pboxProducto";
            this.pboxProducto.Size = new System.Drawing.Size(185, 137);
            this.pboxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxProducto.TabIndex = 66;
            this.pboxProducto.TabStop = false;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCambios.Image")));
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarCambios.Location = new System.Drawing.Point(671, 244);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(87, 87);
            this.btnGuardarCambios.TabIndex = 75;
            this.btnGuardarCambios.Text = "Guardar";
            this.btnGuardarCambios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(589, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 31);
            this.label10.TabIndex = 76;
            this.label10.Text = "Nº";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.Location = new System.Drawing.Point(674, 26);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(32, 31);
            this.lblIdProducto.TabIndex = 77;
            this.lblIdProducto.Text = "X";
           
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gboxStock);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gboxProducto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pboxProducto);
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            this.gboxStock.ResumeLayout(false);
            this.gboxStock.PerformLayout();
            this.gboxProducto.ResumeLayout(false);
            this.gboxProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gboxStock;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gboxProducto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pboxProducto;
        private System.Windows.Forms.ComboBox cmbSabor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEnvase;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblIdProducto;
    }
}