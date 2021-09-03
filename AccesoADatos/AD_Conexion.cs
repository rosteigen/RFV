using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoADatos
{
    public class AD_Conexion
    {

        private SqlConnection CN = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Initial Catalog = RFV; Integrated Security = True");


        public SqlConnection AbrirConexion()
        {
            if (CN.State == ConnectionState.Open)
            {
                CN.Close();
            }
            CN.Open();
            return CN;
        }

        public SqlConnection CerrarConexion()
        {
            CN.Close();
            return CN;
        }

        public void Ejecutar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, AbrirConexion());
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }


    }
}
