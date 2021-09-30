# Jogo da Velha :hash:
Aplicativo do famoso Jogo da Velha onde foi desenvolvido com uso da linguagem C#, e sendo executado através do Windows Console.

💻 Tecnologia utilizada
---------
![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)

## Requisitos
- Jogo ocorre em um tabuleiro de 3 por 3;
- Jogo será jogado por duas pessoas de forma alternada;
- Jogador 1 será sempre o primeiro a jogar;
- Jogador 1 será representado pela letra `"X"` e letras na cor `vermelha`
- Jogador 2 será representado pela letra `"O"` e letras na cor `amarela`;
- Jogador que formar primeiro uma reta na diagonal, vertical ou horizontal do tabuleiro será o ganhador;
- O jogo poderá ter 3 resultados onde temos: vitória do jogador 1, vitória do jogador 2 ou empate;
- Permitido apenas para o usuário digitar no intervalo de número de 1 à 9;

## Funcionamento
- <b>`Passo 1:`</b> Solicita para Jogador 1 ou 2 um número no intervalo de 1 à 9, caso não for escolhido nos requisitos solicitados será sempre pedido um novo número;
- <b>`Passo 2:`</b> Verifica se a opção escolhida já foi selecionada anteriormente, se sim será informado o usuário que a posição está preenchida e que escolha uma opção nos padrãos solicitados, caso contrário mostra no tabuleiro a opção escolhida de acordo com o símbolo do jogador;
- <b>`Passo 3:`</b> Sistema verifica através de uma lista de possibilidades de vitória se há algum ganhador, caso retorno for verdadeiro será exibido mensagem informando o ganhador e encerra a aplicação, caso contrário continua;
- <b>`Passo 4:`</b> Será solicitado de forma alternada os passos 1, 2 e 3, a cada rodada;
- <b>`Passo 5:`</b> Caso não houver ganhadores sistema irá retornar uma mensagem em tela informando que infelizmente não houveram ganhadores e encerra aplicação.
