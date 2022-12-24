using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*DateTime dataFimPagamento = new DateTime(2023, 01, 28);
            DateTime dataAtual = DateTime.Now;

            TimeSpan tempoRestantePagamento = dataFimPagamento - dataAtual;

            string mensagem = $"Vencimento em {TimeSpanHumanizeExtensions.Humanize(tempoRestantePagamento)}";

            Console.WriteLine(mensagem);
            Console.WriteLine(dataFimPagamento);*/

            string url = "pagina?argumentos";
            int posicaoInicial = url.IndexOf('?');
            string arg = url.Substring(++posicaoInicial);

            Console.WriteLine(arg);
            Console.ReadLine();
        }
    }
}
