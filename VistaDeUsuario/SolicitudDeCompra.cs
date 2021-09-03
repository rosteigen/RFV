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
    public partial class SolicitudDeCompra : Form
    {
        public SolicitudDeCompra()
        {
            InitializeComponent();
        }
        

        #region EVENTOS

            private void SolicitudDeCompra_Load(object sender, EventArgs e)
            {
                Herramientas.CargarCombo(cmbArea, "IdArea", "Area", "Area");
                Herramientas.CargarCombo(cmbTipo, "IdTipo", "Descripcion", "TipoDeSolicitud");
                dgvSC.AllowUserToAddRows = false;
                dgvSC.ReadOnly = true;
                dgvSC.MultiSelect = false;
                dgvSC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                mtxtFecha.Text = DateTime.Today.ToString("yyyy/MM/dd");
            
        }

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                dgvSC.Rows.Insert(0, Convert.ToInt32(txtCodigo.Text), txtDescripcion.Text, txtCantidad.Text);

                if (Convert.ToInt32(cmbTipo.SelectedValue) == 1)
                {
                    pasarsolicitud.IdProducto = txtCodigo.Text;
                    pasarsolicitud.Descripcion = txtDescripcion.Text;
                    pasarsolicitud.Cantidad = txtCantidad.Text;
                    pasarsolicitud.NuevoDetalle();
                    
                }
                else
                {
                    pasarsolicitud.IdProducto = "0";
                    pasarsolicitud.IdInsumo = txtCodigo.Text;
                    pasarsolicitud.Descripcion = txtDescripcion.Text;
                    pasarsolicitud.Cantidad = txtCantidad.Text;
                    pasarsolicitud.NuevoDetalle();
                }


                
            }

            private void btnSiguiente_Click_1(object sender, EventArgs e)
            {
                pasarsolicitud.Fecha = mtxtFecha.Text;
                pasarsolicitud.IdTipo = Convert.ToString(cmbTipo.SelectedValue);
                pasarsolicitud.IdArea = Convert.ToString(cmbArea.SelectedValue);
                pasarsolicitud.NuevaSolicitud();

                lblId.Text = pasarsolicitud.UltimoIdSolicitud().ToString();
            }

            private void btnBuscar_Click_1(object sender, EventArgs e)
            {
                if (Convert.ToInt32(cmbTipo.SelectedValue) == 1)
                {
                    Buscador frm = new Buscador("Producto");
                    frm.ProductoPasado += new Buscador.Producto(IniciarP);
                    frm.ShowDialog();
                }
                else
                {
                    Buscador frm = new Buscador("Insumo");
                    frm.InsumoPasado += new Buscador.Insumo(IniciarI);
                    frm.ShowDialog();
                }
            }
        #endregion


        #region METODOS

            LN_SolicitudDeCompra pasarsolicitud = new LN_SolicitudDeCompra();

            private void IniciarP(string idproducto, string descripcion, string codigodebarra, string idcategoria, string idenvase, string idsabor, string unidadesdisponibles, string stockminimo, string stockmaximo, string idproveedor)
            {
                txtCodigo.Text = idproducto;
                txtDescripcion.Text = descripcion;
            }
               
            private void IniciarI(string idinsumo, string descripcion)
            {
                txtCodigo.Text = idinsumo;
                txtDescripcion.Text = descripcion;

            }

        #endregion


    }
}
