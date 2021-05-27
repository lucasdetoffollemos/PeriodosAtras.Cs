using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodosAtras
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataInformada = new DateTime(2021,05,26,10,50,10);
            Data data = new Data(dataInformada);
            ConversorData conversor = new ConversorData();

            int resultado = conversor.TransformarDataEmDiasDecorridos(data);
            int resultado1 = conversor.TransformarDataEmAnosDecorridos(data);
            int resultado2 = conversor.TransformarDataEmMesesDecorridos(data);
            int resultado3 = conversor.TransformarDataEmDiasDecorridos(data);

            Console.WriteLine(data.totalSegundos);
            Console.WriteLine(data.horasDecorridas);
            Console.WriteLine(resultado3);
            Console.WriteLine(data.resultado.ToUpper());

            Console.ReadLine();
        }
    }
}
