using EscolaExemplo.Enumeradores;
namespace EscolaExemplo.Entidades
{
    public class Tesoura : MaterialEscolar
    {
        public double PrecoMaterial { get; set; }
        public bool temPonta { get; set; }
        public double comprimento { get; set; }
        public TesouraEnum TipoTesoura { get; set; }

        public Tesoura(TesouraEnum tesouraEscolhida)
        {
            TipoTesoura = tesouraEscolhida;
            preco = CalcularPrecoPapel(tesouraEscolhida);
        }

        public double CalcularPrecoPapel(TesouraEnum tesouraEscolhida)
        {
            if (tesouraEscolhida == TesouraEnum.ComPonta)
            {

                PrecoMaterial = 5;
            }
            else if (tesouraEscolhida == TesouraEnum.SemPonta)
            {
                PrecoMaterial = 3;
            }


            return preco;

        }
    }
}
