using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Author : Meer Zaheen Nazmul
 * Student # : 300522487
 * Date : August, 5th, 2016
 * Description : Main program for BMI Calculator App
 * Version : 0.0.5 : Final Commit - Updated UI
 */
namespace BodyMassIndex
{
    /**
    * <summary>
    * This class is the "driver" class for our program
    * </summary>
    * 
    * @class Program
    */
    public partial class BodyMassIndexForm : Form
    {

        public BodyMassIndexForm()
        {
            InitializeComponent();
        }
        /**
         * <summary>
         * This eventhandler calculate the BMI and display on the textboxes
         * </summary>
         * 
         * @method CalculateButton_Click
         * @param {object} sender
         * @param {EventArgs} e
         */

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

                        // condition to set progress bar value
                        if (((bMI / 30) * 100) > 100)
                        {
                            progressBar1.Value = 100;
                        }
                        else
                        {
                            progressBar1.Value = ((int)((bMI / 30) * 100));
                        }

                        //determine BMI
                        if (bMI < 18.5)
                        {
                            MessageBox.Show("Underweight < 18.5");
                            progressBar1.ForeColor = Color.Yellow;
                        }
                        else if (bMI >= 18.5 && bMI <= 24.9)
                        {
                            MessageBox.Show("Normal weight = 18.5~24.9 ");
                            progressBar1.ForeColor = Color.Green;
                        }
                        else if (bMI > 25 && bMI <= 29.9)
                        {
                            MessageBox.Show("Overweight = 25~29.9");
                            progressBar1.ForeColor = Color.DarkGreen;
                        }
                        else if (bMI >= 30)
                        {
                            MessageBox.Show("Obesity >= 30");
                            progressBar1.ForeColor = Color.Red;
                        }

                    }
                    //calculates the BMI for Imperial
                    else if (ImperialRadioButton.Checked == true)
                    {
                        //algorithm
                        bMI = (weight * 4.88) / ((height) * (height));
                        BMITextBox.Text = Convert.ToString(bMI);

                        // condition to set progress bar value
                        if (((bMI / 30) * 100) > 100)
                        {
                            progressBar1.Value = 100;
                        }
                        else
                        {
                            progressBar1.Value = ((int)((bMI / 30) * 100));
                        }

                        //detarmine BMI
                        if (bMI < 18.5)
                        {
                            MessageBox.Show("Underweight < 18.5");
                            progressBar1.ForeColor = Color.Yellow;
                        }
                        else if (bMI >= 18.5 && bMI <= 24.9)
                        {
                            MessageBox.Show("Normal weight = 18.5~24.9 ");
                            progressBar1.ForeColor = Color.Green;
                        }
                        else if (bMI > 25 && bMI <= 29.9)
                        {
                            MessageBox.Show("Overweight = 25~29.9");
                            progressBar1.ForeColor = Color.DarkGreen;
                        }
                        else if (bMI >= 30)
                        {
                            MessageBox.Show("Obesity >= 30");
                            progressBar1.ForeColor = Color.Red;
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
        /**
        * <summary>
        * This eventhandler clears the content of the form when clicked
        * </summary>
        * 
        * @method ClearButton_Click
        * @param {object} sender
        * @param {EventArgs} e
        */
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //clear all
            HeightTextBox.Text = "";
            WeightTextBox.Text = "";

            BMITextBox.Text = "";

            progressBar1.Value = 0;


            //enable all the textbox
            HeightTextBox.Enabled = true;
            WeightTextBox.Enabled = true;

        }
        /**
         * <summary>
         * This key press eventhandler set a restriction on input height value
         * </summary>
         * 
         * @method HeightTextBox_KeyPress
         * @param {object} sender
         * @param {KeyPressEventArgs} e
         */
        private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
        /**
         * <summary>
         * This key press eventhandler set a restriction on input height value
         * </summary>
         * 
         * @method HeightTextBox_KeyPress
         * @param {object} sender
         * @param {KeyPressEventArgs} e
         */
        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void BodyMassIndexForm_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}