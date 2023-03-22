using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BE;
using Util;
namespace DA
{
    public class DA_Usuario
    {
        public List<BE_Usuario> ListaUsuario()
        {
            using (SqlConnection cn = new SqlConnection(Conexion.Obtener()))
            {
                cn.Open();
                SqlDataAdapter dt = new SqlDataAdapter();
                SqlCommand sc;
                sc = new SqlCommand("Select * FROM cuenta");
                sc.CommandTimeout = 0;
                sc.CommandType = CommandType.Text;
                SqlDataReader rd = null;
                BE_Usuario usuarios;
                List<BE_Usuario> ListaUsers= new List<BE_Usuario>();
                rd = sc.ExecuteReader();
                while (rd.Read())
                {
                    usuarios = new BE_Usuario();
                    usuarios.IdUsuario = int.Parse(rd["IdCuenta"].ToString());
                    usuarios.User = rd["Usuario"].ToString();
                    usuarios.Password = rd["Password"].ToString();
                    usuarios.State = int.Parse(rd["Estado"].ToString());
                    ListaUsers.Add(usuarios);
                }
                return ListaUsers;
            }
        }
    }
}
