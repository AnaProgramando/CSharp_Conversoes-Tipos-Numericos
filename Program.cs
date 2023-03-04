using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ConversoesETiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_______Executando o projeto - Conversões e Tipos Numéricos_______ \r\n \r\n");

            // convertendo o double em inteiro

            Console.WriteLine("Conversão de double para inteiro:");
            double salario;
            salario = 1200.50;

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine("O salário de R$ 1200.50 convertido para inteiro perde a precisão e fica igual a " + salarioEmInteiro + ". \r\n \r\n");

            Console.WriteLine("-------------------------- \r\n");

            // capacidade da int

            Console.WriteLine("Capacidade da int: \r\n");

            Console.WriteLine("O int ocupa 32 bits na memória do computador, ou seja, existe um limite de número armazenado. Esse limite é um pouco mais do que 2 bilhões, por isso a declaração da variável abaixo não compila: \r\n");
            Console.WriteLine("int idadeUniverso");
            Console.WriteLine("idadeUniverso = 13000000000");
            Console.WriteLine("Erro! \r\n \r\n");

            Console.WriteLine("-------------------------- \r\n");


            // variável Long

            Console.WriteLine("Long: \r\n");

            long idadeUniverso;
            idadeUniverso = 130000000000;

            Console.WriteLine("O long trabalha com números inteiros e suporta valores maiores por ter um limite de 64 bits, o dobro do limite do int:");
            Console.WriteLine("long idadeUniverso");
            Console.WriteLine("idadeUniverso = 130000000000");
            Console.WriteLine("A idade do universo é " + idadeUniverso + ". \r\n \r\n");


            Console.WriteLine("-------------------------- \r\n");

            // variável short

            Console.WriteLine("Short: \r\n");
            Console.WriteLine("Quando sabemos que a variável dificilmente alcançará um valor de 2 bilhões, é desnecessário usar o int, por isso podemos usar apenas short, que vai suportar uma quantidade de valor muito menor. A variável do tipo short é de 16 bits, ou seja, o valor NÃO pode ser MAIOR do que 16 mil. \r\n");

            short quantidadeProdutos;
            quantidadeProdutos = 150;

            Console.WriteLine("short quantidadeProdutos");
            Console.WriteLine("quantidadeProdutos = 150");
            Console.WriteLine("A quantidade de produtos é igual a " + quantidadeProdutos + ". \r\n \r\n");


            Console.WriteLine("-------------------------- \r\n");


            // variável float

            Console.WriteLine("Float: \r\n");
            Console.WriteLine("O float serve para casas decimais, mas ele tem uma precisão curta de números suportados para casas decimais após a vírgula. \r\n");

            float altura;
            altura = 1.80f;

            Console.WriteLine("A altura é de " + altura + ".");
            Console.WriteLine("A linguagem C# costuma interpretar um número com ponto flutuante como um double - o que significa que estamos tentando colocar este valor dentro de um float. Para sermos bem sucedidos nesta tarefa, temos que adicionar um sufixo f, justamente por ser incomum o uso do float. \r\n");



            Console.ReadLine();
        }
    }
}
