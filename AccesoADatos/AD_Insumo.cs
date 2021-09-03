using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoADatos
{
    public class AD_Insumo
    {

        #region ATRIBUTOS
        private int idinsumo;
        private string descripcion;



        #endregion

        #region PROPERTIES


            public int IdInsumo
            {
                set {  idinsumo = value; }
            }

            public string Descripcion
            {
                set { descripcion = value; }
            }
        #endregion

        #region METODOS

            AD_Conexion CN = new AD_Conexion();
            DataTable DT = new DataTable();

            public void NuevoInsumo()
            {
                string sql = "Insert into Insumo (Descripcion) values ('" + descripcion + "')";
                CN.Ejecutar(sql);
            }

            public DataTable BuscarInsumo()
            {

                string sql = "Select * from Insumo ";


                if (idinsumo != 0)
                {
                    sql += "where IdInsumo = " + idinsumo;
                }
                if (descripcion != "0")
                {
                    sql += "where Descripcion = " + descripcion;
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
