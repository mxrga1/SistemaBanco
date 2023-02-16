using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco
{
    public class Cliente
    {
        //public List<Transacao> Extrato { get; set; }
        public double Saldo { get; set; }
        public int NumeroConta { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }


        public string ResumoCliente(){

            return $"{NumeroConta} | {Nome} | {CPF} ";


        }
    }
}