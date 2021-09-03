using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoADatos;
using System.Data;

namespace LogicaDeNegocio
{
    public class LN_CargarCombo
    {

        private AD_CargarCombo cargarcbox = new AD_CargarCombo();

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

        public DataTable Cargarcmb()
        {
            cargarcbox.CampoId = campoid;
            cargarcbox.Tabla = tabla;
            cargarcbox.Desc = desc;
           

            DataTable DT = new DataTable();
            DT = cargarcbox.cargarcbox();
            return DT;
        }

        
        #endregion

    }
}
