using System;
using System.Linq;

class MinhaClasse {
  public static void Main (string[] args) {
    var totalDeCasosDeTeste = int.Parse(Console.ReadLine());
    
    for(int i=0; i<totalDeCasosDeTeste; i++){
      string[] lista = Console.ReadLine().Split(" ");
      
      Array.Sort(lista);
      foreach(string j in lista.Distinct().ToArray()){
          Console.Write(j + " ");
      }
      Console.Write("\n");
    }
  }
}
