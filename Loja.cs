using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Loja{
  public List<Itens> Carrinho = new List<Itens>();

  public List<Itens> ListaItens = new List<Itens> ();

   public void relacao()
    {
      Itens VarinhaR = new Itens ();

      VarinhaR.NomeIt = "Varinha rustica";
      VarinhaR.DescriIt = "Dispara uma principio de chama";
      VarinhaR.PrecoIt = 15;
      ListaItens.Add(VarinhaR);

      Itens VarinhaE = new Itens ();

      VarinhaE.NomeIt = "Varinha especialista";
      VarinhaE.DescriIt = "Dispara principios de gelo e fogo";
      VarinhaE.PrecoIt = 50;
      ListaItens.Add(VarinhaE);
  
      Itens VarinhaM = new Itens ();
  
      VarinhaM.NomeIt = "Varinha mestra";
      VarinhaM.DescriIt = "Dispara principios gelo,fogo e vegetacao";
      VarinhaM.PrecoIt = 124;
      ListaItens.Add(VarinhaM);

      Itens PergaminhaIni = new Itens ();

      PergaminhaIni.NomeIt = "Pergaminho iniciante";
      PergaminhaIni.DescriIt = "12 magias básicas";
      PergaminhaIni.PrecoIt = 34;
      ListaItens.Add(PergaminhaIni);

      Itens PergaminhaMed = new Itens ();

      PergaminhaMed.NomeIt = "Pergaminho médio";
      PergaminhaMed.DescriIt = "todas as 15 magias básicas mais 40 magias médias";
      PergaminhaMed.PrecoIt = 67;
      ListaItens.Add(PergaminhaMed);

      Itens PergaminhaMes = new Itens ();

      PergaminhaMes.NomeIt = "Pergaminho mestre";
      PergaminhaMes.DescriIt = "todas as 120 magias";
      PergaminhaMes.PrecoIt = 324;
      ListaItens.Add(PergaminhaMes);

      Itens Pet1 = new Itens ();

      Pet1.NomeIt = "Tartaruga gélida";
      Pet1.DescriIt = "Velocidade de 40 Phemps";
      Pet1.PrecoIt = 124;
      ListaItens.Add(Pet1);

      Itens Pet2 = new Itens ();

      Pet2.NomeIt = "Raposa flamejante";
      Pet2.DescriIt = "Velocidade de 90 Phemps";
      Pet2.PrecoIt = 427;
      ListaItens.Add(Pet2);

      Itens Armadura1 = new Itens ();

      Armadura1.NomeIt = "Armadura de couro";
      Armadura1.DescriIt = "Resistente contra gelo e fogo";
      Armadura1.PrecoIt = 24;
      ListaItens.Add(Armadura1);

      Itens Armadura2 = new Itens ();

      Armadura2.NomeIt = "Armadura de ferro";
      Armadura2.DescriIt = "Resistente contra vegentação, gelo e fogo";
      Armadura2.PrecoIt = 154;
      ListaItens.Add(Armadura2);

      Itens Armadura3 = new Itens ();

      Armadura3.NomeIt = "Armadura de diamante";
      Armadura3.DescriIt = "Resistente contra todos os elementos";
      Armadura3.PrecoIt = 474;
      ListaItens.Add(Armadura3);

      foreach (var i in ListaItens)
        {
          Console.WriteLine("\r\nNome: "+ i.NomeIt);
          Console.WriteLine("Breve Descrição: "+ i.DescriIt);        
          Console.WriteLine("Preço: "+ i.PrecoIt);
        }

    }
    public void vender(string compra, Personagem Cliente){

      List<Itens> InvenTemp = new List<Itens>();
      foreach (var p in ListaItens)
      {
        if(p.NomeIt == compra)
        {
          if(Cliente.Florim >= p.PrecoIt)
          {
          
          Cliente.Inventario.Add(p);
          Console.WriteLine("\r\n" + p.NomeIt + " vendido\r\n");
          Cliente.Florim -= p.PrecoIt;          
          Console.WriteLine(Cliente.Florim + " Moedas Florim restantes");

          foreach(var u in Cliente.Inventario){
          Console.WriteLine("Inventario:\r\n" + u.NomeIt);

          }
          if(Cliente.Florim < p.PrecoIt)
          {
            Console.WriteLine("Moedas insuficientes. Escolha outro item !");
          }
        }
        else
        {
          InvenTemp.Add(p);
        }
      }
      ListaItens.Clear();
      foreach(var item in InvenTemp)
      {
        ListaItens.Add(item);
      }
    }
  }    
}