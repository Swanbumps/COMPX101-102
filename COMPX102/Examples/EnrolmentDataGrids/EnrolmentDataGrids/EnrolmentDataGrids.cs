using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace EnrolmentDataGrids
{
  /// <summary>
  /// <para>Data grid version of enrolments program.</para>
  /// <para>Displays three data grid views containing respectively:
  /// all papers, all students, and the students enrolled in a paper.</para>
  /// <para>The contents of the enrolments data grid changes to reflect the enrolments
  /// of the paper selected in the papers data grid.</para>
  /// <para>Students can be enrolled by selecting a student and a paper, and
  /// clicking the Enrol button.</para>
  /// <para>To withdraw a student, select a row of the enrolments
  /// data grid and press the &lt;Delete&gt; key.</para>
  /// <para>The attributes of papers and students can be edited in the data grids, and
  /// will immediately update in all places.</para>
  /// <para>The papers data grid also shows the number of enrolled students,
  /// which updates automatically when students are enrolled or withdrawn.</para>
  /// <para>Written by Robi Malik, 2016-2018</para>
  /// </summary>
  public partial class EnrolmentsForm : Form
  {
    //#########################################################################
    //# Instance Variables
    /// <summary>
    /// The list of all papers. Used as data source of papers data grid view.
    /// </summary>
    private BindingList<Paper> _papers;
    /// <summary>
    /// The list of all students. Used as data source of students data grid view.
    /// </summary>
    private BindingList<Student> _students;



    //#########################################################################
    //# Constructors
    public EnrolmentsForm()
    {
      InitializeComponent();

      // Create the list of papers, and add some papers
      _papers = new BindingList<Paper>();
      _papers.Add(new Paper("COMPX101", "Introduction to Computer Science"));
      _papers.Add(new Paper("COMPX102", "Object-Oriented Programming"));
      _papers.Add(new Paper("COMPX151", "The Computing Experience"));
      _papers.Add(new Paper("COMPX161", "Computing Media"));
      _papers.Add(new Paper("COMPX201", "Data Structures and Algorithms"));
      _papers.Add(new Paper("COMPX202", "Mobile Computing and Software Architecture"));
      _papers.Add(new Paper("COMPX203", "Computer Systems"));
      _papers.Add(new Paper("COMPX204", "Practical Networking and Cyber Security"));
      _papers.Add(new Paper("COMPX221", "Programming for Creative Industries"));
      _papers.Add(new Paper("COMPX222", "Internet Applications"));
      _papers.Add(new Paper("COMPX223", "Database Practice and Experience"));
      _papers.Add(new Paper("COMPX241", "Software Engineering Development"));
      _papers.Add(new Paper("COMPX242", "Software Engineering Process"));
      _papers.Add(new Paper("COMPX251", "Information Discovery"));
      _papers.Add(new Paper("COMPX252", "Interactive Computing"));
      // Make this list the data source of the papers data grid view
      _papersGrid.DataSource = _papers;

      // Create the list of students, and add some students
      _students = new BindingList<Student>();
      _students.Add(new Student(7830000, "Muhammad ibn Musa", "al-Khwarizmi"));
      _students.Add(new Student(13980000, "Johannes", "Gutenberg"));
      _students.Add(new Student(14880120, "Sebastian", "Münster"));
      _students.Add(new Student(15640426, "William", "Shakespeare"));
      _students.Add(new Student(16010817, "Pierre", "de Fermat"));
      _students.Add(new Student(16421225, "Isaac", "Newton"));
      _students.Add(new Student(16460701, "Gottfried Wilhelm", "Leibnitz"));
      _students.Add(new Student(17580506, "Maximilien", "de Robespierre"));
      _students.Add(new Student(17910922, "Michael", "Faraday"));
      _students.Add(new Student(17911226, "Charles", "Babbage"));
      _students.Add(new Student(18060627, "Augustus", "de Morgan"));
      _students.Add(new Student(18470211, "Thomas", "Edison"));
      _students.Add(new Student(18671107, "Marie", "Curie"));
      _students.Add(new Student(18710830, "Ernest", "Rutherford"));
      _students.Add(new Student(18790314, "Albert", "Einstein"));
      _students.Add(new Student(18820323, "Emmy", "Noether"));
      _students.Add(new Student(18870523, "Thoralf", "Skolem"));
      _students.Add(new Student(19031228, "John", "von Neumann"));
      _students.Add(new Student(19060428, "Kurt", "Gödel"));
      _students.Add(new Student(19061209, "Grace", "Hopper"));
      _students.Add(new Student(19000212, "Jacques", "Herbrand"));
      _students.Add(new Student(19120623, "Alan", "Turing"));
      _students.Add(new Student(19300511, "Edsger", "Dijkstra"));
      _students.Add(new Student(19340111, "Antony", "Hoare"));
      // Make this list the data source of the students data grid view
      _studentsGrid.DataSource = _students;

      // Enrol the student al-Khwarizmi in COMPX102
      Paper compx102 = _papers[1];
      Student alKhwarizmi = _students[0];
      compx102.Enrol(alKhwarizmi);
    }


    //#########################################################################
    //# Event Handlers
    /// <summary>
    /// Handler for 'Enrol' button. Adds the student currently selected in the
    /// students data grid to paper currently selected in the papers data grid.
    /// </summary>
    private void EnrolButtonClick(object sender, EventArgs e)
    {
      // Have we got a selected paper
      DataGridViewCell paperCell = _papersGrid.CurrentCell;
      if (paperCell == null) {
         MessageBox.Show("No paper available!");
         return;
      }
      // ... and a selected student?
      DataGridViewCell studentCell = _studentsGrid.CurrentCell;
      if (studentCell == null) {
         MessageBox.Show("No student available!");
         return;
      }
      // Then find the paper and student by their indices
      int paperIndex = paperCell.RowIndex;
      Paper paper = _papers[paperIndex];
      int studentIndex = studentCell.RowIndex;
      Student student = _students[studentIndex];
      // Call the paper's Enrol() method to add the student
      paper.Enrol(student);
    }

    /// <summary>
    /// Selection-changed handler of papers data grid view.
    /// Displays the enrolments of the new selected paper in the
    /// enrolments data grid view.
    /// </summary>
    private void PapersGridSelectionChanged(object sender, EventArgs e)
    {
      // Find the selected paper
      DataGridViewCell cell = _papersGrid.CurrentCell;
      if (cell != null) {
        int paperIndex = cell.RowIndex;
        Paper paper = _papers[paperIndex];
        // Call the Bind() method, to change the data source of the enrolments
        // data grid view (the argument) to the paper's list of enrolled students
        paper.Bind(_enrolledGrid);
      }
    }
 
  }
}
