using EscolaExemplo.Enumeradores;
namespace EscolaExemplo.Entidades
{
    public class Cola : MaterialEscolar
    {

        public double PrecoMaterial { get; } = 5;
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

                preco = 5;
            }
            else if (colaEscolhida == ColasEnum.Branca)
            {
                preco = 3;
            }

            else preco = 7;



            return preco;
        }
    }
}
