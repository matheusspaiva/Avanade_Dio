using System;
using System.Collections.Generic;

namespace Series
{
    class Program
    {


        static void Main(string[] args)
        {
            Catalogo cat = new Catalogo();
            int escolha;
            do{
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("1 Adicionar serie");
            Console.WriteLine("2 Ver lista de series");
            Console.WriteLine("3 Alterar serie");
            Console.WriteLine("4 Excluir serie");
            Console.WriteLine("5 Limpar Tela");
            Console.WriteLine("6 sair");
            Console.WriteLine("");
             escolha = Convert.ToInt32(Console.ReadLine());
            
            switch(escolha){
                case 1:
                    AdicionarSerie(cat);
                    break;
                case 2:
                    VerSerie(cat);
                    break;
                case 3:
                    Alterar(cat);
                break;
                case 4:
                    Apagar(cat);
                    break;
                case 5:
                    Console.Clear();
                break;
            }
            }while(escolha !=6);
        }

        public static void AdicionarSerie(Catalogo cat){
            Console.WriteLine("Qual ID do Serie?");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o nome da Serie?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o Genero da serie?");
            string genero = Console.ReadLine();
            
            Console.WriteLine("Qual o Ano do filme?");
            int ano = Convert.ToInt32(Console.ReadLine());

            Serie serie =new Serie(id, nome, genero, ano);
            //Catalogo cat = new Catalogo();
            cat.Adicionar(serie);
        }
        
        public static void VerSerie(Catalogo cat){
          //  Catalogo cat = new Catalogo();
            List<Serie> s = new List<Serie>();
            s = cat.VerLista();
            foreach (var a in s)
            {
                if(!a.RetornaExcluido()){
                    Console.WriteLine();
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"Id: {a.RetornaId()}");
                    Console.WriteLine($"Nome: {a.RetornaNome()}");
                    Console.WriteLine($"Nome: {a.RetornaGenero()}");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine();
                }
            }
        }
        public static void Alterar(Catalogo cat){
            Console.WriteLine("Qual ID do Serie?");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o nome da Serie?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o Genero da serie?");
            string genero = Console.ReadLine();
            
            Console.WriteLine("Qual o Ano do filme?");
            int ano = Convert.ToInt32(Console.ReadLine());

            Serie serie =new Serie(id, nome, genero, ano);
            
            cat.Alterar(serie);
        }

        public static void Apagar(Catalogo cat){
            Console.WriteLine("Qual id do filme para Excluir? ");
            int id = Convert.ToInt32(Console.ReadLine());
                cat.Excluir(id);
        }
        
    }
}
