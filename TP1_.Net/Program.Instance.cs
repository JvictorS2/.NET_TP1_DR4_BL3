using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_.Net;

partial class Program
{
    static void instancePessoa()
    {
        //Instância pessoa
        Pessoa pessoa = new Pessoa();
        pessoa.Nome = "Joao";
        pessoa.Idade = 20;
        pessoa.Cpf = "111.222.333-70";

        WriteLine(pessoa.ToString());

    }
}
