using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.model
{
    class Produto : Item
    {
        private decimal _stock;


        public decimal Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                if (_stock <= 0) _stock = -1;
            }
        }

        public Produto() : base()
        {
            Stock = 0;
        }

        public Produto(string nome, decimal pu, decimal qtd, decimal stock) : base(nome, pu, qtd)
        {
            Stock = stock;
        }

        public override string getInfo()
        {
            return "<Produto>\n" + base.getInfo() + "<Stock> " + Stock + "</Stock>\n</Produto>\n\n";
        }
    }
}
