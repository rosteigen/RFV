using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Data;

namespace LogicaDeNegocio
{
    public class LN_Empleado
    {
        #region ATRIBUTOS

            string idempleado;
            string nombre;
            string apellido;
            string fnac;
            string idnacionalidad;
            string telefono;
            string dni;
            string mail;
            string idarea;
            string idcargo;
            string fing;
            string fegr;
            string cuil;
            string calle;
            string numero;
            string piso;
            string idprovincia;
            string idpartido;
            string idlocalidad;



        #endregion

        #region PROPIEDADES

            public string IdEmpleado
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
            public string IdNacionalidad
            {
                set { idnacionalidad = value; }
            }
            public string Telefono
            {
                set { telefono = value; }
            }
            public string Dni
            {
                set { dni = value; }
            }
            public string Mail
            {
                set { mail = value; }
            }
            public string IdArea
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
            public string IdCargo
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
            public string Numero
            {
                set { numero = value; }
            }
            public string Piso
            {
                set { piso = value; }
            }
            public string IdProvincia
            {
                set { idprovincia = value; }
            }
            public string IdPartido
            {
                set { idpartido = value; }
            }
            public string IdLocalidad
            {
                set { idlocalidad = value; }
            }




        #endregion

        #region METODOS


            AD_Empleado pasarempleado = new AD_Empleado();

            public void PasarDatos()
            {
                pasarempleado.IdEmpleado = Convert.ToInt32(idempleado);
                pasarempleado.Nombre = nombre;
                pasarempleado.Apellido = apellido;
                pasarempleado.Calle = calle;
                pasarempleado.Numero = Convert.ToInt32(numero);
                pasarempleado.Piso = piso;
                pasarempleado.Telefono = Convert.ToInt32(telefono);
                pasarempleado.Mail = mail;
                pasarempleado.IdLocalidad = Convert.ToInt32(idlocalidad);
                pasarempleado.Cuil = cuil;
                pasarempleado.IdPartido = Convert.ToInt32(idpartido);
                pasarempleado.IdProvincia = Convert.ToInt32(idprovincia);
                pasarempleado.IdCargo = Convert.ToInt32(idcargo);
                pasarempleado.IdArea = Convert.ToInt32(idarea);
                pasarempleado.IdNacionalidad = Convert.ToInt32(idnacionalidad);
                pasarempleado.Fegr = fegr;
                pasarempleado.Fing = fing;
                pasarempleado.Fnac = fnac;
                pasarempleado.Dni = Convert.ToInt32(dni);

            }

            public void NuevoEmpleado()
            {
                PasarDatos();
                pasarempleado.NuevoEmpleado();
            }

            public void ModificarEmpleado()
            {
                PasarDatos();
                pasarempleado.ModificarEmpleado();
            }

            public void EliminarEmpleado()
            {
                PasarDatos();
                pasarempleado.EliminarEmpleado();
            }

        public DataTable BuscarEmpleado()
        {
            PasarDatos();

            DataTable DT = new DataTable();
            DT = pasarempleado.BuscarEmpleado();

            return DT;
        }



        #endregion

    }
}
