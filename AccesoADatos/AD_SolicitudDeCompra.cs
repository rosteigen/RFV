using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoADatos
{
    public class AD_SolicitudDeCompra
    {
        #region ATRIBUTOS
            private int idsolicitud;
            private int idtipo;
            private int idarea;
            private string fecha;
            private int cantidad;
            private int estado;
            private string descripcion;
            private int idproducto;
            private int idinsumo;

        #endregion

        #region PROPERTIES
        public int IdSolicitud
        {
            set { idsolicitud = value; }
        }
        public int IdTipo
        {
            set { idtipo = value; }
        }
        public int IdArea
        {
            set { idarea = value; }
        }
        public string Fecha
        {
            set { fecha = value; }
        }
        public int Cantidad
        {
            set { cantidad = value; }
        }
        public int Estado
        {
            set { estado = value; }
        }
        
        public int IdProducto
        {
            set { idproducto = value; }
        }
        public int IdInsumo
        {
            set { idinsumo = value; }
        }
        public string Descripcion
        {
            set { descripcion = value; }
        }
        #endregion

        AD_Conexion CN = new AD_Conexion();
        DataTable DT = new DataTable();

        #region METODOS

            public void NuevaSolicitud() 
            {
                string sql = "Insert into SolicitudDeCompra (IdTipo, IdArea, Fecha, Estado) " + "values ('"  + idtipo + "', '" + idarea + "', '" + fecha + "','" + estado + "')";
                CN.Ejecutar(sql);

                

            }

            public int UltimoIdSolicitud()
            {
                string sql = "select IDENT_CURRENT('SolicitudDeCompra')";

                SqlCommand cmd = new SqlCommand(sql, CN.AbrirConexion());
                int id = Convert.ToInt32(cmd.ExecuteScalar());

                CN.CerrarConexion();
                return id;
            }
            
            public void NuevoDetalle()
            {
                string sql;

                if(idproducto!= 0)
                {
                    sql = "Insert into DetalleSDP (IdSolicitudDeCompra, IdProducto, Cantidad) " + "values (IDENT_CURRENT('SolicitudDeCompra'), '" + idproducto + "','" + cantidad + "')";
                }
                else
                {
                    sql = "Insert into DetalleSDI (IdSolicitudDeCompra, IdInsumo, Cantidad) " + "values (IDENT_CURRENT('SolicitudDeCompra'), '" + idinsumo + "','" + cantidad + "')";
                }

                CN.Ejecutar(sql);
            }

            public DataTable BuscarSDCP()
            {

                string sql = "SELECT SolicitudDeCompra.IdSolicitudDeCompra as 'ID', SolicitudDeCompra.Fecha, Producto.IdProducto as 'IDProducto', Producto.Descripcion as 'Nombre', DetalleSDP.cantidad as 'Cantidad', Area.Area, TipoDeSolicitud.Descripcion as 'Tipo', SolicitudDeCompra.Estado  FROM(TipoDeSolicitud INNER JOIN(Area INNER JOIN SolicitudDeCompra ON Area.[IdArea] = SolicitudDeCompra.[idArea]) ON TipoDeSolicitud.[IdTipo] = SolicitudDeCompra.[idTipo]) INNER JOIN(Producto INNER JOIN DetalleSDP ON Producto.[IdProducto] = DetalleSDP.[IdProducto]) ON SolicitudDeCompra.[IdSolicitudDeCompra] = DetalleSDP.[IdSolicitudDeCompra] where SolicitudDeCompra.Estado = 0; ";


                DT.Clear();
                SqlCommand cmd = new SqlCommand(sql, CN.AbrirConexion());
                SqlDataReader DR = cmd.ExecuteReader();
                DT.Load(DR);
                CN.CerrarConexion();
                return DT;
            }
            public DataTable BuscarSDCI()
            {

                string sql = "SELECT SolicitudDeCompra.Fecha, SolicitudDeCompra.IdSolicitudDeCompra as 'ID', Insumo.Descripcion as 'Nombre', DetalleSDI.cantidad as 'Cantidad', Area.Area, TipoDeSolicitud.Descripcion as 'Tipo', SolicitudDeCompra.Estado FROM(TipoDeSolicitud INNER JOIN(Area INNER JOIN SolicitudDeCompra ON Area.[IdArea] = SolicitudDeCompra.[idArea]) ON TipoDeSolicitud.[IdTipo] = SolicitudDeCompra.[idTipo]) INNER JOIN(Insumo INNER JOIN DetalleSDI ON Insumo.[IdInsumo] = DetalleSDI.[IdInsumo]) ON SolicitudDeCompra.[IdSolicitudDeCompra] = DetalleSDI.[IdSolicitudDeCompra] where SolicitudDeCompra.Estado = 0; ";


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
