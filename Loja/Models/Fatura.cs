using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Models
{
    class Fatura
    {
        private DateTime _dtFatura;
        private List<Item> _produtoFaturado;

        public DateTime DtFatura
        {
            get
            {
                return _dtFatura;
            }
            set
            {
                _dtFatura = value;
            }

            
        }

        public Fatura()
        {
            _dtFatura = DateTime.Now;
            _produtoFaturado = new List<Item>();
        }

        public void Add(Item itemFaturado)
        {
            _produtoFaturado.Add(itemFaturado);
        }

        public string getInfo()
        {
            string info = "\nFatura de: " + DtFatura + "\nItens: ";
            foreach (Item x in _produtoFaturado)
            {
                info += "\n" + x.getInfo();
            }
            return info;
        }

    }
}
