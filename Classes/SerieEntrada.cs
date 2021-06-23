using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Series.Classes
{
    public class SerieEntrada
    {
        public int EntradaGenero { get; set; }
        public string EntradaTitulo { get; set; }
        public int EntradaAno { get; set; }
        public string EntradaDescricao { get; set; }


        public SerieEntrada CriarEntrada()
        {
            var entrada = new SerieEntrada();

            Console.Write("Digite o gênero entre as opções acima: ");
            entrada.EntradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o Título da Série: ");
            entrada.EntradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Início da Série: ");
            entrada.EntradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descrição da Série: ");
            entrada.EntradaDescricao = Console.ReadLine();

            return entrada;
        }
	}
}
