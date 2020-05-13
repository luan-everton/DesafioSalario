using ReajusteSalario;
using System;

namespace Desafio_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            String dados = "";
            Console.WriteLine("####  Bonus Salarial ### ");
            funcionario fx;
            fx = new Vendedor();
            Console.WriteLine("Qual é o seu cargo || 1 Gerente || 2 Operador  || 3 Vendedor : ");
            dados = Console.ReadLine();
                switch (int.Parse(dados))
                {
                    case 1:
                        fx = new Gerente();
                        break;
                    case 2:
                        fx = new Operador();
                        break;
                    case 3:
                        fx = new Vendedor();
                        break;
                    default:
                        
                        break;
                }

            Console.WriteLine("Digite seu nome : ");
            dados = Console.ReadLine();
            fx.nome = dados;
            Console.WriteLine("Digite Seu Cpf : ");
            dados = Console.ReadLine();
            fx.cpf = dados;
            Console.WriteLine("Digite sua Data de nascimento no seguinte formato: dd/MM/yyyy");
            dados = Console.ReadLine();
            fx.nascimento = new DateTime(int.Parse(dados.Substring(6, 4)), int.Parse(dados.Substring(3, 2)), int.Parse(dados.Substring(0, 2)));
            Console.WriteLine("Digite seu sexo : ");
            dados = Console.ReadLine();
            fx.sexo = dados;
            Console.WriteLine("Qual é o valor do seu salario : ");
            dados = Console.ReadLine();
            fx.salario = Convert.ToInt32(dados);
           
            Console.WriteLine("#### O funcionario com os dados ###");
            Console.WriteLine("nome :  " + fx.nome);
            Console.WriteLine("CPF :  " + fx.cpf);
            Console.WriteLine("Nascimeto :  " + fx.nascimento.Date);
            Console.WriteLine("Idade :  " + (DateTime.Now.Year - fx.nascimento.Year));
            Console.WriteLine("sexo :  " + fx.sexo);
            Console.WriteLine("Salário :  " + fx.salario);
            Console.WriteLine("Com o bonus salarial , novo salario : R$ " + (fx.salario + fx.Bonus()));
            Console.ReadKey();
        }
    }
}
