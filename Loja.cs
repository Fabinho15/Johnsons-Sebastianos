using System;
using System.Collections.Generic;

public class Loja{
  public List<Itens> Carrinho = new List<Itens>();

  public List<Itens> ListaItens = new List<Itens> ();

   public void relacao()
    {
      Itens VarinhaR = new Itens ();

      VarinhaR.NomeIt = "Varinha rústica";
      VarinhaR.DescriIt = "Dispara uma principio de chama";
      VarinhaR.PrecoIt = 15;
      ListaItens.Add(VarinhaR);

      Itens VarinhaE = new Itens ();

      VarinhaE.NomeIt = "Varinha especialista";
      VarinhaE.DescriIt = "Gelo e fogo";
      VarinhaE.PrecoIt = 424;
      ListaItens.Add(VarinhaE);
  
      Itens VarinhaM = new Itens ();
  
      VarinhaM.NomeIt = "Varinha mestra";
      VarinhaM.DescriIt = "Gelo,fogo e vegetacao";
      VarinhaM.PrecoIt = 424;
      ListaItens.Add(VarinhaM);

      Itens PergaminhaIni = new Itens ();

      PergaminhaIni.NomeIt = "Pergaminho iniciante";
      PergaminhaIni.DescriIt = "12 magias básicas";
      PergaminhaIni.PrecoIt = 424;
      ListaItens.Add(PergaminhaIni);

      Itens PergaminhaMed = new Itens ();

      PergaminhaMed.NomeIt = "Pergaminho médio";
      PergaminhaMed.DescriIt = "todas as 15 magias básicas mais 40 magias médias";
      PergaminhaMed.PrecoIt = 424;
      ListaItens.Add(PergaminhaMed);

      Itens PergaminhaMes = new Itens ();

      PergaminhaMes.NomeIt = "Pergaminho mestre";
      PergaminhaMes.DescriIt = "todas as 120 magias";
      PergaminhaMes.PrecoIt = 424;
      ListaItens.Add(PergaminhaMes);

      Itens Pet1 = new Itens ();

      Pet1.NomeIt = "Tartaruga gélida";
      Pet1.DescriIt = "Gelo e fogo";
      Pet1.PrecoIt = 424;
      ListaItens.Add(Pet1);

      Itens Pet2 = new Itens ();

      Pet2.NomeIt = "Raposa flamejante";
      Pet2.DescriIt = "Gelo e fogo";
      Pet2.PrecoIt = 424;
      ListaItens.Add(Pet2);

      Itens Armadura1 = new Itens ();

      Armadura1.NomeIt = "Armadura de couro";
      Armadura1.DescriIt = "Gelo e fogo";
      Armadura1.PrecoIt = 424;
      ListaItens.Add(Armadura1);

      Itens Armadura2 = new Itens ();

      Armadura2.NomeIt = "Armadura de ferro";
      Armadura2.DescriIt = "Gelo e fogo";
      Armadura2.PrecoIt = 424;
      ListaItens.Add(Armadura2);

      Itens Armadura3 = new Itens ();

      Armadura3.NomeIt = "Armadura de diamante";
      Armadura3.DescriIt = "Gelo e fogo";
      Armadura3.PrecoIt = 424;
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
          if(Cliente.Florim < p.PrecoIt)
          {
            Console.WriteLine("Moedas insuficientes. Escolha outro item !");
          }
          else if(Cliente.Florim >= p.PrecoIt)
          {
          
          Cliente.Inventario.Add(p);
          Console.WriteLine("\r\n" + p.NomeIt + " vendido\r\n");
          Cliente.Florim -= p.PrecoIt;          
          Console.WriteLine(Cliente.Florim + " Moedas Florim restantes");

          foreach(var u in Cliente.Inventario){
          Console.WriteLine("Inventario:\r\n" + u.NomeIt);

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