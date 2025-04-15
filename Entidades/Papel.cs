using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscolaExemplo.Enumeradores;
namespace EscolaExemplo.Entidades
{
    public class Papel : MaterialEscolar
    {
        public double precoMaterial { get; } = 10;
        public double tamanho { get; set; }
        public double expessura { get; set; }
        public string textura { get; set; }
        public ColasEnum Anotar { get; set; }
    }
}
