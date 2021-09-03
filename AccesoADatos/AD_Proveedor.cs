using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoADatos
{
    public class AD_Proveedor
    {



        #region ATRIBUTOS

            private int idproveedor;
            private string razonsocial;
            private string cuit;
            private string calle;
            private int nro;
            private string piso;
            private int idlocalidad;
            private int telefono;
            private string mail;

        #endregion


        #region PROPERTIES

            public int IdProveedor
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
            public int Nro
            {
                set { nro = value; }
            }
            public string Piso
            {
                set { piso = value; }
            }
            public int IdLocalidad
            {
                set { idlocalidad = value; }
            }
            public int Telefono
            {
                set { telefono = value; }
            }
            public string Mail
            {
                set { mail = value; }
            }



        #endregion


        #region METODOS


            AD_Conexion CN = new AD_Conexion();
            DataTable DT = new DataTable();

            public void NuevoProveedor()
            {

                string sql = "Insert into Proveedor (RazonSocial, CUIT, Calle, Numero, Piso, IdLocalidad, Telefono, eMail) " + "values ('" + razonsocial + "'," + "'" + cuit + "', '" + calle + "', '" + nro + "', '" + piso + "', '" + idlocalidad + "', '" + telefono + "', '" + mail + "')";

                CN.Ejecutar(sql);

            }

            public void ModificarProveedor()
            {

                string sql = "Update Proveedor set RazonSocial= '" + razonsocial + "', Calle= '" + calle + "', Numero= " + nro + ", Piso= '" + piso + "', Telefono= " + telefono + ", eMail= '" + mail + "', IdLocalidad= " + idlocalidad + ", CUIT= '" + cuit + "' where IdProveedor = " + idproveedor;

                CN.Ejecutar(sql);
            }

            public void EliminarProveedor()
            {

                string sql = "Delete from Proveedor where IdProveedor = " + idproveedor;
                CN.Ejecutar(sql);
            }

            public DataTable BuscarProveedor()
            {

                string sql = "Select * from Proveedor ";


                if (idproveedor != 0)
                {
                    sql += "where IdProveedor = " + idproveedor;
                }
                if (cuit != "0")
                {
                    sql += "where CUIT = " + cuit;
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
