﻿using System;
using BE_;
using System.Data.SqlClient;
using Util_;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_
{
    public class DA_Persona
    {
        public List<BE_Persona> BuscaCliente(int DNI)
        {
            SqlDataReader rd = null;
            using (SqlConnection cn = new SqlConnection(Conexion.Obtener()))
            {
                cn.Open();
                SqlDataAdapter dt = new SqlDataAdapter();
                SqlCommand sc;
                sc = new SqlCommand("[dbo].[BuscaPersona]", cn);
                sc.Parameters.AddWithValue("@DNI", DNI);
                sc.CommandTimeout = 0;
                sc.CommandType = CommandType.StoredProcedure;
                rd = sc.ExecuteReader();
                BE_Persona ListaPersona;
                List<BE_Persona> Reserva = new List<BE_Persona>();
                while (rd.Read())
                {
                    ListaPersona = new BE_Persona();
                    ListaPersona.Nombre = rd["Nombre"].ToString();
                    ListaPersona.Apellidos = rd["Apellidos"].ToString();
                    ListaPersona.DNI = int.Parse(rd["DNI"].ToString());
                    ListaPersona.Telefono = int.Parse(rd["Telefono"].ToString());
                    ListaPersona.Correo = rd["Correo"].ToString();
                    ListaPersona.Direccion = rd["Direccion"].ToString();
                    Reserva.Add(ListaPersona);
                }
                return Reserva;
            }
        }
    }
}
