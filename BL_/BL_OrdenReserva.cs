﻿using BE_;
using DA_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_
{
    public class BL_OrdenReserva
    {
        DA_OrdenReserva dA_Orden;
        public BL_OrdenReserva()
        {
            dA_Orden = new DA_OrdenReserva();
        }
        public List<BE_OrdenReserva> BL_Reserva(string a)
        {
            return dA_Orden.ListaOrdenReserva(a);
        }
        public bool BL_RegistrarReserva(int mesa, DateTime fecha, int hora, int tra, int dni)
        {
            return dA_Orden.RegistrarReserva(mesa, fecha, hora, tra, dni);
        }
        public bool BL_AnulaReserva(String b)
        {
            return dA_Orden.AnularReserva(b);
        }

    }
}
