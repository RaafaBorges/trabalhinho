using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Models
{
    class Servico : Item
    {
        private string _responsavel;
        private string _morada;

        public string Responsavel
        {
            get
            {
                return _responsavel;
            }
            set
            {
                _responsavel = value;
                if (_responsavel.Length == 0) _responsavel = "A definir responsavel";
            }
        }

        public string Morada
        {
            get
            {
                return _morada;
            }
            set
            {
                _morada = value;
                if (_morada.Length == 0) _responsavel = "Definir morada";
            }
        }

        public Servico () : base()
        {
            Responsavel = "";
            Morada = "";
        }

        public Servico(string nome, decimal pu, decimal qtd, string responsavel, string morada) : base(nome, pu, qtd)
        {
            Responsavel = responsavel;
            Morada = morada;
        }

        public override string getInfo()
        {
            return "Serviço: " + base.getInfo() + "Responsável: " + Responsavel + "Morada: " + Morada;
        }
    }

}
