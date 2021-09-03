using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace AccesoADatos
{
    public class AD_Cliente
    {


        #region ATRIBUTOS

            private int idcliente;
            private string razonsocial;
            private string calle;
            private int numero;
            private string piso;
            private int telefono;
            private string mail;
            private int idlocalidad;
            private string cuit;
            private int idcondicion;

        #endregion


        

        #region PROPIEDADES

        public int IdCliente
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
        public int Numero
        {
            set { numero = value; }
        }
        public string Piso
        {
            set { piso = value; }
        }
        public int Telefono
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
        public int IdLocalidad
        {
            set { idlocalidad = value; }
        }
        public int IdCondicion
        {
            set { idcondicion = value; }
        }
        #endregion


        AD_Conexion CN = new AD_Conexion();
        DataTable DT = new DataTable();

        #region METODOS
            public void NuevoCliente()
            {

                string sql = "Insert into Cliente (RazonSocial, Calle, Numero, Piso, Telefono, eMail, IdLocalidad, CUIT, IdCondicionIVA) " +"values ('" + razonsocial + "', '" + calle + "', '" + numero + "', '" + piso + "', '" + telefono + "', '" + mail + "', '" + idlocalidad + "'," +"'" + cuit + "', '" + idcondicion + "')";

                CN.Ejecutar(sql);

            }
        
            public void ModificarCliente()
            {

                string sql = "Update Cliente set RazonSocial= '" + razonsocial + "', Calle= '" + calle + "', Numero= " + numero + ", Piso= '" + piso + "', Telefono= " + telefono + ", eMail= '" + mail + "', IdLocalidad= " + idlocalidad + ", CUIT= '" + cuit + "', IdCondicionIVA= " + idcondicion + " where IdCliente = " + idcliente;

                CN.Ejecutar(sql);
            }
        
            public void EliminarCliente()
            {

                string sql = "Delete from Cliente where IdCliente = " + idcliente;
                CN.Ejecutar(sql);
            }

            public DataTable BuscarCliente()
            {

                string sql = "Select * from Cliente ";
            

                if (idcliente != 0)
                {
                    sql += "where IdCliente = " + idcliente;
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
