using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace JogoDaVelha
{
  class Program
  {
    static char[] vetor = { '1', '2', '3', '4', '5','6', '7', '8', '9'};
    static int jogador = 0;
    static int opcao = 0;

    static bool winner = false;
    static void Main(string[] args)
    {
      do {
        Console.Clear();
        Console.WriteLine("Jogo da Velha");
        Console.WriteLine("##############");
        Console.WriteLine("Jogador 1: X \nJogador 2: O");
        Console.WriteLine("##############\n");

        //Cria tabuleiro
        Tabuleiro();

        if(jogador % 2 == 0) {
          Console.WriteLine("Vez do Jogador 1!");
        } else {
          Console.WriteLine("Vez do Jogador 2!");
        }
        //Captura a escolha do jogador
        Console.ForegroundColor = ConsoleColor.Green;
        Console.ResetColor();
        Console.Write("Escolha sua opção entre 1 à 9: ");
        escolhaOpcao();

      bool validaOpcao = false;
      while (!validaOpcao) {
        if(vetor[opcao] != 'X' && vetor[opcao] != 'O'){
          vetor[opcao] = jogador % 2 == 0 ? 'X' : 'O';
          jogador++;
          validaOpcao = true;
        } else {
          opcao++;
          Console.WriteLine("Desculpe! A opção \"{0}\" já foi escolhida...", opcao);
          Console.Write("Escolha outra opção: ");
          escolhaOpcao();
        }
      }
      validaWinner();

     } while(!winner);
          
    }
    
    private static void Tabuleiro(){
      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("_________________");
      for(int i = 0; i < 3; i++){
        Console.WriteLine("  {0}  |  {1}  |  {2}  ",vetor[i*3],vetor[i*3+1],vetor[i*3+2]);
        Console.WriteLine("_____|_____|_____");
      }
      Console.ResetColor();
    }

    private static int escolhaOpcao(){
      bool error = false;
      string str = string.Empty;

      while (!error) {
        str = Console.ReadLine();
        error = Regex.IsMatch(str,@"^\d{1}$");
        Console.WriteLine("Desculpe! É apenas permitido números entre 1 à 9");
        Console.Write("Escolha uma opção: ");
      }

      opcao = int.Parse(str);
      opcao--;
      return opcao;
    }

    private static bool validaWinner(){
      // winner = true;
      Console.WriteLine("\nJogador 1 é o ganhador!!");
      return winner;

    }
  }
}
