﻿using BE_;
using DA_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_
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