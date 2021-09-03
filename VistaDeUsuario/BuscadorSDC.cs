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
    public partial class BuscadorSDC : Form
    {
        public BuscadorSDC()
        {
            InitializeComponent();
        }

        #region DELEGATES

            public delegate void SDC(string idsolicitud, string fecha, string estado, string tipo, string area, string cantidad, string descripcion, string idproducto);
            public event SDC SDCPasado;



        #endregion

        private void BuscadorSDC_Load(object sender, EventArgs e)
        {

            dgvSDCP.AllowUserToAddRows = false;
            dgvSDCP.ReadOnly = true;
            dgvSDCP.MultiSelect = true;
            dgvSDCP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSDCI.AllowUserToAddRows = false;
            dgvSDCI.ReadOnly = true;
            dgvSDCI.MultiSelect = true;
            dgvSDCI.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            LN_SolicitudDeCompra SDCnegocio = new LN_SolicitudDeCompra();
            dgvSDCP.DataSource = SDCnegocio.BuscarSDCP();
            LN_SolicitudDeCompra SDCnegocio2 = new LN_SolicitudDeCompra();
            dgvSDCI.DataSource = SDCnegocio2.BuscarSDCI();


            ///atencion
            ///

            dgvSDCI.Enabled = false;
            dgvSDCI.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            PasarDatos();
            this.Dispose();
        }

        private void PasarDatos()
        {
            SDCPasado(dgvSDCP.Rows[dgvSDCP.SelectedRows[0].Index].Cells["ID"].Value.ToString(),
                dgvSDCP.Rows[dgvSDCP.SelectedRows[0].Index].Cells["Fecha"].Value.ToString(),
                dgvSDCP.Rows[dgvSDCP.SelectedRows[0].Index].Cells["Estado"].Value.ToString(),
                dgvSDCP.Rows[dgvSDCP.SelectedRows[0].Index].Cells["Tipo"].Value.ToString(),
                dgvSDCP.Rows[dgvSDCP.SelectedRows[0].Index].Cells["Area"].Value.ToString(),
                dgvSDCP.Rows[dgvSDCP.SelectedRows[0].Index].Cells["Cantidad"].Value.ToString(),
                dgvSDCP.Rows[dgvSDCP.SelectedRows[0].Index].Cells["Nombre"].Value.ToString(),
                dgvSDCP.Rows[dgvSDCP.SelectedRows[0].Index].Cells["IDProducto"].Value.ToString());
        }
    }
}
