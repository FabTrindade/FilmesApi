using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsuariosApi.Models
{
    public class Token
    {
        public Token(string value)
        {
            Valor = value;
        }
        public string Valor { get;}
    }
}
