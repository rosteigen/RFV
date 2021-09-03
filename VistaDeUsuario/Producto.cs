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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        #region EVENTOS
            private void Producto_Load(object sender, EventArgs e)
            {
                Herramientas.CargarCombo(cmbCategoria, "IdCategoria", "Categoria", "Categoria");
                Herramientas.CargarCombo(cmbSabor, "IdSabor", "Sabor", "Sabor");
                Herramientas.CargarCombo(cmbEnvase, "IdEnvase", "Envase", "Envase");
                Herramientas.CargarCombo(cmbProveedor, "IdProveedor", "RazonSocial", "Proveedor");
            }

            private void btnGuardar_Click(object sender, EventArgs e)
            {
                PasarProducto();
                productonegocio.NuevoProducto();
            }

            private void btnEliminar_Click(object sender, EventArgs e)
            {
                PasarProducto();
                productonegocio.EliminarProducto();
            }

            private void btnGuardarCambios_Click(object sender, EventArgs e)
            {
                PasarProducto();
                productonegocio.ModificarProducto();
            }

            private void btnBuscar_Click(object sender, EventArgs e)
            {
                Buscador frm = new Buscador("Producto");
                frm.ProductoPasado += new Buscador.Producto(Iniciar);

                frm.ShowDialog();
            }


        #endregion

        LN_Producto productonegocio = new LN_Producto();

        #region METODOS

            private void PasarProducto()
            {
                if (lblIdProducto.Text == "") { productonegocio.IdProducto = "0"; } else { productonegocio.IdProducto = lblIdProducto.Text; }

                productonegocio.Descripcion = txtDescripcion.Text;
                productonegocio.CodigoDeBarra = txtCodigo.Text;
                productonegocio.IdCategoria = Convert.ToString(cmbCategoria.SelectedValue);
                productonegocio.IdEnvase = Convert.ToString(cmbEnvase.SelectedValue);
                productonegocio.IdSabor = Convert.ToString(cmbSabor.SelectedValue);
                productonegocio.UnidadesDisponibles = txtUnidades.Text;
                productonegocio.StockMinimo = txtMinimo.Text;
                productonegocio.StockMaximo = txtMaximo.Text;
                productonegocio.IdProveedor = Convert.ToString(cmbProveedor.SelectedValue);

            }

            private void Iniciar(string idproducto, string descripcion, string codigodebarra, string idcategoria, string idenvase, string idsabor,  string unidadesdisponibles, string stockminimo, string stockmaximo, string idproveedor)
            {
                txtCodigo.Text = codigodebarra;
                txtDescripcion.Text = descripcion;
                txtMaximo.Text = stockmaximo;
                txtMinimo.Text = stockminimo;
                txtUnidades.Text = unidadesdisponibles;
                cmbCategoria.SelectedValue = idcategoria;
                cmbEnvase.SelectedValue = idenvase;
                cmbProveedor.SelectedValue = idproveedor;
                cmbSabor.SelectedValue = idsabor;
                lblIdProducto.Text = idproducto;


            }


        #endregion



    }
}

