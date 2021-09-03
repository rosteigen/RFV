
namespace VistaDeUsuario
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grbProducto = new System.Windows.Forms.GroupBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.grbCondicion = new System.Windows.Forms.GroupBox();
            this.rdbConsumidor = new System.Windows.Forms.RadioButton();
            this.rdbResponsable = new System.Windows.Forms.RadioButton();
            this.rdbMonotributista = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.pboxProducto = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.grbProducto.SuspendLayout();
            this.grbCondicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(93, 337);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 87);
            this.btnGuardar.TabIndex = 66;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(620, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 87);
            this.button1.TabIndex = 65;
            this.button1.Text = "Salir";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grbProducto
            // 
            this.grbProducto.Controls.Add(this.txtPiso);
            this.grbProducto.Controls.Add(this.label9);
            this.grbProducto.Controls.Add(this.txtRazonSocial);
            this.grbProducto.Controls.Add(this.grbCondicion);
            this.grbProducto.Controls.Add(this.button2);
            this.grbProducto.Controls.Add(this.btnBuscarCliente);
            this.grbProducto.Controls.Add(this.txtCuit);
            this.grbProducto.Controls.Add(this.pboxProducto);
            this.grbProducto.Controls.Add(this.label8);
            this.grbProducto.Controls.Add(this.txtNumero);
            this.grbProducto.Controls.Add(this.label7);
            this.grbProducto.Controls.Add(this.txtMail);
            this.grbProducto.Controls.Add(this.txtTelefono);
            this.grbProducto.Controls.Add(this.label6);
            this.grbProducto.Controls.Add(this.label4);
            this.grbProducto.Controls.Add(this.txtCalle);
            this.grbProducto.Controls.Add(this.cmbLocalidad);
            this.grbProducto.Controls.Add(this.label5);
            this.grbProducto.Controls.Add(this.txtCliente);
            this.grbProducto.Controls.Add(this.label3);
            this.grbProducto.Controls.Add(this.label2);
            this.grbProducto.Controls.Add(this.label1);
            this.grbProducto.Location = new System.Drawing.Point(93, 26);
            this.grbProducto.Name = "grbProducto";
            this.grbProducto.Size = new System.Drawing.Size(554, 305);
            this.grbProducto.TabIndex = 64;
            this.grbProducto.TabStop = false;
            this.grbProducto.Text = "Datos";
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(291, 151);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(49, 20);
            this.txtPiso.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Piso";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(157, 70);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(183, 20);
            this.txtRazonSocial.TabIndex = 65;
            // 
            // grbCondicion
            // 
            this.grbCondicion.Controls.Add(this.rdbConsumidor);
            this.grbCondicion.Controls.Add(this.rdbResponsable);
            this.grbCondicion.Controls.Add(this.rdbMonotributista);
            this.grbCondicion.Location = new System.Drawing.Point(357, 19);
            this.grbCondicion.Name = "grbCondicion";
            this.grbCondicion.Size = new System.Drawing.Size(181, 119);
            this.grbCondicion.TabIndex = 64;
            this.grbCondicion.TabStop = false;
            this.grbCondicion.Text = "Condición IVA";
            // 
            // rdbConsumidor
            // 
            this.rdbConsumidor.AutoSize = true;
            this.rdbConsumidor.Location = new System.Drawing.Point(43, 88);
            this.rdbConsumidor.Name = "rdbConsumidor";
            this.rdbConsumidor.Size = new System.Drawing.Size(105, 17);
            this.rdbConsumidor.TabIndex = 64;
            this.rdbConsumidor.TabStop = true;
            this.rdbConsumidor.Text = "Consumidor Final";
            this.rdbConsumidor.UseVisualStyleBackColor = true;
            // 
            // rdbResponsable
            // 
            this.rdbResponsable.AutoSize = true;
            this.rdbResponsable.Location = new System.Drawing.Point(43, 28);
            this.rdbResponsable.Name = "rdbResponsable";
            this.rdbResponsable.Size = new System.Drawing.Size(130, 17);
            this.rdbResponsable.TabIndex = 62;
            this.rdbResponsable.TabStop = true;
            this.rdbResponsable.Text = "Responsable Inscripto";
            this.rdbResponsable.UseVisualStyleBackColor = true;
            // 
            // rdbMonotributista
            // 
            this.rdbMonotributista.AutoSize = true;
            this.rdbMonotributista.Location = new System.Drawing.Point(43, 58);
            this.rdbMonotributista.Name = "rdbMonotributista";
            this.rdbMonotributista.Size = new System.Drawing.Size(91, 17);
            this.rdbMonotributista.TabIndex = 63;
            this.rdbMonotributista.TabStop = true;
            this.rdbMonotributista.Text = "Monotributista";
            this.rdbMonotributista.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(278, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 32);
            this.button2.TabIndex = 60;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.BackgroundImage")));
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarCliente.Location = new System.Drawing.Point(260, 30);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(25, 27);
            this.btnBuscarCliente.TabIndex = 55;
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(157, 223);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 50;
            // 
            // pboxProducto
            // 
            this.pboxProducto.Image = ((System.Drawing.Image)(resources.GetObject("pboxProducto.Image")));
            this.pboxProducto.Location = new System.Drawing.Point(353, 144);
            this.pboxProducto.Name = "pboxProducto";
            this.pboxProducto.Size = new System.Drawing.Size(185, 137);
            this.pboxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxProducto.TabIndex = 49;
            this.pboxProducto.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "CUIT";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(291, 110);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(49, 20);
            this.txtNumero.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Nro";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(157, 187);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 46;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(157, 151);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "eMail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Teléfono";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(157, 110);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 42;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Items.AddRange(new object[] {
            "Bidón"});
            this.cmbLocalidad.Location = new System.Drawing.Point(157, 260);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalidad.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Localidad";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(157, 35);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Razon Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Calle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Id Cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(296, 337);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 87);
            this.btnCancelar.TabIndex = 63;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(400, 337);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 87);
            this.btnEliminar.TabIndex = 62;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnModificar.Location = new System.Drawing.Point(503, 337);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 87);
            this.btnModificar.TabIndex = 61;
            this.btnModificar.Text = "Editar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(192, 337);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(87, 87);
            this.btnNuevo.TabIndex = 60;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCambios.Image")));
            this.btnGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarCambios.Location = new System.Drawing.Point(666, 226);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(87, 87);
            this.btnGuardarCambios.TabIndex = 67;
            this.btnGuardarCambios.Text = "Guardar";
            this.btnGuardarCambios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGuardarCambios);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.grbProducto.ResumeLayout(false);
            this.grbProducto.PerformLayout();
            this.grbCondicion.ResumeLayout(false);
            this.grbCondicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbProducto;
        private System.Windows.Forms.GroupBox grbCondicion;
        private System.Windows.Forms.RadioButton rdbResponsable;
        private System.Windows.Forms.RadioButton rdbMonotributista;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.PictureBox pboxProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdbConsumidor;
        private System.Windows.Forms.Button btnGuardarCambios;
    }
}