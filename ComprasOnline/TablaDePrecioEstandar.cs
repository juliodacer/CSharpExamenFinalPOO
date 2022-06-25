using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComprasOnline
{
    public class TablaDePrecioEstandar : IRegla
    {
        public decimal Calcular(Compra compra)
        {
           if (compra.Valor > 1000)
            {
                return compra.Valor - ((compra.Valor * 3)/100);
            }
            else if (compra.Valor > 5000)
            {
                return compra.Valor - ((compra.Valor * 5) / 100);
            }
            else
            {
                return compra.Valor;
            }
        }
    }
}
