using BE_;
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

    }
}
