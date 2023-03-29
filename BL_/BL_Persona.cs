using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_;
using DA_;

namespace BL_
{
    public class BL_Persona
    {
        DA_Persona dA_Persona;
        public BL_Persona()
        {
            dA_Persona = new DA_Persona();
        }
        public List<BE_Persona> BL_RegPersona(int a)
        {
            return dA_Persona.BuscaCliente(a);
        }
    }
    
}
