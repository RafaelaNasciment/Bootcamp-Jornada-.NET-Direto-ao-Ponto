using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcampDiretoAoPonto
{
    internal class Menu
    {
        private readonly Pacote _pacote;
        public Menu()
        {
            _pacote = new Pacote();
        }
        public void MenuOpcao()
        {
            var cont = 0;
            while (cont == 0) { 
            switch (exibirMensagem())
            {
                case "1":
                    _pacote.CadastrarPacote();
                    break;
                case "2":
                    _pacote.AtualizarPacoteStatus();
                    break;
                case "3":
                        _pacote.ConsultarPacote();
                    break;
                case "0":
                    Console.Write("Saindo....");
                    cont = 1;
                    return;
                default:
                    Console.WriteLine("Opção inexistente!");
                    break;
                }
                Console.WriteLine("Enter para retornar ao menu | 0 para sair");
                Console.ReadLine();
            }
        }
        static string exibirMensagem()
        {
            Console.WriteLine("Escolha a opção desejada: ");
            Console.WriteLine("1 - Cadastro de pacote");
            Console.WriteLine("2 - Atualizar pacote");
            Console.WriteLine("3 - Consultar pacote");
            Console.WriteLine("0 - Sair do programa! ");
            var opcao = Console.ReadLine();
            return opcao;
        }
    }
}
