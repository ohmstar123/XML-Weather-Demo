﻿namespace XMLWeather
{
    partial class ForecastScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.forecastLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.min1 = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.max1 = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.min2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.max2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.date3 = new System.Windows.Forms.Label();
            this.min3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.max3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.condition1 = new System.Windows.Forms.Label();
            this.condition2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.condition3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.forecastLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(410, 546);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(380, 42);
            this.forecastLabel.TabIndex = 62;
            this.forecastLabel.Text = "3 Day Report";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.todayLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(12, 546);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(380, 42);
            this.todayLabel.TabIndex = 61;
            this.todayLabel.Text = "Today";
            this.todayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.todayLabel.Click += new System.EventHandler(this.todayLabel_Click);
            // 
            // min1
            // 
            this.min1.BackColor = System.Drawing.Color.Transparent;
            this.min1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min1.ForeColor = System.Drawing.Color.White;
            this.min1.Location = new System.Drawing.Point(26, 264);
            this.min1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min1.Name = "min1";
            this.min1.Size = new System.Drawing.Size(160, 25);
            this.min1.TabIndex = 48;
            this.min1.Text = "Min";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(26, 296);
            this.minLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(133, 20);
            this.minLabel.TabIndex = 46;
            this.minLabel.Text = " Min Temperature";
            // 
            // max1
            // 
            this.max1.BackColor = System.Drawing.Color.Transparent;
            this.max1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max1.ForeColor = System.Drawing.Color.White;
            this.max1.Location = new System.Drawing.Point(26, 166);
            this.max1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max1.Name = "max1";
            this.max1.Size = new System.Drawing.Size(160, 25);
            this.max1.TabIndex = 45;
            this.max1.Text = "max";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(26, 201);
            this.maxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(133, 20);
            this.maxLabel.TabIndex = 44;
            this.maxLabel.Text = "Max Temperature";
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.Color.White;
            this.date1.Location = new System.Drawing.Point(26, 103);
            this.date1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(57, 25);
            this.date1.TabIndex = 64;
            this.date1.Text = "Date";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.ForeColor = System.Drawing.Color.White;
            this.date2.Location = new System.Drawing.Point(302, 103);
            this.date2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(57, 25);
            this.date2.TabIndex = 69;
            this.date2.Text = "Date";
            // 
            // min2
            // 
            this.min2.BackColor = System.Drawing.Color.Transparent;
            this.min2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min2.ForeColor = System.Drawing.Color.White;
            this.min2.Location = new System.Drawing.Point(302, 264);
            this.min2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min2.Name = "min2";
            this.min2.Size = new System.Drawing.Size(160, 25);
            this.min2.TabIndex = 68;
            this.min2.Text = "Min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(302, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = " Min Temperature";
            // 
            // max2
            // 
            this.max2.BackColor = System.Drawing.Color.Transparent;
            this.max2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max2.ForeColor = System.Drawing.Color.White;
            this.max2.Location = new System.Drawing.Point(302, 166);
            this.max2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max2.Name = "max2";
            this.max2.Size = new System.Drawing.Size(160, 25);
            this.max2.TabIndex = 66;
            this.max2.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(302, 201);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 20);
            this.label7.TabIndex = 65;
            this.label7.Text = "Max Temperature";
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(805, 57);
            this.titleLabel.TabIndex = 70;
            this.titleLabel.Text = "Stratford Weather";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date3
            // 
            this.date3.AutoSize = true;
            this.date3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date3.ForeColor = System.Drawing.Color.White;
            this.date3.Location = new System.Drawing.Point(577, 103);
            this.date3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(57, 25);
            this.date3.TabIndex = 75;
            this.date3.Text = "Date";
            // 
            // min3
            // 
            this.min3.BackColor = System.Drawing.Color.Transparent;
            this.min3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min3.ForeColor = System.Drawing.Color.White;
            this.min3.Location = new System.Drawing.Point(577, 264);
            this.min3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.min3.Name = "min3";
            this.min3.Size = new System.Drawing.Size(160, 25);
            this.min3.TabIndex = 74;
            this.min3.Text = "Min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(577, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = " Min Temperature";
            // 
            // max3
            // 
            this.max3.BackColor = System.Drawing.Color.Transparent;
            this.max3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max3.ForeColor = System.Drawing.Color.White;
            this.max3.Location = new System.Drawing.Point(577, 166);
            this.max3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.max3.Name = "max3";
            this.max3.Size = new System.Drawing.Size(160, 25);
            this.max3.TabIndex = 72;
            this.max3.Text = "Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(577, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Max Temperature";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(805, 10);
            this.label8.TabIndex = 78;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(805, 10);
            this.label9.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(525, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 447);
            this.label10.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(249, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 447);
            this.label11.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 418);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 82;
            this.label1.Text = "Condition";
            // 
            // condition1
            // 
            this.condition1.BackColor = System.Drawing.Color.Transparent;
            this.condition1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition1.ForeColor = System.Drawing.Color.White;
            this.condition1.Location = new System.Drawing.Point(26, 362);
            this.condition1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.condition1.Name = "condition1";
            this.condition1.Size = new System.Drawing.Size(160, 55);
            this.condition1.TabIndex = 83;
            this.condition1.Text = "cool";
            // 
            // condition2
            // 
            this.condition2.BackColor = System.Drawing.Color.Transparent;
            this.condition2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition2.ForeColor = System.Drawing.Color.White;
            this.condition2.Location = new System.Drawing.Point(302, 362);
            this.condition2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.condition2.Name = "condition2";
            this.condition2.Size = new System.Drawing.Size(160, 55);
            this.condition2.TabIndex = 85;
            this.condition2.Text = "cool";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(302, 418);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 84;
            this.label5.Text = "Condition";
            // 
            // condition3
            // 
            this.condition3.BackColor = System.Drawing.Color.Transparent;
            this.condition3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.condition3.ForeColor = System.Drawing.Color.White;
            this.condition3.Location = new System.Drawing.Point(577, 362);
            this.condition3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.condition3.Name = "condition3";
            this.condition3.Size = new System.Drawing.Size(160, 55);
            this.condition3.TabIndex = 87;
            this.condition3.Text = "cool";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(577, 418);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 20);
            this.label13.TabIndex = 86;
            this.label13.Text = "Condition";
            // 
            // ForecastScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.condition3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.condition2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.condition1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.min3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.max3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.min2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.max2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.min1);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.max1);
            this.Controls.Add(this.maxLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForecastScreen";
            this.Size = new System.Drawing.Size(805, 615);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label min1;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label max1;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.Label min2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label max2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label date3;
        private System.Windows.Forms.Label min3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label max3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label condition1;
        private System.Windows.Forms.Label condition2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label condition3;
        private System.Windows.Forms.Label label13;
    }
}
