using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Personagem{
  
  public String NomeP;
  public Int32 Florim;
  public List<Itens> Inventario = new List<Itens> ();

  public string compra(){
    
    string compra;
    Console.Write("Quero comprar: ");
    compra = Console.ReadLine();
    return compra;
  }
}