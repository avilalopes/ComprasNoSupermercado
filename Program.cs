using System;
using System.Collections.Generic;

class MinhaClasse {
  public static void Main (string[] args) {
    
    Console.WriteLine("Informe a quantidade de listas: ");
    var totalDeListas = int.Parse(Console.ReadLine());
    var n = totalDeListas;

    string[] listaDeCompras;
    SortedSet<string> lista;

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine();
        Console.WriteLine("Informe os itens da lista: ");        
        listaDeCompras = Console.ReadLine().Split(' ');
        lista = new SortedSet<string>(listaDeCompras);

        foreach (var item in lista)
        {
            Console.Write(item.Replace(" ",""));
            Console.Write(' ');
        }
        lista.Clear();
        Console.WriteLine();
    }
  }
}
