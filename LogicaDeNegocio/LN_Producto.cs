using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AccesoADatos;

namespace LogicaDeNegocio
{
    public class LN_Producto
    {

        #region ATRIBUTOS

        private string idproducto;
        private string codigodebarra;
        private string descripcion;
        private string idcategoria;
        private string idenvase;
        private string idsabor;
        private string unidadesdisponibles;
        private string stockminimo;
        private string stockmaximo;
        private string idproveedor;
        private string unidades;


        #endregion




        #region PROPIEDADES

        public string IdProducto
        {
            set { idproducto = value; }
        }

        public string CodigoDeBarra
        {
            set { codigodebarra = value; }
        }

        public string Descripcion
        {
            set { descripcion = value; }
        }
        public string IdCategoria
        {
            set { idcategoria = value; }
        }
        public string IdEnvase
        {
            set { idenvase = value; }
        }
        public string IdSabor
        {
            set { idsabor = value; }
        }
        public string UnidadesDisponibles
        {
            set { unidadesdisponibles = value; }
        }
        public string StockMaximo
        {
            set { stockmaximo = value; }
        }
        public string StockMinimo
        {
            set { stockminimo = value; }
        }
        public string IdProveedor
        {
            set { idproveedor = value; }
        }
        public string Unidades
        {
            set { unidades = value; }
        }

        #endregion

        AD_Producto pasarproducto = new AD_Producto();

        #region METODOS



        public void PasarDatos()
        {
            pasarproducto.IdProducto = Convert.ToInt32(idproducto);
            pasarproducto.CodigoDeBarra = Convert.ToInt32(codigodebarra);
            pasarproducto.Descripcion = descripcion;
            pasarproducto.IdCategoria = Convert.ToInt32(idcategoria);
            pasarproducto.IdEnvase = Convert.ToInt32(idenvase);
            pasarproducto.IdSabor = Convert.ToInt32(idsabor);
            pasarproducto.UnidadesDisponibles = Convert.ToInt32(unidadesdisponibles);
            pasarproducto.StockMinimo = Convert.ToInt32(stockminimo);
            pasarproducto.StockMaximo = Convert.ToInt32(stockmaximo);
            pasarproducto.IdProveedor = Convert.ToInt32(idproveedor);
            pasarproducto.Unidades = Convert.ToInt32(unidades);

        }


        public void NuevoProducto()
        {
            PasarDatos();
            pasarproducto.NuevoProducto();

        }

        public void ModificarProducto()
        {
            PasarDatos();
            pasarproducto.ModificarProducto();
        }

        public void EliminarProducto()
        {
            PasarDatos();
            pasarproducto.EliminarProducto();
        }

        public DataTable BuscarProducto()
        {
            PasarDatos();

            DataTable DT = new DataTable();
            DT = pasarproducto.BuscarProducto();

            return DT;
        }

        #endregion




    }




}

