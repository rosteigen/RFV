using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Data;

namespace LogicaDeNegocio
{
    public class LN_Proveedor
    {
        #region ATRIBUTOS

            private string idproveedor;
            private string razonsocial;
            private string cuit;
            private string calle;
            private string nro;
            private string piso;
            private string idlocalidad;
            private string telefono;
            private string mail;

        #endregion


        #region PROPERTIES

            public string IdProveedor
            {
                set { idproveedor = value; }
            }
            public string RazonSocial
            {
                set { razonsocial = value; }
            }
            public string Cuit
            {
                set { cuit = value; }
            }
            public string Calle
            {
                set { calle = value; }
            }
            public string Nro
            {
                set { nro = value; }
            }
            public string Piso
            {
                set { piso = value; }
            }
            public string IdLocalidad
            {
                set { idlocalidad = value; }
            }
            public string Telefono
            {
                set { telefono = value; }
            }
            public string Mail
            {
                set { mail = value; }
            }



        #endregion

        AD_Proveedor pasarproveedor = new AD_Proveedor();

        #region METODOS



        public void PasarDatos()
        {
            pasarproveedor.IdProveedor = Convert.ToInt32(idproveedor);
            pasarproveedor.RazonSocial = razonsocial;
            pasarproveedor.Calle = calle;
            pasarproveedor.Nro = Convert.ToInt32(nro);
            pasarproveedor.Piso = piso;
            pasarproveedor.Telefono = Convert.ToInt32(telefono);
            pasarproveedor.Mail = mail;
            pasarproveedor.IdLocalidad = Convert.ToInt32(idlocalidad);
            pasarproveedor.Cuit = cuit;
        }


        public void NuevoProveedor()
        {
            PasarDatos();
            pasarproveedor.NuevoProveedor();

        }

        public void ModificarProveedor()
        {
            PasarDatos();
            pasarproveedor.ModificarProveedor();
        }

        public void EliminarProveedor()
        {
            PasarDatos();
            pasarproveedor.EliminarProveedor();
        }

        public DataTable BuscarProveedor()
        {
            PasarDatos();

            DataTable DT = new DataTable();
            DT = pasarproveedor.BuscarProveedor();

            return DT;
        }

        #endregion

    }
}
