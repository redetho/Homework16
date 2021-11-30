using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    abstract class Class1
    {
        //construtores e classes
        public double IOF { get; set; }
        public double ValorTotalSIOF { get; set; }
        public double DolarComprado { get; set; }
        public double Cota { get; set; }  
        public double ValorTotalCIOF { get; set; }
        protected Class1(double iof, double dolarComprado, double cota)
        {
            IOF = iof;
            DolarComprado = dolarComprado;
            Cota = cota;
        }

        public abstract double dolarSIOF();
        public abstract double dolarCIOF();
        
    }
}
