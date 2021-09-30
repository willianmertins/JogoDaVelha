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
      for(int i=0; i < 9; i++){     

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
        EscolhaOpcao();

      bool validaOpcao = false;
      while (!validaOpcao) {
        if(vetor[opcao] != 'X' && vetor[opcao] != 'O'){
          vetor[opcao] = jogador % 2 == 0 ? 'X' : 'O';
          jogador++;
          validaOpcao = true;
          ValidaWinner();
          if (winner) return;
        } else {
          opcao++;
          Console.WriteLine("Desculpe! A opção \"{0}\" já foi escolhida...", opcao);
          Console.Write("Escolha outra opção: ");
          EscolhaOpcao();
        }
      }   
     }
     Tabuleiro();
     Console.WriteLine("\nInfelizmente! Acabou em empate :(");
    }
    
    private static void Tabuleiro(){
      Console.Clear();
      Console.WriteLine("\n");
      Console.WriteLine("Jogo da Velha");
      Console.WriteLine("##############");
      Console.WriteLine("Jogador 1: X \nJogador 2: O");
      Console.WriteLine("##############\n");

      Console.ForegroundColor = ConsoleColor.Green;
      Console.WriteLine("_________________");

      for(int i = 0; i < 3; i++){
        Console.WriteLine("  {0}  |  {1}  |  {2}  ",vetor[i*3],vetor[i*3+1],vetor[i*3+2]);
        Console.WriteLine("_____|_____|_____");
      }
      Console.ResetColor();
    }

    private static int EscolhaOpcao(){

      bool error = false;
      string str = string.Empty;

      while (!error) {
        str = Console.ReadLine();
        error = Regex.IsMatch(str,@"^\d{1}$");
        if (error == false || int.Parse(str) == 0) {
            Console.WriteLine("Desculpe! É apenas permitido números entre 1 à 9");
            Console.Write("Escolha uma opção: ");
            error = false;
         }
      }
      opcao = int.Parse(str);
      opcao--;
      return opcao;
    }

    private static bool ValidaWinner(){
      List<char> str = new List<char> { 'X', 'O' };
      List<string> coordWin = new List<string> { "0;1;2", "0;3;6", "1;4;7", "3;4;5", "6;7;8", "2;5;8", "2;4;6", "0;4;8" };
      int ganhador = 0;

      foreach(char c in str) {

        foreach(string s in coordWin) {

            string[] item = s.Split(';');
            if (vetor[int.Parse(item[0])] == c && vetor[int.Parse(item[1])] == c && vetor[int.Parse(item[2])] == c) {
                Tabuleiro();
                ganhador = c == 'X' ? 1 : 2;
                Console.WriteLine("\nJogador {0} é o ganhador!!",ganhador);
                return winner=true;
            }   
        }

       }
      return winner;
    }
  }
}
