using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoADatos
{
    public class AD_Empleado
    {

        #region ATRIBUTOS

            int idempleado;
            string nombre;
            string apellido;
            string fnac;
            int idnacionalidad;
            int telefono;
            int dni;
            string mail;
            int idarea;
            int idcargo;
            string fing;
            string fegr;
            string cuil;
            string calle;
            int numero;
            string piso;
            int idprovincia;
            int idpartido;
            int idlocalidad;



        #endregion

        #region PROPIEDADES

        public int IdEmpleado
        {
            set { idempleado = value; }
        }
        public string Nombre
        {
            set { nombre = value; }
        }
        public string Apellido
        {
            set { apellido = value; }
        }
        public string Fnac
        {
            set { fnac = value; }
        }
        public int IdNacionalidad
        {
            set { idnacionalidad = value; }
        }
        public int Telefono
        {
            set { telefono = value; }
        }
        public int Dni
        {
            set { dni = value; }
        }
        public string Mail
        {
            set { mail = value; }
        }
        public int IdArea
        {
            set { idarea = value; }
        }
        public string Fing
        {
            set { fing = value; }
        }
        public string Cuil
        {
            set { cuil = value; }
        }
        public int IdCargo
        {
            set { idcargo = value; }
        }
        public string Fegr
        {
            set { fegr = value; }
        }
        public string Calle
        {
            set { calle = value; }
        }
        public int Numero
        {
            set { numero = value; }
        }
        public string Piso
        {
            set { piso = value; }
        }
        public int IdProvincia
        {
            set { idprovincia = value; }
        }
        public int IdPartido
        {
            set { idpartido = value; }
        }
        public int IdLocalidad
        {
            set { idlocalidad = value; }
        }




        #endregion


        #region METODOS

            AD_Conexion CN = new AD_Conexion();
            DataTable DT = new DataTable();

        public void NuevoEmpleado()
        {

            string sql = "Insert into Empleado (Nombre, Apellido, FechaDeNacimiento, IdNacionalidad, DNI, IdArea, FechaDeIngreso, IdCargo, FechaDeEgreso, Calle, Numero, Piso, Telefono, eMail, IdLocalidad, CUIL) " + "values ('" + nombre + "', '" + apellido + "', '" + fnac + "','" + idnacionalidad + "','" + dni + "','" + idarea + "','" + fing + "','" + idcargo + "','" + fegr + "','" + calle + "', '" + numero + "', '" + piso + "', '" + telefono + "', '" + mail + "', '" + idlocalidad + "'," + "'" + cuil + "')";


            
            CN.Ejecutar(sql);

        }

        public void ModificarEmpleado()
        {

            string sql = "Update Empleado set Nombre= '" + nombre + "', Calle= '" + calle + "', Numero= " + numero + ", Piso= '" + piso + "', Telefono= " + telefono + ", DNI= " + dni + ", FechaDeEgreso= '" + fegr + "', FechaDeIngreso= '" + fing + "', IdArea= " + idarea + ", IdNacionalidad= " + idnacionalidad + ", FechaDeNacimiento= '" + fnac + "', Apellido= '" + apellido + "', eMail= '" + mail + "', IdLocalidad= " + idlocalidad + ", CUIL= " + cuil + ", IdCargo= " + idcargo + " where IdEmpleado = " + idempleado;

            CN.Ejecutar(sql);
        }

        public void EliminarEmpleado()
        {

            string sql = "Delete from Empleado where IdEmpleado = " + idempleado;
            CN.Ejecutar(sql);
        }

        public DataTable BuscarEmpleado()
        {

            string sql = "Select * from Empleado ";


            if (idempleado != 0)
            {
                sql += "where IdEmpleado= " + idempleado;
            }
            if (dni != 0)
            {
                sql += "where DNI = " + dni;
            }
            if (idlocalidad != 0)
            {
                sql += "where IdLocalidad = " + idlocalidad;
            }


            DT.Clear();
            SqlCommand cmd = new SqlCommand(sql, CN.AbrirConexion());
            SqlDataReader DR = cmd.ExecuteReader();
            DT.Load(DR);
            CN.CerrarConexion();
            return DT;
        }






        #endregion

    }
}
