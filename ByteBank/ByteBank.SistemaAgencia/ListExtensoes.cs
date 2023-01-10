using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensoes
    {
        public static void AdicionarVariosItens(this List<int> listDeInteiros, params int[] itens)
        {
            foreach(int item in itens)
            {
                listDeInteiros.Add(item);
            }
        }
    }
}
