using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTransferenciaBancaria//.Classes
{
    class Conta
    {
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private double Saldo { get; set; }
        private TipoConta TipoConta { get; set; }
        private int Agencia { get; set; }
        private string NumeroConta { get; set; }

        public Conta(string nome, string cpf, double saldo,
            TipoConta tipoConta, string numeroConta)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Agencia = 0001;
            this.NumeroConta = numeroConta;
            this.Saldo = saldo;
            this.TipoConta = tipoConta;
        }

        public bool Sacar(double valorSaque)
        {
            if (this.Saldo < valorSaque)
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            else
            {
                this.Saldo -= valorSaque;
                Console.WriteLine($"Saldo atual da conta de " +
                    $"{this.Nome} é {this.Saldo}");
                return true;
            }
        }

        public void Depositar(double deposito)
        {
            this.Saldo += deposito;
            Console.WriteLine($"Saldo atual da conta de {this.Nome} é " +
                $"{this.Saldo}");
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "------------------------------------------\n";
            retorno += " | " + "TipoConta: " + this.TipoConta + "|\n";
            retorno += " | " + "Nome: " + this.Nome + "|\n";
            retorno += " | " + "Saldo: " + this.Saldo + "|\n";
            retorno += " | " + "Agencia: " + this.Agencia + " |\n";
            retorno += " | " + "Conta: " + this.NumeroConta + "|\n";
            retorno += "------------------------------------------\n";
            return retorno;
        }
    }
}
