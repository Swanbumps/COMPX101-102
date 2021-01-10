using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Shopping
{
  /// <summary>
  /// <para>Shopping List program, version with ShoppingItem objects in list.</para>
  /// <para>Displays a list of shopping items in a form. The user can enter item names
  /// in a text box to create new items, change the names of shopping item,
  /// delete multiple selected shopping items, and search the shopping list
  /// for an item with a given name. This version includes custom drawing to
  /// display icons in addition to the names of shopping items.</para>
  /// <para>Written by Robi Malik, 2016-2019</para>
  /// </summary>
  public partial class MainWindow : Form
  {

    //###############################################################################
    //# Instance Variables
    /// <summary>
    /// The list of shopping items that make our shopping list.
    /// Note how this is declared as a binding list,
    /// so that it can become the data source of our list box.
    /// </summary>
    private BindingList<ShoppingItem> _list;


    //###############################################################################
    //# Constructor
    /// <summary>
    /// Initialises the shopping list form.
    /// </summary>
    public MainWindow()
    {
      InitializeComponent();
      // Initialise the shopping list.
      _list = new BindingList<ShoppingItem>();
      // IMPORTANT - assign the shopping list to be the data source of the list box.
      _listBox.DataSource = _list;
    }

    //###############################################################################
    //# Event Handlers
    /// <summary>
    /// Event handler for Add button. Creates a new shopping item with the name
    /// in the text box and adds it to the shopping list.
    /// </summary>
    private void AddButtonClick(object sender, EventArgs e)
    {
      // Call auxiliary method, as we are doing this in other event handlers also.
      AddCurrentItem();
    }

    /// <summary>
    /// Keyboard handler for text box. If &lt;enter&gt; is pressed in the text
    /// box, a new shopping item is created.
    /// </summary>
    private void NameTextBoxKeyDown(object sender, KeyEventArgs e)
    {
      // If <enter> is pressed (without shift or such) ...
      if (e.Modifiers == Keys.None && e.KeyCode == Keys.Enter) {
        // Add a shopping item, same as Add button
        AddCurrentItem();
        // Mark the event as consumed (suppress beep)
        e.SuppressKeyPress = true;
      }
    }

    /// <summary>
    /// Event handler for selection change of list box.
    /// Loads the name of the selected item into the text box.
    /// </summary>
    private void ListBoxSelectedIndexChanged(object sender, EventArgs e)
    {
      // If the list box selection is not empty ...
      if (_listBox.SelectedIndex >= 0) {
        // Find the selected index
        int index = _listBox.SelectedIndex;
        // Get the item at that position from the list
        ShoppingItem item = _list[index];
        // Put the name of that item in the text box
        _nameTextBox.Text = item.Name;
      }
    }

    /// <summary>
    /// Event handler for Replace button. Replaces the name of the currently
    /// selected item with the contents of the text box.
    /// </summary>
    private void ReplaceButtonClick(object sender, EventArgs e)
    {
      // If the list box selection is not empty ...
      if (_listBox.SelectedIndex >= 0) {
        // Get the selected shopping item
        ShoppingItem item = _list[_listBox.SelectedIndex];
        // Change its name to what is in the text box
        item.Name = _nameTextBox.Text;
        // Re-assign list position (avoid redraw problem)
        _list[_listBox.SelectedIndex] = item;
      }
    }

    /// <summary>
    /// Event handler for Remove button.
    /// Removes all selected items from the list box.
    /// The SelectionMode of the list box is set to MultiExtended.
    /// </summary>
    private void RemoveButtonClick(object sender, EventArgs e)
    {
      // Removing several selected items from a list box is tricky, because the selection is updated after each deletion.
      // This will change the list box in an unpredictable way. To be safe, we create copy of the selection and use it
      // instead of the list box properties during the deletion loop.
      // So first create a new list of integers and put all indices of selected items in it.
      List<int> selection = new List<int>();
      foreach (int index in _listBox.SelectedIndices) {
        selection.Add(index);
      }
      // Sort the selected indices, make sure that the largest index is at the end.
      selection.Sort();
      // Work backwards through the selected indices (start deleting from the end).
      for (int i = selection.Count - 1; i >= 0; i--) {
        // Remove the item at each selected index from the shopping list.
        int index = selection[i];
        _list.RemoveAt(index);
      }
      // Clear the list box selection, i.e., deselect everything.
      _listBox.ClearSelected();
    }

    /// <summary>
    /// Event handler for Find button.
    /// Searches the shopping list for an item with the same name as in the text box,
    /// and selects the first such item.
    /// </summary>
    private void FindButtonClick(object sender, EventArgs e)
    {
      // Clear the selection (make sure only the item found will be selected)
      _listBox.ClearSelected();
      // Work through the list from the start
      for (int index = 0; index < _list.Count; index++) {
        // If the name of the current item is the same as what is in the text box
        if (_list[index].Name == _nameTextBox.Text) {
          // Select the item at this position
          _listBox.SelectedIndex = index;
          // Exit this method prematurely (do not continue searching)
          return;
        }
      }
      // If we reach the end, then the above 'return' has never been reached,
      // which means that no mathing item was found. Inform the user with a pop-up.
      MessageBox.Show("The item '" + _nameTextBox.Text + "' is not in the list.");
    }

    /// <summary>
    /// Event handler for Total button.
    /// Display the total number and value of all items in a message box.
    /// </summary>
    private void TotalButtonClick(object sender, EventArgs e)
    {
      // Variable for running sum
      decimal sum = 0;
      foreach (ShoppingItem item in _list) {
        // Add value of each item to the sum
        sum += item.Value;
      }
      // Display result
      String text = string.Format("You are shopping for {0} items totalling {1:C}.", _list.Count, sum);
      MessageBox.Show(text);
    }

    /// <summary>
    /// <para>Draw-Item event handler of list.</para>
    /// <para>Called during repaint to draw a single line of the list box.
    /// This handler puts special icons in front of entries with
    /// particular names.</para>
    /// <para>Remember that, to use a draw-item event handler, you must
    /// set the list's DrawMode property to OwnerDrawFixed.</para>
    /// </summary>
    private void ListBoxDrawItem(object sender, DrawItemEventArgs e)
    {
      e.DrawBackground();
      e.DrawFocusRectangle();
      int index = e.Index;
      if (index >= 0) {
        string text = _list[index].Name;
        Brush brush = new SolidBrush(e.ForeColor);
        Font font = _listBox.Font;
        Graphics graphics = e.Graphics;
        Rectangle bounds = e.Bounds;
        if (text == "wine" || text == "beer") {
          int iconHeight = bounds.Height - 4;
          int y0 = bounds.Top + 2;
          int y1 = bounds.Top + Convert.ToInt32(0.4 * iconHeight);
          int y2 = bounds.Top + Convert.ToInt32(0.6 * iconHeight);
          int y3 = bounds.Bottom - 2;
          int dx = Convert.ToInt32(0.25 * iconHeight);
          int x0 = bounds.Left + 3;
          int x1 = x0 + dx;
          int x2 = x1 + dx;
          int x3 = x2 + dx;
          int x4 = x3 + 3;
          Point[] points = new Point[8];
          points[0] = new Point(x0, y3);
          points[1] = new Point(x0, y2);
          points[2] = new Point(x1, y1);
          points[3] = new Point(x1, y0);
          points[4] = new Point(x2, y0);
          points[5] = new Point(x2, y1);
          points[6] = new Point(x3, y2);
          points[7] = new Point(x3, y3);
          graphics.FillPolygon(brush, points);
          bounds.Width -= (x4 - x0);
          bounds.X = x4;
        }
        graphics.DrawString(text, font, brush, bounds);
      }
    }


    //###############################################################################
    //# Private Methods
    /// <summary>
    /// Creates a new shopping item with the name from the text box.
    /// </summary>
    private void AddCurrentItem()
    {
      // Create new shopping item.
      // Name is taken from text box, weight and value are fixed a 100g and $1.25.
      ShoppingItem item = new ShoppingItem(_nameTextBox.Text, 100, 1.25m);
      // Add the new item to the end of the list
      _list.Add(item);
      // Clear the text box (make it easy to create more items)
      _nameTextBox.Clear();
    }
  }
}