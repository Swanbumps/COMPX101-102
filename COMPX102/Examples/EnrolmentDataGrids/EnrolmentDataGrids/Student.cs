using System;
using System.ComponentModel;

namespace EnrolmentDataGrids
{
  /// <summary>
  /// <para>A student of the university.</para>
  /// <para>This is a basic class that only contains the student ID, first name,
  /// and last name, with their instance variables and associated properties.</para>
  /// <para>Written by Robi Malik, 2016-2018.</para>
  /// </summary>
  class Student
  {
    //#########################################################################
    //# Instance Variables
    /// <summary>
    /// Student ID number.
    /// </summary>
    private ulong _id;
    /// <summary>
    /// Student's first or given name.
    /// </summary>
    private string _firstName;
    /// <summary>
    /// Student's last or family name.
    /// </summary>
    private string _lastName;


    //#########################################################################
    //# Constructors
    /// <summary>
    /// Creates a student with the given ID and name.
    /// </summary>
    public Student(ulong id, string firstName, string lastName)
    {
      _id = id;
      _firstName = firstName;
      _lastName = lastName;
    }


    //#########################################################################
    //# Public Methods
    /// <summary>
    /// Returns a string representation of the student.
    /// This is the text displayed in the list boxes.
    /// </summary>
    public override string ToString()
    {
      return _firstName + " " + _lastName + " (" + String.Format("{0:D8}", _id) + ")";
    }


    //#########################################################################
    //# Properties
    /// <summary>
    /// Student ID number.
    /// </summary>
    public ulong ID
    {
      get { return _id; }
      set { _id = value; }
    }

    /// <summary>
    /// Student's first or given name.
    /// </summary>
    public string FirstName
    {
      get { return _firstName; }
      set { _firstName = value; }
    }

    /// <summary>
    /// Student's last or family name.
    /// </summary>
    public string LastName
    {
      get { return _lastName; }
      set { _lastName = value; }
    }
  }

}

