using System;
using System.Collections.Generic;
using System.Linq;

namespace bootcampDiretoAoPonto
{
    public class Pacote
    {
        public Pacote()
        {
        }
        public Pacote(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;

            Codigo = GerarCodigo();
            DataPostagem = DateTime.Now;
            Status = "Postado";
        }

        public List<Pacote> pacotes = new List<Pacote>();
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }
        public DateTime DataPostagem { get; set; }
        public string Status { get; set; }

        private string GerarCodigo()
        {
            return Guid.NewGuid().ToString();
        }

        public void AtualizarStatus(string status)
        {
            Status = status;
        }

        public virtual void DetalhesProduto()
        {
            Console.WriteLine($"" +
                $"Titulo: {Titulo}\nCódigo: " +
                $"{Codigo}\nDescrição: " +
                $"{Descricao}\nStatus: " +
                $"{Status}" +
                $"\nData de criação{DataPostagem}");
        }
        public void CadastrarPacote()
        {
            Console.WriteLine("Informe os dados do pacote: ");
            Console.WriteLine("Titulo: ");
            var titulo = Console.ReadLine();

            Console.WriteLine("Descrição: ");
            var descricao = Console.ReadLine();
            
            var pacote = new Pacote(titulo, descricao);
            pacotes.Add(pacote); //Adicionando o novo pacote criado a lista

            Console.WriteLine($"Pacote criado com sucesso! Código de criação: {pacote.Codigo}");
        }
        public void AtualizarPacoteStatus()
        {
            Console.WriteLine("Informe o código do pacote que deseja atualizar: ");
            var codigo = Console.ReadLine();
            var pacote = pacotes.SingleOrDefault(p => p.Codigo == codigo);

            if(pacote == null)
            {
                Console.WriteLine("Código inválido!");
                return;
            }
            Console.WriteLine("Informe o status atual: ");
            var statusAtual = Console.ReadLine();
            pacote.AtualizarStatus(statusAtual);
        }
        public void ConsultarPacote()
        {
            Console.WriteLine("Código do produto que deseja consultar: ");
            var codigo = Console.ReadLine().Trim();
            var pacote = pacotes.SingleOrDefault(p => p.Codigo == codigo);

            if(pacote == null)
            {
                Console.WriteLine("Codigo inválido!");
            }
            pacote.DetalhesProduto();
        }
    }
}
