/*
 A intelitrader foi contratada para traduzir uma mensagem capturada na rede
de um navio e ela está criptografada. Não sabemos que tipo de criptografia eles usaram,
a única coisa que sabemos até agora, é que, a cada 8 bits, os dois últimos estão invertidos e a cada 4 bits,
os 4 bits foram trocados com os próximos 4.

Mensagem criptografada:
10010110 11110111 01010110 00000001 00010111 00100110 01010111 00000001
00010111 01110110 01010111 00110110 11110111 11010111 01010111 00000011

Instruções:

Existe mais de uma maneira de resolver este problema, mas aqui está alguns conceitos que podem te ajudar:
- Tabela ASCII
- Operadores lógicos
- Números binários e hexadecimais
Você saberá se conseguiu descriptografar a mensagem se ela for legível e em inglês.
Pois, qualquer bit errado, você terá uma mensagem cheia de símbolos.
 
            MINHA SOLUÇÃO: INVERTER BITS 7 E 8, INVERTER SEQUENCIA DE BITS 1234 POR 5678 
 */

namespace Intelitrader.application
{
    public class CriptografiaNaRedeDoNavio
    {
        private String mensagemCriptografada = "10010110 11110111 01010110 00000001 00010111 00100110 01010111 00000001 00010111 01110110 01010111 00110110 11110111 11010111 01010111 00000011";

        public void decifrar()
        {
            String janelaDeslizante = "";
            String mensagemDecifradaBinario = "";
            for(int i = 0; i <= mensagemCriptografada.Length - 8; i = i + 9)
            {
                janelaDeslizante = mensagemCriptografada[i..(i+8)]; //index 0, 1, 2, ..., 8
                
                //inicio troca de posição dos primeiros 4 bista pelos últimos 4 bits da sequência
                mensagemDecifradaBinario += janelaDeslizante[4..6]; //index 4, 5
                
                // fazendo not no penúltimo bit da sequência
                if (janelaDeslizante[6].Equals('0'))
                    mensagemDecifradaBinario += '1';
                else
                    mensagemDecifradaBinario += '0';

                // fazendo not no último bit da sequência
                if (janelaDeslizante[7].Equals('0'))
                    mensagemDecifradaBinario += '1';
                else
                    mensagemDecifradaBinario += '0';

                mensagemDecifradaBinario += janelaDeslizante[0..4]; //index 0, 1, 2, 3
                //fim da troca de posição
                //adicionando espaço em branco
                mensagemDecifradaBinario += " ";
            }
            
            // nesse ponto, mensagemDecifradaBinario contém os 16 códigos ASCII (em binário de 8 bits) 
            Console.WriteLine(mensagemDecifradaBinario);

            //falta converter cada código no caractere correspondente
        }
    }
}
