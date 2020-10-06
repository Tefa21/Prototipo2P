using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Modelo
{
    public class ClsSentencias
    {
        ClsConexion con = new ClsConexion();

        public DataTable llenarCmbPuesto()
        {
            string sql = "SELECT NOMBRE_PUESTO FROM PUESTO;";
            DataTable Datos = new DataTable();


            try
            {

                string CargaPuestos = "SELECT * FROM PUESTO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                

                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);
                return Datos;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;

            }

            
            
        }

        public DataTable llenarCmbDepa()
        {
            string sql = "SELECT NOMBRE_DEPARTAMENTO FROM DEPARTAMENTO;";
            DataTable Datos = new DataTable();


            try
            {

                string CargaDepa = "SELECT * FROM DEPARTAMENTO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaDepa, con.conexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();


                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);
                return Datos;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;

            }

        }

        public void IngresoEmpleado(string Nombre1, string Nombre2, string Apellido1, string Apellido2, int TipoPuesto,  string TipoDepa)
        {

            try
            {

                int ID_Empleado;
                string Correlativo = "SELECT IFNULL(MAX(ID_EMPLEADO),0) +1 FROM EMPLEADO";
                OdbcCommand Query_Validacion1 = new OdbcCommand(Correlativo, con.conexion());
                ID_Empleado = Convert.ToInt32(Query_Validacion1.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion1.ExecuteReader();

                
                string InsertarEmpleado = "INSERT INTO EMPLEADO (CODIGO_EMPLEADO, NOMBRE1_EMPLEADO, NOMBRE2_EMPLEADO, APELLIDO1_EMPLEADO, APELLIDO2_EMPLEADO, CODIGO_PUESTO, CODIGO_DEPARTAMENTO, ESTATUS_EMPLEADO) VALUES ('" + ID_Empleado + "','" + Nombre1 + "','" + Nombre2 + "','" + Apellido1 +
                "','" + Apellido2 + "','" + TipoPuesto + "','" + TipoDepa + "','" + 1 + "')";

                OdbcCommand Query_Validacion2 = new OdbcCommand(InsertarEmpleado, con.conexion());
                Query_Validacion2.ExecuteNonQuery();



                MessageBox.Show("Ingreso Exitoso", "FORMULARIO EMPLEADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

    }
}
