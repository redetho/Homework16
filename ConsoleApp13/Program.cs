using System;
using ConsoleApp13;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            //cria uma lista com as informações inseridas.
            List<Class1> list = new List<Class1>();
            //recebe cota, e quantos dólares comprou.
            Console.WriteLine("Qual é a cotação do dólar?");
            //valor da cota: 5.59 (encontrado em https://economia.uol.com.br/noticias/redacao/2021/11/24/dolar-comercial-opera-em-queda-r-5606.htm)
            double cota = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos dólares irá comprar?");
            double dolarComprado = double.Parse(Console.ReadLine());
            //valor do IOF encontrado em: https://agenciabrasil.ebc.com.br/economia/noticia/2021-09/comecam-a-valer-hoje-novas-aliquotas-do-IOF#:~:text=Para%20as%20pessoas%20físicas%20a,diária%20de%200%2C00559%25).
            double IOF = 4.08;
            list.Add(new Class2(IOF, dolarComprado, cota));
            foreach (Class2 classe in list) {
                double ciof = classe.dolarCIOF();
                double siof = classe.dolarSIOF();
                Console.WriteLine();
                Console.WriteLine("Valor a ser pago em reais: R$" + siof);
                Console.WriteLine();
                Console.WriteLine("Valor a ser pago de IOF: " + IOF + "%");
                Console.WriteLine();
                Console.WriteLine("Valor da compra com IOF: R$" + ciof);
                    }


        }
    }
}
