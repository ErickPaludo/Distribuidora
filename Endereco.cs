using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distr
{
    public class Endereco
    {
        private string rua;
        private int numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;


        public Endereco(string rua, int numero, string complemento, string bairro, string cidade, string uf, string cep)
        {
            this.rua = rua;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.uf = uf;
            this.cep = cep;
        }
        public string Rua { get; set;}
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public override string ToString()
        {
            return $"{rua};{numero};{complemento};{bairro};{cidade};{uf};{cep}";
        }
    }
}