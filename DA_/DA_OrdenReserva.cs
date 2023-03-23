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
    public class DA_OrdenReserva
    {
        public List<BE_OrdenReserva> ListaOrdenReserva(string NumOrdenRe)
        {
            SqlDataReader rd = null;
            using (SqlConnection cn = new SqlConnection(Conexion.Obtener()))
            {
                cn.Open();
                SqlDataAdapter dt = new SqlDataAdapter();
                SqlCommand sc;
                sc = new SqlCommand("[dbo].[BuscaReserva]", cn);
                sc.Parameters.AddWithValue("@OrdenReserva", NumOrdenRe);
                sc.CommandTimeout = 0;
                sc.CommandType = CommandType.StoredProcedure;
                rd = sc.ExecuteReader();
                BE_OrdenReserva ListaReserva;
                List<BE_OrdenReserva> Reserva = new List<BE_OrdenReserva>();
                while (rd.Read())
                {
                    ListaReserva = new BE_OrdenReserva();
                    ListaReserva.NumOrdenRe = rd["NumOrdenRe"].ToString();
                    ListaReserva.FechaProgra = rd["FechaProgra"].ToString();
                    ListaReserva.Nombre = rd["Nombre"].ToString();
                    ListaReserva.Apellidos = rd["Apellidos"].ToString();
                    ListaReserva.IdMesa = int.Parse(rd["IdMesa"].ToString());
                    ListaReserva.Espacio = int.Parse(rd["Espacios"].ToString());
                    ListaReserva.EstadoOrden = rd["DescEstado"].ToString();
                    Reserva.Add(ListaReserva);
                }
                return Reserva;
            }
        }
        public bool AnularReserva(string NumOrdenRe)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conexion.Obtener()))
                {
                    cn.Open();
                    SqlDataAdapter dt = new SqlDataAdapter();
                    SqlCommand sc;
                    sc = new SqlCommand("[dbo].[AnularReserva]", cn);
                    sc.Parameters.AddWithValue("@OrdenReserva", NumOrdenRe);
                    sc.CommandTimeout = 0;
                    sc.CommandType = CommandType.StoredProcedure;
                    var anul = sc.ExecuteScalar();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
               
        }

    }
}
