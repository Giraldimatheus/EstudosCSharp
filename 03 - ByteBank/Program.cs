using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03___ByteBank
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numeroconta = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numeroconta = 863452;

            // é possível comparar igualdades de valo igual, mas no caso da refencia de uma classe instanciada não é possível
            //porque cada "new ContaCorrente" ou seja, a instancia do onjeto criado ocupa um lugar da memória e a outra diferente, mesmo as informa
            // sendo as mesas.

            Console.WriteLine("igualdade de tipo de referencia " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idademaismavez = 27;

            Console.WriteLine("Igualdade de tipo de valor " + (idade == idademaismavez));

            Console.WriteLine (contaDaGabriela = contaDaGabrielaCosta);

            contaDaGabriela.saldo = 300;

            Console.WriteLine("seu saldo é de: "+contaDaGabriela.saldo);

            if(contaDaGabriela.saldo >= 100)
            {
                contaDaGabriela.saldo -= 100;
            }

            Console.ReadLine();


        }
    }
}
