using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distr
{
    public class Usuario : Endereco
    {
        private string nome;
        private string cpf;
        private Cargo cargo;
        private DateTime contratacao;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public Cargo Cargo { get; set; }
        public DateTime Contratacao { get; set; }
        public Usuario(string nome, string cpf, Cargo cargo, DateTime contratacao, string rua, int numero, string complemento, string bairro, string cidade, string uf, string cep) : base(rua, numero, complemento, bairro, cidade, uf, cep)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.cargo = cargo;
            this.contratacao = contratacao;
        }
    }
}