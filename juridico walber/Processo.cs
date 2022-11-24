using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace juridico
{
    class Processo
    {
        public int Numero { get; set; }

        public DateTime DataCriacao { get; set; }

        public pessoa Solicitante { get; set; }

        public pessoa acusado { get; set; }

        public Pedidos pedido { get; set; }

        public double getValortotalPedidos()

        { 
            return 1;
        }
        public double getQuantidadePedidos()
        { 
            return 1;
        }
        public List<Processo> getprocessosPorEscreito()
        {
            return 1;
        }
}
