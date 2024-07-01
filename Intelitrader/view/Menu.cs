namespace Intelitrader.view
{
    public class Menu
    {
        public void exibir()
        {
            Console.Write("Digite o número da opção desejada\n1) Problema 1\n2) Problema 2\n0) Sair\n>>");
            string op = Console.ReadLine();

            switch (op)
            {
                case "0":
                    Console.WriteLine("Obrigado por me avaliar!\nAguardo o convite :)");
                    break;

                case "1":
                    Console.WriteLine("entrar na solução do desafio 1");
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
