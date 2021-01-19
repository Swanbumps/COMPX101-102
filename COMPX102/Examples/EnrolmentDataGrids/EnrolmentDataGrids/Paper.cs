using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;


namespace EnrolmentDataGrids
{
  /// <summary>
  /// <para>A paper taught at the university.
  /// Contains the paper code and title, and a list of enrolled students.</para>
  /// <para>This class implements the INotifyPropertyChanged interface
  /// to support automatic update of all data grid views.</para>
  /// <para>Written by Robi Malik, 2016-2018</para>
  /// </summary>
  class Paper : INotifyPropertyChanged
  {
    //#########################################################################
    //# Instance Variables
    /// <summary>
    /// Paper code, e.g., "COMPX102".
    /// </summary>
    private string _code;
    /// <summary>
    /// Paper title, e.g., "Object-Oriented Programming".
    /// </summary>
    private string _title;
    /// <summary>
    /// List of students enrolled in paper.
    /// This is declared as BindingList, so it can be a data source.
    /// </summary>
    private BindingList<Student> _enrolments;


    //#########################################################################
    //# Constructors
    /// <summary>
    /// Default constructor. Creates a paper with empty name and title.
    /// This enables the functionality to add papers in a data grid view
    /// using the last empty row.
    /// </summary>
    public Paper()
      : this("COMP???", "")    // The keyword this means to call the constructor below
    {
    }

    /// <summary>
    /// Creates a new paper with the given code and title.
    /// </summary>
    public Paper(string code, string title)
    {
      // Initialise variables
      _code = code;
      _title = title;
      // Create an empty list of enrolments
      _enrolments = new BindingList<Student>();
      // Register a list-changed event handler on the enrolments list.
      // This is used below to detect and forward changes to the number of enrolled students.
      _enrolments.ListChanged += new ListChangedEventHandler(EnrolmentListChanged);
    }


    //#########################################################################
    //# Public Methods
    /// <summary>
    /// Enrols the given student in this paper.
    /// </summary>
    public void Enrol(Student student)
    {
      // If the student is not already enrolled,
      // i.e, if the student does appear in the list of enrolled students,
      if (!_enrolments.Contains(student)) {
        // then add the student to the list.
        _enrolments.Add(student);
      }
    }

    /// <summary>
    /// Withdraws the given student from this paper.
    /// </summary>
    public void Withdraw(Student student)
    {
      _enrolments.Remove(student);
    }

    /// <summary>
    /// Displays the paper's list of enrolled students to the given data grid view.
    /// </summary>
    public void Bind(DataGridView grid)
    {
      // Assign the enrolments list to be the data source of the data grod.
      // This will display it and also trigger updates if the list changes.
      grid.DataSource = _enrolments;
    }

    /// <summary>
    /// Returns a textual description of the paper.
    /// </summary>
    public override string ToString()
    {
      string text = _code + " " + _title;
      if (EnrolmentCount > 0) {
        text += " (" + EnrolmentCount + " enrolled)";
      }
      return text;
    }

    //#########################################################################
    //# Properties
    /// <summary>
    /// Paper code, e.g., "COMP104".
    /// </summary>
    public string Code { 
      get { return _code; }
      set
      {
        if (_code != value) {
          // If the paper code has changed ...
          _code = value;
          // Send property-changed notification to those that want to know
          FirePropertyChanged("Code");
        }
      } 
    }

    /// <summary>
    /// Paper title, e.g., "Introduction to Computer Science 2".
    /// </summary>
    public string Title
    {
      get { return _title; }
      set
      {
        if (_title != value) {
          // If the paper title has changed ...
          _title = value;
          // Send property-changed notification to those that want to know
          FirePropertyChanged("Title");
        }
      }
    }

    /// <summary>
    /// Number of students enrolled in this paper.
    /// </summary>
    public int EnrolmentCount
    {
      get { return _enrolments.Count; }
    }

    //#####################################################################################
    //# Event Handling Stuff
    /// <summary>
    /// The property-changed event, as required by INotifyPropertyChanged.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Event handler for change events received from enrolments list.
    /// Called automatically when enrolments list has changed.
    /// </summary>
    private void EnrolmentListChanged(object sender, ListChangedEventArgs e)
    {
      // Notify listeners that the number of enrolled students may have changed
      FirePropertyChanged("EnrolmentCount");
    }

    /// <summary>
    /// Auxiliary method to send a property-change event for a given property.
    /// </summary>
    /// <param name="prop">The name of the property that has changed.</param>
    private void FirePropertyChanged(string prop)
    {
      // if there are registered listeners
      if (PropertyChanged != null) {
        // send the notification
        PropertyChanged(this, new PropertyChangedEventArgs(prop));
      }
    }

  }
}
