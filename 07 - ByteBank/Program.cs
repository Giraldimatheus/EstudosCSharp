﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(876, 867123456);

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.NumeroConta);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86774820);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
            
        }
    }
}
