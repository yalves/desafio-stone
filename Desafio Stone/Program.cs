using System;
using static System.Console;
using static Desafio_Stone.Util;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Stone
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Quantas preposições existem no texto?");
            int quantidadeDePreposicoesNoTexto = DescobrirQuantidadeDePreposicoesNoTexto(TEXTO_NO_IDIOMA_PREDATOR);
            WriteLine($"Resposta: Existem {quantidadeDePreposicoesNoTexto} preposições no texto\n");

            int quantidadeDeVerbosEmPrimeiraPessoa;
            int quantidadeDeVerbosNoTexto = DescobrirQuantidadeDeVerbosNoTexto(TEXTO_NO_IDIOMA_PREDATOR, out quantidadeDeVerbosEmPrimeiraPessoa);
            WriteLine("Quantos verbos existem no texto?");
            WriteLine($"Resposta: Há {quantidadeDeVerbosNoTexto} verbos no texto\n");
            WriteLine("E quantos verbos do texto estão em primeira pessoa?");
            WriteLine($"Resposta: Há {quantidadeDeVerbosEmPrimeiraPessoa} verbos em primeira pessoa no texto\n");

            WriteLine("Como seria a lista de vocabulário para o texto?");
            WriteLine("Resposta: \n");
            var vocabulario = CriarVocabularioPedrator(TEXTO_NO_IDIOMA_PREDATOR);
            foreach (var palavra in vocabulario)
                Write($"{palavra} ");
            WriteLine("");
            WriteLine("");

            int quantidadeDeNumerosLindosDistintosNoTexto;
            int quantidadeDeNumerosBonitosDistintosNoTexto = DescobrirQuantidadeDeNumerosBonitosDistintosNoTexto(TEXTO_NO_IDIOMA_PREDATOR, out quantidadeDeNumerosLindosDistintosNoTexto);

            WriteLine("E no texto, quantos números bonitos distintos existem?");
            WriteLine($"Resposta: No texto, há {quantidadeDeNumerosBonitosDistintosNoTexto} números bonitos distintos.\n");

            WriteLine("E no texto, quantos números lindos distintos existem?");
            WriteLine($"Resposta: No texto, há {quantidadeDeNumerosLindosDistintosNoTexto} números lindos distintos.");

            ReadKey();
        }
    }
}
