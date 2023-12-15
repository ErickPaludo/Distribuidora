using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distr
{
    public class Cargo
    {
        private string namecargo;
        private int id;
        private string descricao;

        public string NameCargo { get; set; }

        public int ID { get; set; }

        public string Descricao { get; set; }

        public Cargo(string namecargo, int id, string descricao)
        {
            this.namecargo = namecargo;
            this.id = id;
            this.descricao = descricao;
        }
        public void AddCargo(string cargo, string descrição, int id)
        {
        }
    }
}