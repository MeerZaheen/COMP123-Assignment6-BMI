namespace BodyMassIndex
{
    partial class BodyMassIndexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Units = new System.Windows.Forms.GroupBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.BMILabel = new System.Windows.Forms.Label();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BMIGroupBox = new System.Windows.Forms.GroupBox();
            this.ObesityLabel = new System.Windows.Forms.Label();
            this.OverweightLabel = new System.Windows.Forms.Label();
            this.NormalLabel = new System.Windows.Forms.Label();
            this.UnderwightLabel = new System.Windows.Forms.Label();
            this.Units.SuspendLayout();
            this.BMIGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UnitsGroupBox
            // 
            this.Units.Controls.Add(this.ImperialRadioButton);
            this.Units.Controls.Add(this.MetricRadioButton);
            this.Units.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Units.Location = new System.Drawing.Point(61, 40);
            this.Units.Margin = new System.Windows.Forms.Padding(2);
            this.Units.Name = "UnitsGroupBox";
            this.Units.Padding = new System.Windows.Forms.Padding(2);
            this.Units.Size = new System.Drawing.Size(167, 59);
            this.Units.TabIndex = 2;
            this.Units.TabStop = false;
            this.Units.Text = "Units";
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(80, 23);
            this.ImperialRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(83, 24);
            this.ImperialRadioButton.TabIndex = 4;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Checked = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(10, 23);
            this.MetricRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(70, 24);
            this.MetricRadioButton.TabIndex = 3;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTextBox.Location = new System.Drawing.Point(121, 161);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(143, 19);
            this.HeightTextBox.TabIndex = 5;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(23, 161);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(95, 20);
            this.HeightLabel.TabIndex = 4;
            this.HeightLabel.Text = "Height (cm):";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(23, 187);
            this.WeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(94, 20);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "Weight (kg):";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightTextBox.Location = new System.Drawing.Point(121, 187);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(143, 19);
            this.WeightTextBox.TabIndex = 6;
            // 
            // BMILabel
            // 
            this.BMILabel.AutoSize = true;
            this.BMILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMILabel.Location = new System.Drawing.Point(23, 246);
            this.BMILabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BMILabel.Name = "BMILabel";
            this.BMILabel.Size = new System.Drawing.Size(42, 20);
            this.BMILabel.TabIndex = 8;
            this.BMILabel.Text = "BMI:";
            // 
            // BMITextBox
            // 
            this.BMITextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BMITextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BMITextBox.Enabled = false;
            this.BMITextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMITextBox.Location = new System.Drawing.Point(121, 246);
            this.BMITextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(143, 19);
            this.BMITextBox.TabIndex = 8;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(27, 418);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(86, 26);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(179, 418);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(85, 26);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BMIGroupBox
            // 
            this.BMIGroupBox.Controls.Add(this.ObesityLabel);
            this.BMIGroupBox.Controls.Add(this.OverweightLabel);
            this.BMIGroupBox.Controls.Add(this.NormalLabel);
            this.BMIGroupBox.Controls.Add(this.UnderwightLabel);
            this.BMIGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIGroupBox.Location = new System.Drawing.Point(85, 296);
            this.BMIGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.BMIGroupBox.Name = "BMIGroupBox";
            this.BMIGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.BMIGroupBox.Size = new System.Drawing.Size(133, 96);
            this.BMIGroupBox.TabIndex = 16;
            this.BMIGroupBox.TabStop = false;
            this.BMIGroupBox.Text = "BMI";
            // 
            // ObesityLabel
            // 
            this.ObesityLabel.AutoSize = true;
            this.ObesityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObesityLabel.Location = new System.Drawing.Point(4, 73);
            this.ObesityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ObesityLabel.Name = "ObesityLabel";
            this.ObesityLabel.Size = new System.Drawing.Size(75, 15);
            this.ObesityLabel.TabIndex = 3;
            this.ObesityLabel.Text = "Obesity>=30";
            // 
            // OverweightLabel
            // 
            this.OverweightLabel.AutoSize = true;
            this.OverweightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverweightLabel.Location = new System.Drawing.Point(4, 55);
            this.OverweightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OverweightLabel.Name = "OverweightLabel";
            this.OverweightLabel.Size = new System.Drawing.Size(129, 15);
            this.OverweightLabel.TabIndex = 2;
            this.OverweightLabel.Text = "Overweight = 25~29.9 ";
            // 
            // NormalLabel
            // 
            this.NormalLabel.AutoSize = true;
            this.NormalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormalLabel.Location = new System.Drawing.Point(4, 36);
            this.NormalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NormalLabel.Name = "NormalLabel";
            this.NormalLabel.Size = new System.Drawing.Size(119, 15);
            this.NormalLabel.TabIndex = 1;
            this.NormalLabel.Text = "Normal = 18.5~24.9 ";
            // 
            // UnderwightLabel
            // 
            this.UnderwightLabel.AutoSize = true;
            this.UnderwightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderwightLabel.Location = new System.Drawing.Point(4, 17);
            this.UnderwightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UnderwightLabel.Name = "UnderwightLabel";
            this.UnderwightLabel.Size = new System.Drawing.Size(121, 15);
            this.UnderwightLabel.TabIndex = 0;
            this.UnderwightLabel.Text = "Underweight = <18.5";
            // 
            // BodyMassIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 452);
            this.Controls.Add(this.BMIGroupBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.BMILabel);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.Units);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BodyMassIndexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Body Mass Index";
            this.Load += new System.EventHandler(this.BodyMassIndexForm_Load);
            this.Units.ResumeLayout(false);
            this.Units.PerformLayout();
            this.BMIGroupBox.ResumeLayout(false);
            this.BMIGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Units;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label BMILabel;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox BMIGroupBox;
        private System.Windows.Forms.Label UnderwightLabel;
        private System.Windows.Forms.Label NormalLabel;
        private System.Windows.Forms.Label OverweightLabel;
        private System.Windows.Forms.Label ObesityLabel;
    }
}

