using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class Class2 : Class1
    {
        //construtores e overrides
        public Class2(double iof, double dolarComprado, double cota)
            :base(iof, dolarComprado, cota)
        {
            IOF = iof;
            DolarComprado = dolarComprado;
            Cota = cota;
        }

        public override double dolarSIOF()
        {
            ValorTotalSIOF = DolarComprado * Cota;
            return (ValorTotalSIOF);
        }
        public override double dolarCIOF()
        {
            ValorTotalSIOF = DolarComprado * Cota;
            ValorTotalCIOF = ValorTotalSIOF + (ValorTotalSIOF / 100 * IOF);
            return (ValorTotalCIOF);
        }
    }
}
