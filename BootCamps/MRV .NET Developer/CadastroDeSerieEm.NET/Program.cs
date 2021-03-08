﻿using System;

namespace CadastroDeSerieEm.NET
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {

            string opcaoMenu = ObterOpcaoMenu(); 
            
                while(opcaoMenu.ToUpper() !="X"){
                    if(opcaoMenu == "1"){
                        
                    ObterOpcaoUsuario();
                     
                while (opcaoMenu.ToUpper() != "X"){
                switch (opcaoMenu){
                    case "1":
                        ListarSeries();
                        break;
                    
                    case "2":
                        InserirSerie();
                        break;

                    case "3":
                        AtualizarSerie();
                        break;
                    
                    case "4":
                        ExcluirSerie();
                        break;
                    
                    case "5":
                        VisualizarSerie();
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Digite uma opção válida!");
                        opcaoMenu = ObterOpcaoUsuario();
                        break;
                }
               
               opcaoMenu = ObterOpcaoUsuario();
            }
                }
                    else if(opcaoMenu == "2"){
                      Console.WriteLine("Menu Filme");
                }
            opcaoMenu = ObterOpcaoMenu(); 
                    
            }

            Console.WriteLine("Obrigado por utilizar nosso serviço!");
            Console.WriteLine();

        }

        private static void ListarSeries(){
            Console.WriteLine("Listar séries");

            var lista = repositorio.Lista();

            if(lista.Count == 0){
                Console.WriteLine("Nenhuma série cadastrada!");
                return;
            }

            foreach (var serie in lista){
                var excluido = serie.retornaExcluido();

                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "***Excluido***" : ""));
            }
        }

        private static void InserirSerie(){
            Console.WriteLine("Inserir nova série");

            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Tétulo da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Insere(novaSerie);
        }

        private static void AtualizarSerie(){
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero))){
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);
        }

        private static void ExcluirSerie(){
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            Console.Write("Deseja exluir a série ? ");
            Console.Write("Digite true para sim ou false para não: ");
            bool confirmaExclusao = bool.Parse(Console.ReadLine());

            if(confirmaExclusao == true){
                 repositorio.Exclui(indiceSerie);
                 Console.Write("Série excluida com sucesso...");
            }
        
        }

        private static void VisualizarSerie(){
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);
        }

        private static string ObterOpcaoUsuario(){

            Console.WriteLine();
            Console.WriteLine("*********************");
            Console.WriteLine("* CADASTRO DE SÉRIE *");
            Console.WriteLine("*********************");
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Voltar para o menu");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        
        private static string ObterOpcaoMenu(){
            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine("* MENU PRINCIPAL *");
            Console.WriteLine("******************");
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Séries");
            Console.WriteLine("2 - Filme");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoMenu = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoMenu;
        }
    }

}    
