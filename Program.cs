using System;

namespace Alcantara.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        //InserirSeries();
                        break;
                    case "3":
                        //AtualizarSeries();
                        break;
                    case "4":
                       // ExcluirSeries();
                        break;
                    case "5":
                      //  VisualizarSeries();
                        break;
                    case "C":
                        Console.Clear();
                        break;    
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar esse programa!");
            Console.ReadLine();
            
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Alcantara Series está aqui !!!");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1- Listar Séries");
            Console.WriteLine("2- Inserir nova Série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
