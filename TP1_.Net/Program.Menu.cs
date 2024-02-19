using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_.Net;

partial class Program
{
    static void ShowMenuOptions()
    {
        WriteLine();
        WriteLine("***** Bem-vindo ****");
        WriteLine("1 - adicionar uma pessoa");
        WriteLine("2 - listar pessoa");
        WriteLine();
        WriteLine("Escolha uma das opções");
    }

    static void ListarPessoas(List<Pessoa> p)
    {
        WriteLine();
        WriteLine($"Número de pessoas listadas: {p.Count}");
        foreach(Pessoa pessoa in p)
        {
            WriteLine(pessoa.ToString());
        }
    }

    //Criar classe Pessoa
    static Pessoa CriarPessoa()
    {
        Pessoa p = new Pessoa();

        try
        {
            Write("Informe o nome: ");
            p.Nome = ReadLine();

            Write("Informe a idade: ");
            p.Idade = Convert.ToInt32(ReadLine());

            Write("Informe o cpf: ");
            p.Cpf = ReadLine();
        }
        catch (FormatException)
        {
            WriteLine("Atenção: Informe apenas números no campo idade");
            WriteLine();
        }
        catch
        {
            WriteLine("Algo deu errado, tente novamente.");
            WriteLine();
        }

        return p;
    }

    static void Menu()
    {
        List<Pessoa> ListaPessoa = new List<Pessoa>();

        int opt = -1;
        do
        {
            ShowMenuOptions();

            try
            {
                opt = Convert.ToInt32(ReadLine());
            }
            catch (FormatException)
            {
                WriteLine("Atenção: Informe apenas números");
                WriteLine();
            }
            catch
            {
                WriteLine("Algo deu errado, tente novamente.");
                WriteLine();
            }

            switch (opt)
            {
                case 1:
                    ListaPessoa.Add(CriarPessoa());
                    break;
                case 2:
                    ListarPessoas(ListaPessoa);
                    break;
                case 0:
                    WriteLine("Volte sempre!");
                    break;
                default:
                    break;
            }
        }
        while (!(opt == 0));

    }
}