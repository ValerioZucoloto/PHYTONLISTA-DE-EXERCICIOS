using System;

class MainClass {
  public static void Main (string[] args) {
    Retangulo R = new Retangulo();

    Console.WriteLine ("Informe a medida do lado A");
    R.SetLadoA (double.Parse (Console.ReadLine()));

    Console.WriteLine ("Informe a medida do lado B");
    R.SetLadoB (double.Parse (Console.ReadLine()));

    Console.WriteLine ("Calcule o perímetro do retangulo: ");
    Console.WriteLine (R.Perimetro());
  }
}