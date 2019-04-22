using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
//using Capa_Entidad;


namespace Capa_Datos
{
    class BD_Usuario : BD_Conexion
    {
        public bool VerificarAcceso(string Usuario, string Contraseña)
        {
            bool functionReturnValue = false;
            Int32 xfil = 0;

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            con.ConnectionString = ConectarBD();
            var _with1 = cmd;
            _with1.CommandText = "Sp_Login";
            _with1.Connection = con;
            _with1.CommandTimeout = 20;
            _with1.CommandType = CommandType.StoredProcedure;
            _with1.Parameters.AddWithValue("@Usuario", Usuario);
            _with1.Parameters.AddWithValue("@Contraseña", Contraseña);

            try
            {
                con.Open();
                xfil = (Int32)cmd.ExecuteScalar();
                if (xfil > 0)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }

            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    cmd.Dispose();
                    cmd = null;
                    con.Close();
                    con = null;

                    //MessageBox.Show("Fallo al Consultar: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception("Fallo al buscar el Usuario: " + ex.Message);
                }
            }
            finally
            {
                cmd.Parameters.Clear();
                cmd.Dispose();
                cmd = null;
                con.Close();
                con = null;
            }

            return functionReturnValue;
        }
    }
}
