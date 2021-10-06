using System;
using System.Linq;
class MainClass {
  public static void Main (string[] args) {
  double[] Cel = new double[7];
  double[] Far = new double[7];
  double total = 0;
  for(int day = 0; day < 7; day++)
  {
      Console.WriteLine("Enter temperature in Celsius:");
      Cel[day] = Convert.ToDouble(Console.ReadLine());
      Far[day] = ((Cel[day]*9/5) + 32);
  }
  for(int day = 6; day>=0;day--)
  {
    total = total + Far[day];
    Console.WriteLine(Far[day]);
  }
  Console.WriteLine("Average weekly temperature is "+ (total/7) + " degrees farenheit.");
  }


}