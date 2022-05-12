using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootcampDiretoAoPonto
{
    public class PacotePremium : Pacote
    {
        public PacotePremium(string titulo, string descricao, string voo)
            : base(titulo, descricao)
        {
            Voo = voo;
        }

        public string Voo { get; set; }
        public override void DetalhesProduto()
        {
            base.DetalhesProduto();
            Console.WriteLine($"Voo: {Voo}");
        }
    }
}
