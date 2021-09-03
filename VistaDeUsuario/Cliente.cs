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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            
        }

        #region EVENTOS

            private void Cliente_Load(object sender, EventArgs e)
            {
                Herramientas.CargarCombo(cmbLocalidad, "IdLocalidad", "Localidad", "Localidad");
              
            }



        #endregion

        #region METODOS

            LN_Cliente clientenegocio = new LN_Cliente();

       

        private void PasarCliente()
        {
            if (txtCliente.Text == "") { clientenegocio.IdCliente = "0"; } else { clientenegocio.IdCliente = txtCliente.Text; }
           
            clientenegocio.RazonSocial = txtRazonSocial.Text;
            clientenegocio.Calle = txtCalle.Text;
            clientenegocio.Numero = txtNumero.Text;
            clientenegocio.Piso = txtPiso.Text;
            clientenegocio.Telefono = txtTelefono.Text;
            clientenegocio.Mail = txtMail.Text;
            clientenegocio.IdLocalidad = Convert.ToString(cmbLocalidad.SelectedValue);
            clientenegocio.Cuit = txtCuit.Text;

            if (rdbResponsable.Checked)
            {
                clientenegocio.IdCondicion = "1";
            }
            if (rdbMonotributista.Checked)
            {
                clientenegocio.IdCondicion = "2";
            }
            if (rdbConsumidor.Checked)
            {
                clientenegocio.IdCondicion = "3";
            }

            
        }


        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PasarCliente();
            clientenegocio.NuevoCliente();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            PasarCliente();
            clientenegocio.ModificarCliente();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PasarCliente();
            clientenegocio.EliminarCliente();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            Buscador frm = new Buscador("Cliente");
            frm.ClientePasado += new Buscador.Cliente(Iniciar);
            
            frm.ShowDialog();
            
        }

        private void Iniciar(string idcliente, string razonsocial, string calle, string numero, string piso, string telefono, string mail, string idlocalidad, string cuit, string condicioniva)
        {
            txtCliente.Text = idcliente;
            txtRazonSocial.Text = razonsocial;
            txtCalle.Text = calle;
            txtNumero.Text = numero;
            txtPiso.Text = piso;
            txtTelefono.Text = telefono;
            txtMail.Text = mail;
            cmbLocalidad.SelectedValue = idlocalidad;
            txtCuit.Text = cuit;
            if (condicioniva == "1") { rdbResponsable.Checked = true; }
            if (condicioniva == "2") { rdbMonotributista.Checked = true; }
            if (condicioniva == "3") { rdbConsumidor.Checked = true; }

        }
    }






}

