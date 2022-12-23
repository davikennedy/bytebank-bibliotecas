using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2023, 01, 28);
            DateTime dataAtual = DateTime.Now;

            TimeSpan tempoRestantePagamento = dataFimPagamento - dataAtual;

            string mensagem = $"Vencimento em {GetIntervaloDeTempo(tempoRestantePagamento)}";

            Console.WriteLine(mensagem);
            Console.WriteLine(dataFimPagamento);

            Console.ReadLine();
        }

        static string GetIntervaloDeTempo(TimeSpan timeSpan)
        {
            if (timeSpan.Days> 30)
            {
                int quantidadeMeses = timeSpan.Days / 30;

                if (quantidadeMeses == 1)
                {
                    return "1 mês";
                }
                return $"{quantidadeMeses} meses";
            }
            else if (timeSpan.Days> 7)
            {
                int quantidadeSemanas = timeSpan.Days / 7;

                if (quantidadeSemanas == 1)
                {
                    return "1 semana";
                }
                return $"{quantidadeSemanas} semanas";
            }
            else
            {
                return $"{timeSpan.Days} dias";
            }
                
        }
    }
}
