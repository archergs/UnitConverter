using System;
using System.Windows.Forms;

namespace Conversion_App
{
    public partial class Form1 : Form
    {
        // Set up variables for Drop Down menus,
        // user input and a double for manipulating
        // the user input.
        public string selected1;
        public string selected2;

        public string userInput;
        public double userNum;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Assign the selected value from the first drop down to the selected1 variable
            selected1 = dropDown.SelectedItem.ToString();
        }

        private void dropDownTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Assign the selected value from the second drop down to the selected2 variable
            selected2 = dropDownTwo.SelectedItem.ToString();
        }

        private void userValue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // Assign the user's input to the userInput variable
            userInput = userValue.Text;

            if (selected1 == "Millimetre")
            {
                if (selected2 == "Millimetre")
                {
                    // Because no conversion is needed here, the
                    // user's input can be put straight into the
                    // answer text box, or textBox2.
                    textBox2.Text = userInput;
                }

                if (selected2 == "Centimetre")
                {
                    // convert the userInput string into a double
                    double.TryParse(userInput, out userNum);
                    // In order to convert from a millimetre to 
                    // centimetre, divide the user input by 10.
                    userNum = userNum / 10;
                    // Assign the manipulated user input back
                    // to the userInput variable.
                    userInput = userNum.ToString();
                    // Show the manipulated answer in textBox2.
                    textBox2.Text = userInput;

                    // The above code is used for every other conversion, 
                    // with some minor differences depending on the unit
                    // of measurement. I will note on any differences when
                    // they appear.
                }

                if (selected2 == "Metre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 1000;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "Kilometre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 1000000;
                    // 0.###### is used to assign a decimal instead of 
                    // some random ass thing to the userInput variable.
                    userInput = userNum.ToString("0.######");
                    textBox2.Text = userInput;
                }

                // Imperial Conversions for Millimetre Begin Here

                if (selected2 == "Inches")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 25.4;
                    // "0.##########" is used when converting from Metric to
                    // Imperial units to limit the size of the decimal.
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Feet")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 304.8;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Yards")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 914.4;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Miles")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 1609334;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }
            }

            if (selected1 == "Centimetre")
            {
                if (selected2 == "Millimetre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 10;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "Centimetre")
                {
                    textBox2.Text = userInput;
                }

                if (selected2 == "Metre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 100;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "Kilometre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 100000;
                    userInput = userNum.ToString("0.######");
                    textBox2.Text = userInput;
                }

                // Imperial Conversions for Centimetre Begin Here

                if (selected2 == "Inches")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 2.54;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Feet")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 30.48;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Yards")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 91.44;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Miles")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 160934.4;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }
            }

            if (selected1 == "Metre")
            {
                if (selected2 == "Millimetre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 1000;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "Centimetre")
                { 
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 100;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "Metre")
                {
                    textBox2.Text = userInput;
                }

                if (selected2 == "Kilometre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 1000;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                // Imperial Conversions for Metre Begin Here

                if (selected2 == "Inches")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 0.0254;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Feet")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 0.3048;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Yards")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 0.9144;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Miles")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 1609.344;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }
            }

            if (selected1 == "Kilometre")
            {
                if (selected2 == "Millimetre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 1000000;
                    userInput = userNum.ToString("0.#######");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Centimetre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 100000;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "Metre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 1000;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "Kilometre")
                {
                    textBox2.Text = userInput;
                }

                // Imperial Conversions for Kilometre Begin Here

                if (selected2 == "Inches")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 0.0000254;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Feet")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 0.0003048;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Yards")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 0.0009144;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Miles")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 1.609344;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }
            }

            // Imperial to Metric Convertions Begins Here

            if (selected1 == "Inches")
            {
                if (selected2 == "Millimetre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 25.4;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Centimetre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 2.54;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Metre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 0.0254;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Kilometre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 0.0000254;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                // Imperial to Imperial Conversion for Inches Begin Here

                if (selected2 == "Inches")
                {
                    textBox2.Text = userInput;
                }

                if (selected2 == "Feet")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 12;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Yards")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 36;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Miles")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 63360;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }
            }

            if (selected1 == "Feet")
            {
                if (selected2 == "Millimetre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 304.8;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Centimetre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 30.48;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Metre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 0.3048;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Kilometre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 0.0003048;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                // Imperial to Imperial Conversions for Feet Begins Here

                if (selected2 == "Inches")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 12;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Feet")
                {
                    textBox2.Text = userInput;
                }

                if (selected2 == "Yards")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 3;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Miles")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 5280;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }
            }

            if (selected1 == "Yards")
            {
                if (selected2 == "Millimetre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 914.4;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Centimetre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 91.44;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Metre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 0.9144;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Kilometre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 0.0009144;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                // Imperial to Imperial Conversions for Yards Begins Here

                if (selected2 == "Inches")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 36;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Feet")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 3;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Yards")
                {
                    textBox2.Text = userInput;
                }

                if (selected2 == "Miles")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 1760;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }
            }

            if (selected1 == "Miles")
            {
                if (selected2 == "Millimetre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 1609344;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Centimetre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 160934.4;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Metre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 1609.344;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }
                if (selected2 == "Kilometre")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 1.609344;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                // Imperial to Imperial Conversions for Miles Begins Here

                if (selected2 == "Inches")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 63360;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Feet")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 5280;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Yards")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 1760;
                    userInput = userNum.ToString("0.##########");
                    textBox2.Text = userInput;
                }

                if (selected2 == "Miles")
                {
                    textBox2.Text = userInput;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }
    }
}