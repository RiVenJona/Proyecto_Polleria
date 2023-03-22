using BE_;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util_;

namespace DA_
{
    public class DA_Usuario
    {
        public List<BE_Usuario> ListaUsuario(string user,string pass)
        {
            SqlDataReader rd = null;
            using (SqlConnection cn = new SqlConnection(Conexion.Obtener()))
            {
                cn.Open();
                SqlDataAdapter dt = new SqlDataAdapter();
                SqlCommand sc;
                sc = new SqlCommand("[dbo].[ValidacionLogin]",cn);
                sc.Parameters.AddWithValue("@user", user);
                sc.Parameters.AddWithValue("@pass", pass);
                sc.CommandTimeout = 0;
                sc.CommandType = CommandType.StoredProcedure;
                rd = sc.ExecuteReader();
                BE_Usuario usuarios;
                List<BE_Usuario> ListaUsers = new List<BE_Usuario>();             
                while (rd.Read())
                {
                    usuarios = new BE_Usuario();
                    usuarios.IdUsuario = int.Parse(rd["IdCuenta"].ToString());
                    ListaUsers.Add(usuarios);
                }
                return ListaUsers;
            }
        }
        public bool Entrar()
        {
            return true;
        }
    }
}
