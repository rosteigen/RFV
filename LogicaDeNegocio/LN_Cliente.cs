using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Data;

namespace LogicaDeNegocio
{
    public class LN_Cliente
    {
        #region ATRIBUTOS

            private string idcliente;
            private string razonsocial;
            private string calle;
            private string numero;
            private string piso;
            private string telefono;
            private string mail;
            private string idlocalidad;
            private string cuit;
            private string idcondicion;

        #endregion




        #region PROPIEDADES

        public string IdCliente
        {
            set { idcliente = value; }
        }

        public string RazonSocial
        {
            set { razonsocial = value; }
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
        public string Telefono
        {
            set { telefono = value; }
        }
        public string Mail
        {
            set { mail = value; }
        }
        public string Cuit
        {
            set { cuit = value; }
        }
        public string IdLocalidad
        {
            set { idlocalidad = value; }
        }
        public string IdCondicion
        {
            set { idcondicion = value; }
        }
        #endregion

        AD_Cliente pasarcliente = new AD_Cliente();

        #region METODOS



            public void PasarDatos()
            {
                pasarcliente.IdCliente = Convert.ToInt32(idcliente);
                pasarcliente.RazonSocial = razonsocial;
                pasarcliente.Calle = calle;
                pasarcliente.Numero = Convert.ToInt32(numero);
                pasarcliente.Piso = piso;
                pasarcliente.Telefono = Convert.ToInt32(telefono);
                pasarcliente.Mail = mail;
                pasarcliente.IdLocalidad = Convert.ToInt32(idlocalidad);
                pasarcliente.Cuit = cuit;
                pasarcliente.IdCondicion = Convert.ToInt32(idcondicion);

            }


            public void NuevoCliente()
            {
                PasarDatos();
                pasarcliente.NuevoCliente();

            }

            public void ModificarCliente()
            {
                PasarDatos();
                pasarcliente.ModificarCliente();
            }

            public void EliminarCliente()
            {
                PasarDatos();
                pasarcliente.EliminarCliente();
            }

        public DataTable BuscarCliente()
        {
            PasarDatos();

            DataTable DT = new DataTable();
            DT = pasarcliente.BuscarCliente();

            return DT;
        }

        #endregion




    }
}
