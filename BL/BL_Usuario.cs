using BE;
using DA;
using System;
using System.Collections.Generic;

namespace BL
{
    public class BL_Usuario
    {
        DA_Usuario dA_Usuario;
        public BL_Usuario()
        {
            dA_Usuario = new DA_Usuario();
        }
        public List<BE_Usuario> BL_Lista()
        {
            return dA_Usuario.ListaUsuario();
        }
    }
}
