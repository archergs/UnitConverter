using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;

namespace Conversion_App
{
    public partial class Form1 : Form
    {
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
            selected1 = dropDown.SelectedItem.ToString();
        }

        private void dropDownTwo_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected2 = dropDownTwo.SelectedItem.ToString();
        }

        private void userValue_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            userInput = userValue.Text;

            if (selected1 == "mm")
            {
                if (selected2 == "mm")
                {
                    textBox2.Text = userInput;
                }

                if (selected2 == "cm")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 10;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "m")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 1000;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "km")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 1000000;
                    userInput = userNum.ToString("0.######");
                    textBox2.Text = userInput;
                }
            }

            if (selected1 == "cm")
            {
                if (selected2 == "mm")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 10;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "cm")
                {
                    textBox2.Text = userInput;
                }

                if (selected2 == "m")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 100;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "km")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 100000;
                    userInput = userNum.ToString("0.######");
                    textBox2.Text = userInput;
                }
            }

            if (selected1 == "m")
            {
                if (selected2 == "mm")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 1000;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "cm")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 100;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "m")
                {
                    textBox2.Text = userInput;
                }

                if (selected2 == "km")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum / 1000;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }
            }

            if (selected1 == "km")
            {
                if (selected2 == "mm")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 1000000;
                    userInput = userNum.ToString("0.#######");
                    textBox2.Text = userInput;
                }

                if (selected2 == "cm")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 100000;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "m")
                {
                    double.TryParse(userInput, out userNum);
                    userNum = userNum * 1000;
                    userInput = userNum.ToString();
                    textBox2.Text = userInput;
                }

                if (selected2 == "km")
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
            CheckForUpdate();
            async void CheckForUpdate()
            {
                try
                {
                    using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/dartvalince/DiscerningEye"))
                    {
                        UpdateManager updateManager = mgr;
                        var release = await mgr.UpdateApp();
                    }
                }
                catch (Exception ex)
                {
                    string message = ex.Message + Environment.NewLine;
                    if (ex.InnerException != null)
                        message += ex.InnerException.Message;
                    MessageBox.Show(message);
                }
            }
        }
    }
}
