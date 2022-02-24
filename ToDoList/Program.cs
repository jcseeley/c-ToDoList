using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static List<Item> newList = new List<Item> {};
    
    public static void Main()
    {
      Console.WriteLine("Would you like to add an item or view your list?");
      string response = Console.ReadLine();
      bool add = response == "add";
      bool view = response == "view";
      
      if (add)
      {
        Console.WriteLine("Please enter the description of your new item.");
        string description = Console.ReadLine();
        newList.Add(new Item(description));
        Console.WriteLine("'" + description + "'" + " has been added to your list.");
        Main();
      }
      else if (view)
      {
        if (newList.Count >= 1)
        {
          Console.WriteLine("Your list items: ");
          List<Item> result = Item.GetAll();
          foreach (Item thisItem in result)
          {
            Console.WriteLine(thisItem.Description);
          }
          Main();
        }
        else
        {
          Console.WriteLine("There are no items on your list.");
          Main();
        }
      }
    }
  }
}