﻿//using _05_ByteBank

namespace _07_ByteBank
{
    public class ContaCorrente
    {

        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        public ContaCorrente(int agencia, int numeroConta)
        {
            Agencia = agencia;
            NumeroConta = numeroConta;

            TotalDeContasCriadas++;
        }


        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <=0)
                {
                    return;
                }
                _agencia = value;
            }
        }
        public int NumeroConta { get; set; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }



        public bool Sacar(double valor)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }

}











