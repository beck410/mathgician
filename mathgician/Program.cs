using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathgician {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("I am the MATHGICIAN");
      Console.WriteLine("What shall I math?\nFibonacci, Primes or Integers?");
      string desiredMaths = Console.ReadLine();
      Console.WriteLine("Ok i'm gonna do some " + desiredMaths);
      if (desiredMaths == "Integers") {

      }
      else {
        Console.WriteLine("I lied");

      }


      System.Console.WriteLine("Press any key...");
      System.Console.ReadKey();
    
    }
  }
}
