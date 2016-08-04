using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyMassIndex
{
    public partial class BodyMassIndexForm : Form
    {

        public BodyMassIndexForm()
        {
            InitializeComponent();
        }

        //Calculate Button+++++++++++++++++++++++++++++++++++++++++++++
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //declear local variables
            double height, weight, bMI;

            try
            {
                //convert to numbers
                height = Convert.ToDouble(HeightTextBox.Text);
                weight = Convert.ToDouble(WeightTextBox.Text);

                //each textbox can't be empty
                if (HeightTextBox.Text == "" || WeightTextBox.Text == "")
                {
                    MessageBox.Show("All the text box can't be empty!");
                }

                //height or weight can't be negative or zero
                else if (height <= 0 || weight <= 0)
                {
                    MessageBox.Show("Height or Weight can't be negative or zero!");
                    HeightTextBox.Focus();
                    HeightTextBox.SelectAll();
                }
                else if (height > 0 || weight > 0)
                {

                    //when calculated, desable inputed textboxes
                    HeightTextBox.Enabled = false;
                    WeightTextBox.Enabled = false;

                    //calculates the BMI Metric
                    if (MetricRadioButton.Checked == true)
                    {
                        //algorithm
                        bMI = weight / ((height) * (height));
                        BMITextBox.Text = Convert.ToString(bMI);


                        //detarmine BMI
                        if (bMI < 18.5)
                        {
                            MessageBox.Show("Underweight < 18.5");
                        }
                        else if (bMI >= 18.5 && bMI <= 24.9)
                        {
                            MessageBox.Show("Normal weight = 18.5~24.9 ");
                        }
                        else if (bMI > 25 && bMI <= 29.9)
                        {
                            MessageBox.Show("Overweight = 25~29.9");
                        }
                        else if (bMI >= 30)
                        {
                            MessageBox.Show("Obesity >= 30");
                        }

                    }
                    //calculates the BMI for Imperial
                    else if (ImperialRadioButton.Checked == true)
                    {
                        //algorithm
                        bMI = (weight * 4.88) / ((height) * (height));
                        BMITextBox.Text = Convert.ToString(bMI);

                        //detarmine BMI
                        if (bMI < 18.5)
                        {
                            MessageBox.Show("Underweight < 18.5");
                        }
                        else if (bMI >= 18.5 && bMI <= 24.9)
                        {
                            MessageBox.Show("Normal weight = 18.5~24.9 ");
                        }
                        else if (bMI > 25 && bMI <= 29.9)
                        {
                            MessageBox.Show("Overweight = 25~29.9");
                        }
                        else if (bMI >= 30)
                        {
                            MessageBox.Show("Obesity >= 30");
                        }

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You must fill all the forms, and Height, Weight can't be less or equal to 0");
                HeightTextBox.Focus();
                HeightTextBox.SelectAll();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clear all
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";

            BMITextBox.Text = "";


            //enable all the textbox
            HeightTextBox.Enabled = true;
            WeightTextBox.Enabled = true;

        }

        private void BodyMassIndexForm_Load(object sender, EventArgs e)
        {

        }
    }
}
