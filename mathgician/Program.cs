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
        PrintIntegers();
      } else if(desiredMaths == "Fibonacci"){
        PrintFibonacci();
      } else if(desiredMaths == "Primes"){
        PrintPrimes();
      }
      else {
        Console.WriteLine("I lied");

      }


      System.Console.WriteLine("Press any key...");
      System.Console.ReadKey();
    
    }

    private static void PrintPrimes() {
      int number = 2;
      List<int> Primes = new List<int> {2};
      
      while (true) {
        Boolean prime = true;
        for (int i = 0; i < Primes.Count; i++) {
          if (number % Primes[i] == 0) {
            prime = false;
            break;
          }
        }
      if (prime == true) {
        System.Threading.Thread.Sleep(100);
        System.Console.WriteLine(number);
        Primes.Add(number);
      }
        number++; 
      }
      throw new NotImplementedException();
    }

    private static void PrintFibonacci() {
      while(true) {
        //1,1,3,5,8
        int prev = 0;
        int current = 1;

        while (true) {
          Console.WriteLine(current);
          System.Threading.Thread.Sleep(100);
          int newValue = prev + current;
          prev = current;
          current = newValue;
          
        }
      }
      throw new NotImplementedException();
    }

    private static void PrintIntegers() {
      int nextInteger = 0;
      while (true) {
        nextInteger++;
        Console.WriteLine(nextInteger);
      }
      throw new NotImplementedException();
    }
  }
}
