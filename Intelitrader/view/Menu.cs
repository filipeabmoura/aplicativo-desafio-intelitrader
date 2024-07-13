using Intelitrader.application;

namespace Intelitrader.view
{
    public class Menu
    {
        private CriptografiaNaRedeDoNavio apl1 = new CriptografiaNaRedeDoNavio();

        public void exibir()
        {
            Console.Write("Digite o número da opção desejada\n1) Problema 1\n2) Problema 2\n0) Sair\n>>");
            string? op = Console.ReadLine();

            switch (op)
            {
                case "0":
                    Console.WriteLine("\n\n\n\n\n\nObrigado por me avaliar!\nAguardo o convite :)\n\n\n");
                    break;

                case "1":
                    apl1.decifrar();
                    this.exibir();
                    break;

                case "2":
                    Console.WriteLine("entrar na solução do desafio 2");
                    this.exibir();
                    break;

                default:
                    Console.WriteLine("Opção Inválida. Tente Novamente");
                    this.exibir();
                    break;

            }
        }
    }
}
