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

            /*Object conta = new ContaCorrente(555, 24);
            Console.WriteLine(conta);
            Console.ReadLine();

            string urlParametros = "https://wwww.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);
            
            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine($"Valor de moeda origem: {valorMoedaOrigem}");

            string valorMoedaDestino = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine($"Valor de moeda destino: {valorMoedaDestino}");

            Console.WriteLine(extratorDeValores.GetValor("Valor"));*/

            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(546, 142341);
            lista.Adicionar(contaDoGui);

            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1234));
            lista.Adicionar(new ContaCorrente(874, 1234));

            lista.Remover(contaDoGui);

            lista.Imprimir();

            Console.ReadLine();
        }
        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas =
            {
                new ContaCorrente(25, 455),
                new ContaCorrente(25, 456),
                new ContaCorrente(25, 457)
            };

            foreach (ContaCorrente conta in contas)
            {
                Console.WriteLine(conta);
            }
        }
    }
}
