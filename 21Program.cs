Console.WriteLine("Enter numbers:");
      int count = 0;
      string str = Console.ReadLine();
      string[] strings = str.Split(",");
      foreach (var s in strings){
        if(Convert.ToInt32(s) > 0){
          count++;
        }
      }
      Console.WriteLine("Counter: {0}", count);