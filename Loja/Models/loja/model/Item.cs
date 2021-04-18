using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.model
{
    class Item
    {
        //-------------- Atributos
        
        private Guid _uid;
        private string _nome;
        private decimal _pUnitario;
        private decimal _quantidade;
        
        //--------------Propriedades
        
        public string Nome
        {
            get { return _nome; }
            set {
                _nome = value;
                if (_nome.Length == 0) _nome = "A definir";
            }
        }

        public decimal PUnitario
        {
            get { return _pUnitario; }
            set
            {
                _pUnitario = value;
                if (_pUnitario <= 0)
                {
                    _pUnitario = -1;
                }
            }
        }

        public decimal Qtd
        {
            get { return _quantidade; }
            set
            {
                _quantidade = value;
                if (_quantidade < 0)
                {
                    _quantidade = -1;
                }
            }
        }

        public Item()
        {
            _uid = Guid.NewGuid();
            Nome = "";
            PUnitario = 0;
            Qtd = 0;
        }

        public Item (string nome, decimal pUnitario, decimal qtd)
        {
            _uid = Guid.NewGuid();
            Nome = nome;
            PUnitario = pUnitario;
            Qtd = qtd;
        }

        public virtual string getInfo()
        {
            return "\t<id>" + _uid + "</id>\n\t<Nome> " + Nome + " </Nome>\n\t<PUnitario> " + PUnitario+" </PUnitario>\n\t";
        }
    }
}
