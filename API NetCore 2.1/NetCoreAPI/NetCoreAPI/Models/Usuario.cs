using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPI.Models
{
    public class Usuario
    {

        public int UsuarioId { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }
    }
}
