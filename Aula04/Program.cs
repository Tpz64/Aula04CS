using System;

//declaração de escopo
namespace MyApp
{
    //declaração de classe
    internal class Program
    {
        //ATIVIDADE Crie um programa que peça um nome e um tamanho de circulo, e devolva “fulano, a área do circulo é: ####”

        //criar uma nova função antes do void Main -> boa prática
        static void Print(string message) //nome da função com letra maiuscula
        {
            Console.WriteLine(message);//referencia da variavel que entrou
        }

        static Double CalcularAreaCirculo (Double area)
        {
            Double saida = 0;

            saida = Math.PI * Math.Pow(area, 2);
            // buscar o valor de PI através da função Math
            //Pow é potencia, multiplica área vezes área

            return saida;
        }


        //o próprio Main já é uma função
        //o primeiro passo é o acesso (o static) e não é obrigatório
        //função chamada pela própria engine 
        //função sempre dentro de uma classe 
        static void Main(string[] args)
        {
            string nome;
            Double valor = 0;

            Print("Olá, qual o seu nome?");
            nome = Console.ReadLine();
            Print("Olá " +  nome + ", digite o valor do raio de um circulo");
            valor = Double.Parse(Console.ReadLine());
            Double area = CalcularAreaCirculo(valor);
            Print(nome + " o valor de área do circulo de raio " + valor + " é: " + area );

            Print(area.ToString());//converte o valor de area para string 
        }
    }
}