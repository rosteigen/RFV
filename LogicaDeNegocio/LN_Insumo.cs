using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Data;

namespace LogicaDeNegocio
{
    public class LN_Insumo
    {

        #region ATRIBUTOS
           
            private string idinsumo;
            private string descripcion;

        #endregion

        #region PROPERTIES


            public string IdInsumo
            {
                set { idinsumo = value; }
            }

            public string Descripcion
            {
                set { descripcion = value; }
            }
        #endregion

        AD_Insumo pasarinsumo = new AD_Insumo();

        #region METODOS

            public void PasarDatos()
            {
                pasarinsumo.IdInsumo = Convert.ToInt32(idinsumo);
                pasarinsumo.Descripcion = descripcion;
            }

            public void NuevoInsumo()
            {
                PasarDatos();
                pasarinsumo.NuevoInsumo();
            }

            public DataTable BuscarInsumo()
            {
                PasarDatos();

                DataTable DT = new DataTable();
                DT = pasarinsumo.BuscarInsumo();

                return DT;
            }

        #endregion
    }
}
