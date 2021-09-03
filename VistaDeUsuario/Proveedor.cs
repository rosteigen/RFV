using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocio;

namespace VistaDeUsuario
{
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }



        #region EVENTOS
            private void Proveedor_Load(object sender, EventArgs e)
            {
                Herramientas.CargarCombo(cmbLocalidad, "IdLocalidad", "Localidad", "Localidad");
            }

            private void btnGuardar_Click(object sender, EventArgs e)
            {
                PasarProveedor();
                proveedornegocio.NuevoProveedor();
            }

            private void btnNuevo_Click(object sender, EventArgs e)
            {

            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {

            }

            private void btnEliminar_Click(object sender, EventArgs e)
            {
                PasarProveedor();
                proveedornegocio.EliminarProveedor();
            }

            private void btnEditar_Click(object sender, EventArgs e)
            {

            }

            private void btnGuardarCambios_Click(object sender, EventArgs e)
            {
                PasarProveedor();
                proveedornegocio.ModificarProveedor();
            }

            private void btnBuscarProveedor_Click(object sender, EventArgs e)
            {
                Buscador frm = new Buscador("Proveedor");
                frm.ProveedorPasado += new Buscador.Proveedor(Iniciar);

                frm.ShowDialog();
            }
        #endregion

        #region METODOS

        LN_Proveedor proveedornegocio = new LN_Proveedor();

        private void PasarProveedor()
        {
            if (txtCodigo.Text == "") { proveedornegocio.IdProveedor = "0"; } else { proveedornegocio.IdProveedor = txtCodigo.Text; }

            proveedornegocio.RazonSocial = txtRazonSocial.Text;
            proveedornegocio.Calle = txtCalle.Text;
            proveedornegocio.Nro = txtNro.Text;
            proveedornegocio.Piso = txtPiso.Text;
            proveedornegocio.Telefono = txtTelefono.Text;
            proveedornegocio.Mail = txtMail.Text;
            proveedornegocio.IdLocalidad = Convert.ToString(cmbLocalidad.SelectedValue);
            proveedornegocio.Cuit = txtCuit.Text;

        }

        private void Iniciar(string idproveedor, string razonsocial, string calle, string numero, string piso, string telefono, string mail, string idlocalidad, string cuit)
        {
            txtCodigo.Text = idproveedor;
            txtRazonSocial.Text = razonsocial;
            txtCalle.Text = calle;
            txtNro.Text = numero;
            txtPiso.Text = piso;
            txtTelefono.Text = telefono;
            txtMail.Text = mail;
            cmbLocalidad.SelectedValue = idlocalidad;
            txtCuit.Text = cuit;
            
        }


        #endregion

        
    }
}
