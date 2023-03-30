using BE_;
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
        public List<BE_Usuario> BL_Lista(string a,string b)
        {
            return dA_Usuario.ListaUsuario(a,b);
        }
        public string BL_Validacion(string user)
        {
            return dA_Usuario.GetCredencial(user);
        }
        public string GetRol(string user, string pass)
        {
            return dA_Usuario.getRolByCre(user, pass);
        }
        public bool ExisteUsuario(string user)
        {
            return dA_Usuario.ExisteUsuario(user);
        }
        public string ValidarUsuario(string p1, string p2, string p3, string p4, string p5)
        {
            return dA_Usuario.ValidaPreguntas(p1, p2, p3, p4, p5);
        }
    }
}
