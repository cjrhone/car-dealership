using System.Collections.Generic;
using System;

namespace CarDealership.Models
{
  public class Car
  /* Creating Car Class, which we will create instances from */
  {
    private int _price; /*Create Private int called _price*/
    private int _miles;
    private string _makemodel;
    private static List<Car> _instances = new List<Car> {}; /*Create private list called _instances, which will be empty for now*/


    public Car (int price, int miles, string makemodel)
    {
      _price = price;
      _miles = miles;
      _makemodel = makemodel;
    }

    public int GetPrice()
    {
      return _price;
    }
    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public int GetMiles()
    {
      return _miles;
    }
    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }

    public string GetMakeModel()
    {
      return _makemodel;
    }
    public void SetMakeModel(string newMakeModel)
    {
      _makemodel = newMakeModel;
    }
    public static List<Car> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
