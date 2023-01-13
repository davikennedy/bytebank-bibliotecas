using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;
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

            /*ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(546, 142341);
            lista.Adicionar(contaDoGui);

            //lista.Adicionar(new ContaCorrente(874, 1234));

            ContaCorrente[] contas = 
            {
                contaDoGui,
                new ContaCorrente(874, 1234),
                new ContaCorrente(874, 1234)
            };

            lista.AdicionarVariasContas(contas);

            //lista.Remover(contaDoGui);

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = {itemAtual}");
            }
            //lista.Imprimir();

            Console.ReadLine();*/

            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(832, 1),       
                new ContaCorrente(633, 99),
                new ContaCorrente(272, 3),
                new ContaCorrente(351, 2)
            };

            //contas.Sort(); ~~> Chama a implementação dada em IComparable
            //contas.Sort(new ComparadorContaCorrentePorAgencia()); ~~> Chama a implementação dada com IComparer
            IOrderedEnumerable<ContaCorrente> contasOrdenadas = contas.OrderBy(conta => conta.Numero);

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta.Numero}, Agência {conta.Agencia}");
            }

            Console.ReadKey();
        }

        static void TestaSort()
        {
            var nomes = new List<string>()
            {
                "Wellington",
                "Guilherme",
                "Luana",
                "Marcos",
                "Rogério",
                "Ana"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            var idades = new List<int>();

            idades.Add(51);
            idades.Add(23);
            idades.Add(72);
            idades.AdicionarVariosItens(99, -1, 15, 4);

            idades.Sort();

            foreach (var idade in idades)
            {
                Console.WriteLine(idade);
            }

            Console.ReadLine();
        }
        
        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.Adicionar(3);
            listaDeIdades.AdicionarVariosItens(10);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no índice {i}: {idade}");
            }

            Console.ReadKey();
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
