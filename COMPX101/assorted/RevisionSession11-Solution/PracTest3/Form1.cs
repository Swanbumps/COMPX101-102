﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PracTest3
{
    public partial class Form1 : Form
    {
        //Name:
        //ID:

        //The number of days in the calendar, 1 is Monday and 5 is Friday
        const int NUM_DAYS = 5;
        //The number of hours to display for each day
        const int NUM_HOURS = 10;
        //The starting hour for the calendar (9am)
        const int START_HOUR = 9;
        //The amount of gap between the text and outline of an appointment
        const int OFFSET = 2;
        //The width of an appointment
        const int APP_WIDTH = 100;
        //The height of an appointment
        const int APP_HEIGHT = 60;

        const string FILTER = "CSV Files|*.csv|All Files|*.*";

        //Colour variables for the different appointments
        Color WORK_COLOUR = Color.Gold;
        Color PERSONAL_COLOUR = Color.LightBlue;

        //Lists to store all the data
        List<string> dayList = new List<string>();
        List<int> hourList = new List<int>();
        List<string> typeList = new List<string>();
        List<string> textList = new List<string>();


        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Draws the given text at the specified x and y coordinates
        /// </summary>
        /// <param name="paper">Where to draw the text</param>
        /// <param name="hour">The hour of the appointment</param>
        /// <param name="text">The text of the appointment</param>
        /// <param name="x">The x position of the appointment</param>
        /// <param name="y">The y position of the appointment</param>
        private void DrawText(Graphics paper, int hour, string text, int x, int y)
        {
            paper.DrawString(hour.ToString() + ".00: " + text, new Font("Arial", 8),
                Brushes.Black, x + OFFSET, y + OFFSET);

        }

        /// <summary>
        /// Draws an appointment in the given color.
        /// </summary>
        /// <param name="paper">Where to draw the appointment</param>
        /// <param name="x">The x position of the appointment</param>
        /// <param name="y">The y position of the appointment</param>
        /// <param name="backColor">The background color of the appointment</param>
        private void DrawAppointment(Graphics paper, int x, int y, Color backColor)
        {
            SolidBrush br = new SolidBrush(backColor);
            Pen pen1 = new Pen(Color.Black, 1);

            paper.FillRectangle(br, x, y, APP_WIDTH, APP_HEIGHT);
            paper.DrawRectangle(pen1, x, y, APP_WIDTH, APP_HEIGHT);
        }

        /// <summary>
        /// Draws an empty calendar.
        /// </summary>
        /// <param name="paper">Where to draw the calendar</param>
        private void DrawCalendar(Graphics paper)
        {
            //The x position of the current appointment
            int x = 0;
            //The y position of the current appointment
            int y = 0;

            //Clear the drawing area
            pictureBoxCalendar.Refresh();

            //Loop for each day in the calendar
            for (int hour = 1; hour <= NUM_HOURS; hour++)
            {
                //Loop for each hour in the calendar
                for (int day = 1; day <= NUM_DAYS; day++)
                {
                    //Draw the appointment and then move to the next position
                    DrawAppointment(paper, x, y, Color.White);
                    x += APP_WIDTH;
                }

                //Move down to the next row and move back to beginning of the row
                y += APP_HEIGHT;
                x = 0;
            }
        }

        /// <summary>
        /// Calculate the x position of an appointment.
        /// </summary>
        /// <param name="day">The day of the appointment</param>
        /// <returns>The x position of the appointment based on the given day</returns>
        private int CalculateX(string day)
        {
            //Stores all the days to display on the calendar
            string[] dayArray = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri" };
            //The x position of the appointment
            int x = 0;
            //The number for a day, Mon = 0, Fri = 4
            int dayNum = 0;

            //Look through the array for the given day
            for (int i = 0; i < dayArray.Length; i++)
            {
                //Check if the current day matches the given day
                if (dayArray[i] == day)
                {
                    //Store the day number for the given day
                    dayNum = i;
                }
            }

            //Calculate the x position of the appointment depending on the day
            x = dayNum * APP_WIDTH;

            return x;
        }

        private int CalculateY(int hour)
        {
            int y = (hour - START_HOUR) * APP_HEIGHT;

            return y;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            string line = "";
            string[] csvArray;
            string day = "";
            int hour = 0;
            string type = "";
            string text = "";
            int x = 0;
            int y = 0;
            int count = 0;
            Graphics paper = pictureBoxCalendar.CreateGraphics();

            //Set the filter for the dialog control
            openFileDialog1.Filter = FILTER;
            //Check if the user has selected a file
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Display the empty calendar
                DrawCalendar(paper);
                //Open the selected file
                reader = File.OpenText(openFileDialog1.FileName);
                //WHILE not the end of the file
                while(!reader.EndOfStream)
                {
                    try
                    {
                        //Read an entire line from the file
                        line = reader.ReadLine();
                        //Split the values in the line using an array
                        csvArray = line.Split(',');
                        //Check if the array has the correct number of elements
                        if(csvArray.Length == 4)
                        {
                            //Extract the values into separate variables
                            day = csvArray[0];
                            hour = int.Parse(csvArray[1]);
                            type = csvArray[2];
                            text = csvArray[3];

                            //Add the values to the listbox
                            listBoxCalendar.Items.Add(day.PadRight(5) +
                                hour.ToString().PadRight(5) +
                                type.PadRight(10) + text);

                            //Add the data to the lists
                            dayList.Add(day);
                            hourList.Add(hour);
                            typeList.Add(type);
                            textList.Add(text);

                            //Add 1 to the appointment count
                            count++;
                            //Calculate the x position of the appointment
                            x = CalculateX(day);
                            //Calulate the y position of the appointment
                            y = CalculateY(hour);

                            //Check if it is a work appointment
                            if(type == "Work")
                            {
                                DrawAppointment(paper, x, y, WORK_COLOUR);
                            }
                            else
                            {
                                DrawAppointment(paper, x, y, PERSONAL_COLOUR);
                            }
                            //Draw the text of the appointment
                            DrawText(paper, hour, text, x, y);
                        }
                        else
                        {
                            Console.WriteLine("Error: " + line);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error: " + line);
                    }
                }
                //Close the file
                reader.Close();
                //Display the number of appointments
                MessageBox.Show(count.ToString());
            }
        }

        private void countAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = 0;
            //FOR each value in the list
            for(int i = 0; i < dayList.Count; i++)
            {
                //Check if the current type in the list matches the type in the textbox
                if(typeList[i] == textBoxType.Text)
                {
                    count++;
                }
            }
            MessageBox.Show(count.ToString());
        }
    }
}
