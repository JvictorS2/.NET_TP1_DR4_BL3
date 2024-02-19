using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_.Net
{
    public class Pessoa
    {
        private string nome;
        private int idade;
        private string cpf;

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Cpf { get => cpf; set => cpf = value; }

        public override string ToString()
        {
            return $"Nome: {nome} / Idade: {idade} / Cpf? {cpf}";
        }

    }
}
