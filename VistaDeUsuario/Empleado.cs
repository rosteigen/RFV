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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }


        
        LN_Empleado empleadonegocio = new LN_Empleado();

        private void Empleado_Load(object sender, EventArgs e)
        {
            Herramientas.CargarCombo(cmbArea, "IdArea", "Area", "Area");
            Herramientas.CargarCombo(cmbCargo, "IdCargo", "Cargo", "Cargo");
            Herramientas.CargarCombo(cmbNacionalidad, "IdNacionalidad", "Nacionalidad", "Nacionalidad");
            Herramientas.CargarCombo(cmbProvincia, "IdProvincia", "Provincia", "Provincia");
            Herramientas.CargarCombo(cmbPartido, "IdPartido", "Partido", "Partido");
            Herramientas.CargarCombo(cmbLocalidad, "IdLocalidad", "Localidad", "Localidad");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            PasarEmpleado();
            empleadonegocio.NuevoEmpleado();
        }

        private void PasarEmpleado()
        {

            if (txtId.Text == "") { empleadonegocio.IdEmpleado = "0"; } else { empleadonegocio.IdEmpleado = txtId.Text;}
            
            empleadonegocio.Nombre = txtNombre.Text;
            empleadonegocio.Apellido = txtApellido.Text;
            empleadonegocio.Calle = txtCalle.Text;
            empleadonegocio.Numero = txtNumero.Text ;
            empleadonegocio.Piso = txtPiso.Text;
            empleadonegocio.Telefono = txtTelefono.Text ;
            empleadonegocio.Mail = txtMail.Text;
            empleadonegocio.IdLocalidad = Convert.ToString(cmbLocalidad.SelectedValue);
            empleadonegocio.Cuil = txtCUIL.Text;
            empleadonegocio.IdPartido = Convert.ToString(cmbPartido.SelectedValue);
            empleadonegocio.IdProvincia = Convert.ToString(cmbProvincia.SelectedValue);
            empleadonegocio.IdCargo = Convert.ToString(cmbCargo.SelectedValue);
            empleadonegocio.IdArea = Convert.ToString(cmbArea.SelectedValue);
            empleadonegocio.IdNacionalidad = Convert.ToString(cmbNacionalidad.SelectedValue);
            empleadonegocio.Fegr = mtxtFegr.Text;
            empleadonegocio.Fing = mtxtFing.Text;
            empleadonegocio.Fnac = mtxtFnac.Text;
            empleadonegocio.Dni = txtDNI.Text;



        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            PasarEmpleado();
            empleadonegocio.ModificarEmpleado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            PasarEmpleado();
            empleadonegocio.EliminarEmpleado();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscador frm = new Buscador("Empleado");
            frm.EmpleadoPasado += new Buscador.Empleado(Iniciar);
            

            frm.ShowDialog();
        }

        private void Iniciar(string idempleado, string nombre, string apellido, string dni, string calle, string numero, string piso, string telefono, string mail, string fegr, string fing, string idcargo, string idlocalidad, string idnacionalidad, string fnac, string cuil, string idarea)
        {
            txtId.Text = idempleado;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtDNI.Text = dni;
            mtxtFegr.Text = fegr;
            mtxtFing.Text = fing;
            cmbCargo.SelectedValue = idcargo;
            cmbNacionalidad.SelectedValue =  idnacionalidad;
            mtxtFnac.Text = fnac;
            cmbArea.SelectedValue =  idarea;
            txtNumero.Text = numero;
            txtCalle.Text = calle;
            txtPiso.Text = piso;
            txtTelefono.Text = telefono;
            txtMail.Text = mail;
            cmbLocalidad.SelectedValue = idlocalidad;
            txtCUIL.Text = cuil;
           
        }
    }
}
