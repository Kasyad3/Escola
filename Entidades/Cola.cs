using EscolaExemplo.Enumeradores;
namespace EscolaExemplo.Entidades
{
    public class Cola : MaterialEscolar
    {

        public double PrecoMaterial { get; set; }
        public string Viscosidade { get; set; }
        public double Peso { get; set; }
        public ColasEnum TipoCola { get; set; }

        public Cola(ColasEnum colaEscolhida)
        {
            TipoCola = colaEscolhida;
            preco = CalcularPrecoCola(colaEscolhida);
        }

        public double CalcularPrecoCola(ColasEnum colaEscolhida)
        {
            if (colaEscolhida == ColasEnum.Bastao)
            {

                PrecoMaterial = 5;
            }
            else if (colaEscolhida == ColasEnum.Branca)
            {
                PrecoMaterial = 3;
            }

            else if (colaEscolhida == ColasEnum.Quente)
            {
                PrecoMaterial = 7;
            }



            return preco;
        }
    }
}
