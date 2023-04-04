using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();

            
            contaDoBruno.titular = "Bruno";
            Console.WriteLine("Seu saldo é de "+contaDoBruno.saldo);
            bool resultadoSaque = contaDoBruno.Sacar(50);
            Console.WriteLine("sobrou após o saque "+contaDoBruno.saldo);
            Console.WriteLine(resultadoSaque);

            contaDoBruno.Depositar(500);
            Console.WriteLine("seu novo saldo após deposito é de "+contaDoBruno.saldo);


            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Saldo do Bruno " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela " + contaDaGabriela.saldo);

            bool resultadoTransferencia = contaDoBruno.Transferir(200,contaDaGabriela);

            Console.WriteLine("Saldo do Bruno " + contaDoBruno.saldo);
            Console.WriteLine("Saldo da Gabriela " + contaDaGabriela.saldo);
            Console.WriteLine("Resultado transferencia: "+resultadoTransferencia);

            Console.ReadLine();
        }
    }
}
