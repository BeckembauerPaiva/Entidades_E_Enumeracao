using System;

namespace Entidades_E_Enumeracao.Entities
{
    internal class Cacambas
    {
        public int NumeroDaCacamba { get; set; }
        public DateTime DataDeColocacao { get; set; }
        public DateTime DataDeRetirada { get; set; }

        public Cacambas() { }

        public Cacambas(int numeroDaCacamba, DateTime dataDeColocacao, DateTime dataDeRetirada)
        {
            NumeroDaCacamba = numeroDaCacamba;
            DataDeColocacao = dataDeColocacao;
            DataDeRetirada = dataDeRetirada;
        }
    }
}
