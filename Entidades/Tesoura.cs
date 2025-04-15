using EscolaExemplo.Enumeradores;
namespace EscolaExemplo.Entidades
{
    public class Tesoura : MaterialEscolar
    {
        public double precoMaterial { get; }  = 7;
        public bool temPonta { get; set; }
        public double comprimento { get; set; }
        public ColasEnum Cortar { get; set; }
    }
}
