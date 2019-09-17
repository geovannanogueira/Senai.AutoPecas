using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Senai.AutoPecas.WebApi.Domains
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Fornecedores = new HashSet<Fornecedores>();
        }

        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Permissao { get; set; }

        public ICollection<Fornecedores> Fornecedores { get; set; }

    }
}
