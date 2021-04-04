using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

    Personagem Cliente = new Personagem ();
    Loja lojinha = new Loja ();

    int opcao;

    Console.Write ("Hello World");
    Console.WriteLine ("! Este é nosso lema.\r\nSeja bem-vinde a Johnsons & Sebastianos, a melhor loja de itens mágicos de todo o Vale das Fraldas.");

    Console.Write("\r\nAntes de tudo, diga-nos seu nome: ");
    Cliente.NomeP = Console.ReadLine();

    Console.Write("\r\nAgora diga-nos a quantidade de moedas Florim que possui: ");
    Cliente.Florim = Convert.ToInt32(Console.ReadLine());

    if(Cliente.Florim < 49){
      Console.WriteLine("\r\nVocê possui poucas moedas Florim. O mínimo desta loja é 50. Mate monstros Dlor e volte quando tiver o suficiente.");
    }
    else if(Cliente.Florim > 49){
      
      Console.Write("\r\nDigite 1 para conhecer nosso catálogo, 2 para comprar ou 3 para fechar\r\n");
      
      do{
         Console.Write("Minha opção(1),(2) e (3): ");
         opcao = Convert.ToInt32(Console.ReadLine());
         Console.Clear();
          
        if(opcao == 1){
          
          lojinha.relacao();
          
          lojinha.vender(Cliente.compra(), Cliente);
        }
        if(opcao == 2){
          
          lojinha.vender(Cliente.compra(), Cliente);
          
        }
        else if(opcao != 1){
          Console.WriteLine("Okay, " +Cliente.NomeP + "!" + " Feche a porta ao sair e volte sempre!");
        }
      }
      while (opcao != 3);
     
    }
  }  
}