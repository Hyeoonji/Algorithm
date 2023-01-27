using System;

class Program {
  public static int Main (string[] args) {
    string [] str = Console.ReadLine().Split();
    int a = int.Parse(str[0]);
    int b = int.Parse(str[1]);
    int c = int.Parse(str[2]);
    int cash;
    int max = 0;
    max = ((a > b) && (a > c)) ? a : ((b > a) && (b > c)) ? b : c;

    if(a == b && b == c){
      cash = 10000 + a*1000;
    } else if(a ==b){
      cash = 1000 + a*100;
    } else if(b ==c){
      cash = 1000 + b*100;
    } else if(a ==c){
      cash = 1000 + c*100;
    } else {
      cash = max * 100;
    }

    Console.WriteLine(cash);
    return 0;
  }
}