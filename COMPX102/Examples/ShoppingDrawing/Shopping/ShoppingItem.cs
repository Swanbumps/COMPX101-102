using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping
{
  /// <summary>
  /// An item in the shopping list.
  /// Each item has a name, a weight, and a value.
  /// Written by Robi Malik, 2016-2019
  /// </summary>
  class ShoppingItem
  {

    //###############################################################################
    //# Instance Variables
    /// <summary>
    /// Name of item.
    /// </summary>
    private string _name;
    /// <summary>
    /// Weight in grams.
    /// </summary>
    private int _weight;
    /// <summary>
    /// Value in dollars and cents.
    /// </summary>
    private decimal _value;


    //###############################################################################
    //# Constructor
    /// <summary>
    /// Creates a new shopping item with the given initial values.
    /// </summary>
    public ShoppingItem(string name, int weight, decimal value)
    {
      _name = name;
      _weight = weight;
      _value = value;
    }


    //###############################################################################
    //# Public Methods
    /// <summary>
    /// ToString() override. When the shopping items are put in a list box,
    /// the text returned by this method will be displayed to describe the
    /// item.
    /// </summary>
    public override string ToString()
    {
      return String.Format("{0} : {1:D}g {2:C}", _name, _weight, _value);
    }


    //###############################################################################
    //# Properties
    /// <summary>
    /// Name of item.
    /// </summary>
    public string Name
    {
      get
      {
        return _name;
      }
      set
      {
        _name = value;
      }
    }

    /// <summary>
    /// Weight in grams.
    /// </summary>
    public int Weight
    {
      get
      {
        return _weight;
      }
      set
      {
        _weight = value;
      }
    }

    /// <summary>
    /// Value in dollats and cents.
    /// </summary>
    public decimal Value
    {
      get
      {
        return _value;
      }
      set
      {
        _value = value;
      }
    }

  }
}
