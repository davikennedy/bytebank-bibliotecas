﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            //Esse tipo de comparação é equivalente ao que já existe no tipo 'int'
            // return x.Agencia.CompareTo(y.Agencia)
            if (x == y)
            {
                return 0;
            }

            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }

            if (x.Agencia < y.Agencia)
            {
                return -1;
            }
            
            if (x.Agencia == y.Agencia)
            {
                return 0;
            }

            return 1;
        }
    }
}
