using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util_;
using BE_;

namespace DA_
{
    public class DA_RecepcionarCliente
    {
        public void getMesas()
        {
            

        public int getMesas(int IdMesa)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Obtener()))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT IdMesa FROM Mesas;", cn);
                    cmd.Parameters.AddWithValue("@Mesas", IdMesa);
                    cmd.CommandTimeout = 0;
                    cmd.CommandType = CommandType.Text;
                    var val = cmd.ExecuteScalar();
                    return val.();
                }
            }
            catch (Exception)
            {
                return String.Empty;
            }
        }
    }
}
