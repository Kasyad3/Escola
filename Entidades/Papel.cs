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
        public double PrecoMaterial { get; set; }
        public double tamanho { get; set; }
        public double expessura { get; set; }
        public string textura { get; set; }
        public PapelEnum TipoPapel { get; set; }


        public Papel(PapelEnum papelEscolhido)
        {
            TipoPapel = papelEscolhido;
            preco = CalcularPrecoPapel(papelEscolhido);
        }

        public double CalcularPrecoPapel(PapelEnum papelEscolhido)
        {
            if (papelEscolhido == PapelEnum.Sufite)
            {

                PrecoMaterial = 5;
            }
            else if (papelEscolhido == PapelEnum.Crepom)
            {
                PrecoMaterial = 3;
            }
            
            else if (papelEscolhido == PapelEnum.Cartolina)
            {
                PrecoMaterial = 7;
            }

            



            return preco;

        }
    }
}
    

