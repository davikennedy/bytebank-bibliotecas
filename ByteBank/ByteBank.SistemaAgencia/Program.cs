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
            Console.WriteLine("Teste");
            ContaCorrente conta1 = new ContaCorrente(45, 122);
            Console.WriteLine(conta1.Agencia);
            Console.WriteLine(conta1.Numero);

            Console.ReadLine();
        }
    }
}
