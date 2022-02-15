using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("INICIO DO JOGO\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!

            var campoMinadoTwo = new CampoMinado();
            String Filtro;
            // contagem da matriz para abrir cada posição
            int cont = 0;
            for (int i = 1; i <= 9; i++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    campoMinadoTwo.Abrir(i, y);
                }
            }
            // atribuição da string Tabuleira e fazendo seu retorno a string filtro
            Filtro = campoMinadoTwo.Tabuleiro.Replace("\r", "").Replace("\n", "");

            // contagem da Matriz e uma condição para identificar as posições que for diferente de "*"
            // e abri cada posição
            for (int i = 1; i <= 9; i++)
            {
                for (int y = 1; y <= 9; y++)
                {
                    if (!Filtro[cont].ToString().Contains('*'))
                    {
                        campoMinado.Abrir(i, y);
                    }
                    cont++;
                }
            }
            Console.WriteLine("\nRESULTADO\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);
            Console.WriteLine("=========");
            Console.WriteLine("PARABÉNS!!! VOCÊ ABRIU TODAS AS POSIÇÕES QUE NAO POSSUEM MINAS TERRESTRES! ");
            Console.WriteLine("VOCÊ VENCEU!!");
            Console.WriteLine("\nSTATUS DO JOGO: " + campoMinado.JogoStatus);
        }
    }
}
