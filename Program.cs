using System;
using System.Collections;
using System.Collections.Generic;

namespace Prova___exercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("João", 15);
            Pessoa p2 = new Pessoa("Leandro", 21);
            Pessoa p3 = new Pessoa("Paulo", 17);
            Pessoa p4 = new Pessoa("Jessica", 18);


            List<Pessoa> Pessoas = new List<Pessoa>();

            Pessoas.Add(p1);

            Pessoas.Add(p2);

            Pessoas.Add(p3);

            Pessoas.Add(p4);



            int aux = 0;
            string saux = "";

            for (int i = 0; i < Pessoas.Count; i++)
            {
                if (Pessoas[i].idade > aux)
                {
                    aux = Pessoas[i].idade;
                    saux = Pessoas[i].nome;
                }
            }
                Console.WriteLine("A pessoa mais velha é: " + saux + " que tem " + aux + " anos.");


                Console.WriteLine("\nLista atual: ");


            foreach (Pessoa element in Pessoas)
            {
                Console.WriteLine("Nome: " + element.nome + " idade: " + element.idade);
            }


            for (int i = 0; i < Pessoas.Count; i++)
            {
                if (Pessoas[i].idade < 18)
                {
                    Pessoas.RemoveAt(i);
                }
            }
                Console.WriteLine("\nLista de pessoas apos remoção:");


            foreach (Pessoa element in Pessoas)
            {

                Console.WriteLine("Nome: " + element.nome + "idade: " + element.idade);
            }


            foreach (Pessoa element in Pessoas)
            {
                if (element.nome == "Jessica")
                {
                    Console.WriteLine("\nO nome Jessica está na lista.");
                }
            }

        }
    }
}
