using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distr
{
    public class Login
    {
        private Usuario usuario;
        private string senha;
        private int id;

        public Usuario Usuario { get; set; }

        public string Senha { get; set; }
        public int ID { get; set; }

        public Login(Usuario usuario, string senha, int id)
        {
            this.usuario = usuario;
            this.senha = senha;
            this.id = id;
        }
    }
}