using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_8_ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CalculateDPS(int Weapon_Damage, double Weapon_Speed)
        {
            double Weapon_DPS = (double)Weapon_Damage * Weapon_Speed;
            return Weapon_DPS;
        }

        private void buttonProcessFile_Click(object sender, EventArgs e)
        {
            try
            {
                //define variables
                StreamReader reader;
                StreamWriter writer;
                string Weapon_Name;
                string Weapon_Type;
                int Weapon_Damage;
                double Weapon_Speed;
                double Weapon_DPS;
                int line;

                //define dialog filter
                openFileDialog1.Filter = "Text files (*.txt)|*.txt";
                //open file selection dialog
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            //line count for error
                            line = 0;
                            //open file
                            reader = File.OpenText(openFileDialog1.FileName);
                            writer = File.CreateText(saveFileDialog1.FileName);

                            writer.WriteLine("Weapon Name".PadRight(25) + "Weapon Type".PadRight(15) + "Damage".PadRight(15) + "Attack Speed".PadRight(15) + "DPS".PadRight(8));

                            //run through all lines
                        while (!reader.EndOfStream)
                            {
                                //read next line
                                Weapon_Name = reader.ReadLine();
                                Weapon_Type = reader.ReadLine();
                                Weapon_Damage = int.Parse(reader.ReadLine());
                                Weapon_Speed = double.Parse(reader.ReadLine());
                                Weapon_DPS = CalculateDPS(Weapon_Damage, Weapon_Speed);
                                line++;
                                writer.WriteLine(Weapon_Name.PadRight(25) + Weapon_Type.PadRight(15) + Weapon_Damage.ToString().PadRight(15) + Weapon_Speed.ToString().PadRight(15) + Weapon_DPS.ToString().PadRight(10));
                            }
                            writer.WriteLine("weapon count: " + line);
                            reader.Close();
                            writer.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


    
}
