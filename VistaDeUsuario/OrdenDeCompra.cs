using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaDeUsuario
{
    public partial class OrdenDeCompra : Form
    {
        public OrdenDeCompra()
        {
            InitializeComponent();
        }

        #region EVENTOS

            private void OrdenDeCompra_Load(object sender, EventArgs e)
            {
                mtxtFecha.Text = DateTime.Today.ToString("yyyy/MM/dd");
                Herramientas.CargarCombo(cmbLocalidad, "IdLocalidad", "Localidad", "Localidad");
                Herramientas.CargarCombo(cmbTipo, "IdTipo", "Descripcion", "TipoDeSolicitud");
            }

            private void btnBuscarP_Click(object sender, EventArgs e)
            {
                Buscador frm = new Buscador("Proveedor");
                frm.ProveedorPasado += new Buscador.Proveedor(Iniciar);

                frm.ShowDialog();
            }
        #endregion

        #region METODOS

            private void Iniciar(string idproveedor, string razonsocial, string calle, string numero, string piso, string telefono, string mail, string idlocalidad, string cuit)
            {
                txtCodigo.Text = idproveedor;
                txtRazonSocial.Text = razonsocial;
                txtCalle.Text = calle;
                txtNumero.Text = numero;
                txtPiso.Text = piso;
                txtTelefono.Text = telefono;
                txtMail.Text = mail;
                cmbLocalidad.SelectedValue = idlocalidad;
                txtCUIT.Text = cuit;

            }

            private void Iniciar2(string idsolicitud, string fecha, string estado, string tipo, string area, string cantidad, string descripcion, string idproducto)
            {
                if(lblNumSC.Text == idsolicitud)
                {
                    dgvDatos.Rows.Add(idproducto, descripcion, cantidad);
                    
                    
                }
                else
                {
                    lblNumSC.Text = idsolicitud;
                    
                    dgvDatos.Rows[0].Cells["Descripcion"].Value = descripcion;
                    dgvDatos.Rows[0].Cells["Cantidad"].Value = cantidad;
                    dgvDatos.Rows[0].Cells["Codigo"].Value = idproducto;
                }

                //cmbTipo. = tipo;




        }

        #endregion

        private void btnBuscarSC_Click(object sender, EventArgs e)
        {
            

            BuscadorSDC frm = new BuscadorSDC();
            frm.SDCPasado += new BuscadorSDC.SDC(Iniciar2);

            frm.ShowDialog();
        }
    }
}
