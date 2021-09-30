# JogoDaVelha
Aplicativo do famoso Jogo da Velha onde foi desenvolvido com uso da linguagem C#, e sendo executado através do Windows Console.

💻 Tecnologia utilizada
---------
![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)

## Requisitos
- Jogo ocorre em um tabuleiro de 3 por 3;
- Jogo será jogador por duas pessoas, sendo de forma alternada;
- Jogador 1 será sempre o primeiro a jogar;
- Jogador 1 será representado pela letra "X" e letras na cor vermelha;
- Jogador 2 será representado pela letra "O" e letras na cor amarela;
- Jogador que formar primeiro uma reta na diagonal, vertical ou horizontal do tabuleiro será o ganhador;
- O jogo poderá ter 3 resultados onde temos: vitória do jogador 1, vitória do jogador 2 ou empate;
- Permitido apenas para o usuário digitar no intervalo de número de 1 à 9;

## Funcionamento
- Passo 1: Solicita para Jogador 1 ou 2 um número no intervalo de 1 à 9, caso não for escolhido nos requisitos solicitado será sempre pedido um novo número;
- Passo 2: É verificado se a opção escolhida está preenchida, caso contrário gera um novo tabuleiro marcando com o símbolo do jogador;
- Passo 3: Sistema verifica através de uma lista de possibilidades de vitória se há algum ganhador, caso retorno for verdadeiro será exibido mensagem informando o ganhador e encerra a aplicação, caso contrário continua;
- Será solicitado de forma alternada para cada jogada de cada os passos 1,2 e 3;
- Caso não houver ganhadores sistema irá retornar uma mensagem em tela informando que infelizmente não houveram ganhadores e encerra aplicação.
