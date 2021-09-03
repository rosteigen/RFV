using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoADatos
{
    public class AD_Producto
    {



        #region ATRIBUTOS

            private int idproducto;
            private int codigodebarra;
            private string descripcion;
            private int idcategoria;
            private int idenvase;
            private int idsabor;
            private int unidadesdisponibles;
            private int stockminimo;
            private int stockmaximo;
            private int idproveedor;
            private int unidades;
        

        #endregion




        #region PROPIEDADES

            public int IdProducto
            {
                set { idproducto = value; }
            }

            public int CodigoDeBarra
            {
                set { codigodebarra = value; }
            }

            public string Descripcion
            {
                set { descripcion = value; }
            }
            public int IdCategoria
            {
                set { idcategoria = value; }
            }
            public int IdEnvase
            {
                set { idenvase = value; }
            }
            public int IdSabor
            {
                set { idsabor = value; }
            }
            public int UnidadesDisponibles
            {
                set { unidadesdisponibles = value; }
            }
            public int StockMaximo
            {
                set { stockmaximo = value; }
            }
            public int StockMinimo
            {
                set { stockminimo = value; }
            }
            public int IdProveedor
            {
                set { idproveedor = value; }
            }
            public int Unidades
            {
                set { unidades = value; }
            }
       
        #endregion


        AD_Conexion CN = new AD_Conexion();
        DataTable DT = new DataTable();

        #region METODOS




        public void NuevoProducto()
        {

            string sql = "Insert into Producto (CodigoDeBarra, Descripcion, IdCategoria, IdEnvase, IdSabor, UnidadesDisponibles, StockMinimo, StockMaximo, IdProveedor) " + "values ('" + codigodebarra + "', '" + descripcion + "', '" + idcategoria + "', '" + idenvase + "', '" + idsabor + "', '" + unidadesdisponibles + "', '" + stockminimo + "'," + "'" + stockmaximo + "', '" + idproveedor + "')";

            CN.Ejecutar(sql);

        }

        public void ModificarProducto()
        {

            string sql = "Update Producto set CodigoDeBarra= '" + codigodebarra + "', Descripcion= '" + descripcion + "', IdCategoria= " + idcategoria + ", IdEnvase= '" + idenvase + "', IdSabor= " + idsabor + ", UnidadesDiponibles= '" + unidadesdisponibles + "', StockMinimo= " + stockminimo + ", StockMaximo= '" + stockmaximo + "', IdProveedor= " + idproveedor + " where IdProducto = " + idproducto;

            CN.Ejecutar(sql);
        }

        public void EliminarProducto()
        {

            string sql = "Delete from Producto where IdProducto = " + idproducto;
            CN.Ejecutar(sql);
        }

        public DataTable BuscarProducto()
        {

            string sql = "Select * from Producto ";


            if (idproducto != 0)
            {
                sql += "where IdProducto = " + idproducto;
            }
            if (codigodebarra != 0)
            {
                sql += "where CodigoDeBarra = " + codigodebarra;
            }
            if (unidades != 0)
            {
                sql += "where UnidadesDisponibles < " + unidades;
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
