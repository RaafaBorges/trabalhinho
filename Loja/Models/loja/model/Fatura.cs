using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.model
{
    class Fatura
    {
        private DateTime _dtFatura;
        private List<Item> _produtoFaturado;
        private Decimal _valorTotal;
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
        public Decimal ValorTotal
        {
            get
            {
                return _valorTotal;
            }
            set
            {
                _valorTotal = value;
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
            _valorTotal += itemFaturado.PUnitario;
        }
        public void CalculaTotalDaFatura()
        {
            _valorTotal = 0;
            foreach (Item item in _produtoFaturado)
            {
                _valorTotal += item.PUnitario;

            }

        }

        public void getInfo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\n******************************** Fatura de: " + DtFatura + " ********************************");
            Console.ForegroundColor = ConsoleColor.White;
            string info = "";
            foreach (Item x in _produtoFaturado)
            {
                info += "\n" + x.getInfo();
            }

            Console.Write(info + "\nTotal da fatura\t");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_valorTotal+"$");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
