using Capa_Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista
{
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
            llenarse1();
        }

        ClsControlador cn = new ClsControlador();

        public void llenarse1()
        {
            DataTable Datos = cn.itemsPuesto();
            Cmb_Puesto_Ingreso.DataSource = Datos;
            Cmb_Puesto_Ingreso.DisplayMember = "NOMBRE_PUESTO";
            Cmb_Puesto_Ingreso.ResetText();
        }

        public void llenarse2()
        {
            DataTable Datos = cn.itemsDepa();
            Cmb_Puesto_Ingreso.DataSource = Datos;
            Cmb_Puesto_Ingreso.DisplayMember = "NOMBRE_DEPARTAMENTO";
            Cmb_Puesto_Ingreso.ResetText();
        }

        private void Btn_Ingreso_Click(object sender, EventArgs e)
        {

        }
    }
}
