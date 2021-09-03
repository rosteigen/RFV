using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Data;

namespace LogicaDeNegocio
{
    public class LN_SolicitudDeCompra
    {


        #region ATRIBUTOS

            private string idsolicitud;
            private string idtipo;
            private string idarea;
            private string fecha;
            private string cantidad;
            private string estado;
            private string descripcion;
            private string idproducto;
            private string idinsumo;

        #endregion

        #region PROPERTIES
            public string IdSolicitud
            {
                set { idsolicitud = value; }
            }
            public string IdTipo
            {
                set { idtipo = value; }
            }
            public string IdArea
            {
                set { idarea = value; }
            }
            public string Fecha
            {
                set { fecha = value; }
            }
            public string Cantidad
            {
                set { cantidad = value; }
            }
            public string Estado
            {
                set { estado = value; }
            }
            
            public string IdProducto
            {
                set { idproducto = value; }
            }
            public string IdInsumo
            {
                set { idinsumo = value; }
            }
            public string Descripcion
            {
                set { descripcion = value; }
            }
        #endregion

        #region METODOS

            AD_SolicitudDeCompra pasarSDC = new AD_SolicitudDeCompra();

            public void PasarDatos()
            {
                pasarSDC.IdSolicitud = Convert.ToInt32(idsolicitud);
                pasarSDC.IdTipo = Convert.ToInt32(idtipo);
                pasarSDC.IdArea = Convert.ToInt32(idarea);
                pasarSDC.Fecha = fecha;
                pasarSDC.Cantidad = Convert.ToInt32(cantidad);
                pasarSDC.Estado = Convert.ToInt32(estado);
                pasarSDC.Descripcion = descripcion;
                pasarSDC.IdProducto = Convert.ToInt32(idproducto);
                pasarSDC.IdInsumo = Convert.ToInt32(idinsumo);
            

            }

            public void NuevaSolicitud()
            {
                PasarDatos();
                pasarSDC.NuevaSolicitud();

               
            }
            public void NuevoDetalle()
            {
                PasarDatos();
                pasarSDC.NuevoDetalle();
            }

        public int UltimoIdSolicitud()
        {
            int id = pasarSDC.UltimoIdSolicitud();
            return id;
        }

        public DataTable BuscarSDCP()
        {
            DataTable DT = new DataTable();
            DT = pasarSDC.BuscarSDCP();

            return DT;
        }
        public DataTable BuscarSDCI()
        {

            DataTable DT = new DataTable();
            DT = pasarSDC.BuscarSDCI();
            return DT;
        }

        #endregion
    }
}
