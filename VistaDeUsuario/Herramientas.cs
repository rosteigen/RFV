using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaDeNegocio;

namespace VistaDeUsuario
{
    public class Herramientas
    {

        public static void CargarCombo(ComboBox cmb, string campoid, string desc, string tabla)
        {
            LN_CargarCombo cargar = new LN_CargarCombo();

            cargar.CampoId = campoid;
            cargar.Desc = desc;
            cargar.Tabla = tabla;

            cmb.DataSource = cargar.Cargarcmb();
            cmb.DisplayMember = desc;
            cmb.ValueMember = campoid;
            cmb.SelectedIndex = -1;

        }
        
        
    }
}
