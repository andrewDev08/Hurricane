using System;
//20240923_AndrewHorton_Exercise3.2
class Program {
  public static void Main (string[] args) {
    decimal hurricaneSpeed = 0;
    
    Console.WriteLine("Please enter the Speed of the Winds in Mph: ");
    var x = Console.ReadLine();
  
    if (decimal.TryParse(x, out hurricaneSpeed)){}
    else {
      Console.WriteLine("Please only put the number" );
    }

    if(hurricaneSpeed < 74)
    {
      Console.WriteLine("Not a Hurricane");
    }
    else if ((hurricaneSpeed >= 74) && (hurricaneSpeed < 96))
    {
      Console.WriteLine("Category One Hurricane");
    }
    else if ((hurricaneSpeed >= 96) && (hurricaneSpeed < 111))
    {
      Console.WriteLine("Category Two Hurricane");
    }
    else if ((hurricaneSpeed >= 111) && (hurricaneSpeed < 130))
    {
      Console.WriteLine("Category Three Hurricane");
    }
    else if ((hurricaneSpeed >= 130) && (hurricaneSpeed < 157))
    {
      Console.WriteLine("Category Four Hurricane");
    }
    else if(hurricaneSpeed >= 157)
    {
      Console.WriteLine("Category Five Hurricane");
    }
    else
    {
      Console.WriteLine("Error");
    }
  }
}