using Capa_Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Controlador
{
    public class ClsControlador
    {
        ClsSentencias sn = new ClsSentencias();
        public DataTable itemsPuesto()
        {
            DataTable Items = sn.llenarCmbPuesto();
            return Items;
        }

        public DataTable itemsDepa()
        {
            DataTable Items = sn.llenarCmbDepa();
            return Items;
        }

        public void IngresoEmpleado()
        {
            
        }

    }
}
