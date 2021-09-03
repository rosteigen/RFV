using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoADatos
{
    public class AD_CargarCombo
    {

        #region ATRIBUTOS

        private string campoid;
        private string tabla;
        private string desc;
       

        #endregion

        #region PROPERTIES

       
        public string CampoId
        {
            set { campoid = value; }
        }

        public string Tabla
        {
            set { tabla = value; }
        }

        public string Desc
        {
            set { desc = value; }
        }

        #endregion

        #region METODOS

            private DataTable DTcbox = new DataTable();

        public DataTable cargarcbox()
        {

            string sql;

           
                sql = "Select " + campoid + ", " + desc + " from " + tabla;
            

            AD_Conexion CN = new AD_Conexion();
            SqlCommand cmd = new SqlCommand(sql, CN.AbrirConexion());
            SqlDataReader DR = cmd.ExecuteReader();
            DTcbox.Load(DR);
            CN.CerrarConexion();

            return DTcbox;
        }

        
        #endregion

    }
}
