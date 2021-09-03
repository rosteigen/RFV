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
    public partial class Buscador : Form
    {

        #region DELEGATES

            public delegate void Cliente(string idcliente, string razonsocial, string calle, string numero, string piso, string telefono, string mail, string idlocalidad,string cuit, string condicioniva);
            public event Cliente ClientePasado;

            public delegate void Empleado(string idempleado, string nombre, string apellido, string dni, string calle, string numero, string piso, string telefono, string mail, string fegr, string fing, string idcargo, string idlocalidad, string idnacionalidad, string fnac, string cuil, string idarea);
            public event Empleado EmpleadoPasado;

            public delegate void Proveedor(string idproveedor, string razonsocial, string calle, string numero, string piso, string telefono, string mail, string idlocalidad, string cuit);
            public event Proveedor ProveedorPasado;

            public delegate void Producto(string idproducto, string descripcion, string codigodebarra, string idcategoria, string idenvase, string idsabor, string unidadesdisponibles, string stockminimo, string stockmaximo, string idproveedor);
            public event Producto ProductoPasado;

            public delegate void Insumo(string idinsumo, string descripcion);
            public event Insumo InsumoPasado;

            //public delegate void SolicitudDeCompra(string idsolicitud, string idtipo, string idarea, string fecha, string estado);
            //public event SolicitudDeCompra SolicitudPasada;


        #endregion


        private string ntabla;


        public Buscador(string tabla)
        {
            InitializeComponent();

            ntabla = tabla;
        }


        #region EVENTOS

            private void Buscador_Load(object sender, EventArgs e)
            {
                Herramientas.CargarCombo(cmbLocalidad, "IdLocalidad", "Localidad", "Localidad");
                Herramientas.CargarCombo(cmbProveedor, "IdProveedor", "RazonSocial", "Proveedor");
                lblTabla.Text = "ID " + ntabla;

                if (ntabla == "Cliente")
                {
                    lblCampo.Text = "CUIT";
                    cmbProveedor.Visible = false;
                    lblProveedor.Visible = false;
                    cmbLocalidad.Visible = true;
                    lblLocalidad.Visible = true;
                }
                if (ntabla == "Empleado")
                {
                    lblCampo.Text = "DNI";
                    cmbProveedor.Visible = false;
                    lblProveedor.Visible = false;
                    cmbLocalidad.Visible = true;
                    lblLocalidad.Visible = true;

                }
                if (ntabla == "Proveedor")
                {
                    lblCampo.Text = "CUIT";
                    cmbProveedor.Visible = false;
                    lblProveedor.Visible = false;
                    cmbLocalidad.Visible = true;
                    lblLocalidad.Visible = true;
                }
                if (ntabla == "Producto")
                {
                    lblCampo.Text = "Menor a x unidades";
                    cmbProveedor.Visible = true;
                    lblProveedor.Visible = true;
                    cmbLocalidad.Visible = false;
                    lblLocalidad.Visible = false;
                }
                if (ntabla == "Insumo")
                {
                    lblCampo.Text = "Descripcion";
                    cmbProveedor.Visible = false;
                    lblProveedor.Visible = false;
                    cmbLocalidad.Visible = false;
                    lblLocalidad.Visible = false;
                }

                dgvBuscador.AllowUserToAddRows = false;
                dgvBuscador.ReadOnly = true;
                dgvBuscador.MultiSelect = false;
                dgvBuscador.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

            private void btnAceptar_Click(object sender, EventArgs e)
            {
                PasarDatos();
                this.Dispose();
            }

            private void btnBuscar_Click(object sender, EventArgs e)
            {
                    switch (ntabla)
                    {
                        case "Cliente":
                            {
                                LN_Cliente clientenegocio = new LN_Cliente();

                                if (txtIdTabla.Text == "") { clientenegocio.IdCliente = "0"; } else { clientenegocio.IdCliente = txtIdTabla.Text; }
                                if (cmbLocalidad.SelectedIndex == -1) { clientenegocio.IdLocalidad = "0"; } else { clientenegocio.IdLocalidad = Convert.ToString(cmbLocalidad.SelectedValue); }
                                if (txtCampo.Text == "") { clientenegocio.Cuit = "0"; } else { clientenegocio.Cuit = txtCampo.Text; }



                                dgvBuscador.DataSource = clientenegocio.BuscarCliente();
                                break;
                            }
                        case "Empleado":
                            {
                                LN_Empleado empleadonegocio = new LN_Empleado();

                                if (txtIdTabla.Text == "") { empleadonegocio.IdEmpleado = "0"; } else { empleadonegocio.IdEmpleado = txtIdTabla.Text; }
                                if (cmbLocalidad.SelectedIndex == -1) { empleadonegocio.IdLocalidad = "0"; } else { empleadonegocio.IdLocalidad = Convert.ToString(cmbLocalidad.SelectedValue); }
                                if (txtCampo.Text == "") { empleadonegocio.Dni = "0"; } else { empleadonegocio.Dni = txtCampo.Text; }



                                dgvBuscador.DataSource = empleadonegocio.BuscarEmpleado();
                                break;
                            }
                        case "Proveedor":
                            {
                                LN_Proveedor proveedornegocio = new LN_Proveedor();

                                if (txtIdTabla.Text == "") { proveedornegocio.IdProveedor = "0"; } else { proveedornegocio.IdProveedor = txtIdTabla.Text; }
                                if (cmbLocalidad.SelectedIndex == -1) { proveedornegocio.IdLocalidad = "0"; } else { proveedornegocio.IdLocalidad = Convert.ToString(cmbLocalidad.SelectedValue); }
                                if (txtCampo.Text == "") { proveedornegocio.Cuit = "0"; } else { proveedornegocio.Cuit = txtCampo.Text; }

                                dgvBuscador.DataSource = proveedornegocio.BuscarProveedor();
                                break;
                            }
                        case "Producto":
                            {
                                LN_Producto productonegocio = new LN_Producto();

                                if (txtIdTabla.Text == "") { productonegocio.IdProducto = "0"; } else { productonegocio.IdProducto = txtIdTabla.Text; }
                                if (cmbProveedor.SelectedIndex == -1) { productonegocio.IdProveedor = "0"; } else { productonegocio.IdProveedor = Convert.ToString(cmbProveedor.SelectedValue); }
                                if (txtCampo.Text == "") { productonegocio.Unidades = "0"; } else { productonegocio.Unidades = txtCampo.Text; }

                                dgvBuscador.DataSource = productonegocio.BuscarProducto();
                                break;
                            }
                        case "Insumo":
                            {
                                LN_Insumo insumonegocio = new LN_Insumo();

                                if (txtIdTabla.Text == "") { insumonegocio.IdInsumo = "0"; } else { insumonegocio.IdInsumo = txtIdTabla.Text; }

                                if (txtCampo.Text == "") { insumonegocio.Descripcion = "0"; } else { insumonegocio.Descripcion = txtCampo.Text; }



                                dgvBuscador.DataSource = insumonegocio.BuscarInsumo();
                                break;
                            }


                    }

            }

        #endregion

        #region METODOS
        private void PasarDatos()
        {
            switch (ntabla)
            {
                case "Cliente":
                    {
                        ClientePasado(dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdCliente"].Value.ToString(),
                dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["RazonSocial"].Value.ToString(),
                dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Calle"].Value.ToString(),
                dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Numero"].Value.ToString(),
                dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Piso"].Value.ToString(),
                dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Telefono"].Value.ToString(),
                dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["eMail"].Value.ToString(),
                dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdLocalidad"].Value.ToString(),
                dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["CUIT"].Value.ToString(),
                dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdCondicionIVA"].Value.ToString());


                        break;
                    }
                case "Empleado":
                    {
                        EmpleadoPasado(dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdEmpleado"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Nombre"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Apellido"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["DNI"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Calle"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Numero"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Piso"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Telefono"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["eMail"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["FechaDeEgreso"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["FechaDeIngreso"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdCargo"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdLocalidad"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdNacionalidad"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["FechaDeNacimiento"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["CUIL"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdArea"].Value.ToString());
                        break;
                    }
                case "Proveedor":
                    {
                        ProveedorPasado(dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdProveedor"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["RazonSocial"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Calle"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Numero"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Piso"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Telefono"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["eMail"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdLocalidad"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["CUIT"].Value.ToString());
                        break;
                    }
                case "Producto":
                    {
                        ProductoPasado(dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdProducto"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Descripcion"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["CodigoDeBarra"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdCategoria"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdEnvase"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdSabor"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["UnidadesDisponibles"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["StockMinimo"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["StockMaximo"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdProveedor"].Value.ToString());
                        break;
                    }
                case "Insumo":
                    {
                        InsumoPasado(dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["IdInsumo"].Value.ToString(),
                        dgvBuscador.Rows[dgvBuscador.SelectedRows[0].Index].Cells["Descripcion"].Value.ToString());
                        break;
                    }


            }


        }

        #endregion

    }
}
