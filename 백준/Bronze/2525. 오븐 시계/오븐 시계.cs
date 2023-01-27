using System;

class Program {
  public static int Main (string[] args) {
          string[] s = Console.ReadLine().Split();
					int h = int.Parse(s[0]);
					int m = int.Parse(s[1]);
					int time = int.Parse(Console.ReadLine());
		        m += time;
		        while(m >= 60){
		            m -= 60;
		            h ++;
		        }
		        while(h >= 24)
            {
		                h %= 24;
		        }
	
		        Console.WriteLine(h + " " + m);
		        return 0;
  }
}