using BE_;
using DA_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_
{
    public class BL_RecepcionarCliente
    {
        DA_RecepcionarCliente dA_RecepcionarCliente;
        public BL_RecepcionarCliente()
        {
            dA_RecepcionarCliente = new DA_RecepcionarCliente();
        }
        public int GetMesas(int IdMesa)
        {
            return dA_RecepcionarCliente.getMesas(IdMesa);
        }
    }
}
