// using System;
//
// public class Vegetable
// {
//    public Vegetable(string name) => Name = name;
//
//    public string Name { get; }
//
//    public override string ToString() => Name;
// }
//
// public class Program
// {
//    public enum Unit { item, kilogram, gram, dozen };
//
//    public static void Main()
//    {
//       var item = new Vegetable("eggplant");
//       var date = DateTime.Now;
//       var price = 1.99m;
//       var unit = Unit.item;
//       Console.WriteLine($"On {date}, the price of {item} was {price} per {unit}.");
//       Console.WriteLine($"On {date:d}, the price of {item} was {price:C2} per {unit}.");
//    }
// }

using System;
using System.Collections.Generic;

public class Example
{
   public static void Main()
   {
      var titles = new Dictionary<string, string>()
      {
          ["Doyle, Arthur Conan"] = "Hound of the Baskervilles, The",
          ["London, Jack"] = "Call of the Wild, The",
          ["Shakespeare, William"] = "Tempest, The"
      };

      Console.WriteLine("Author and Title List");
      Console.WriteLine();
      Console.WriteLine($"|{"Author",-25}|{"Title",30}|");
      foreach (var title in titles)
         Console.WriteLine($"|{title.Key,-25}|{title.Value,30}|");
   }
}
