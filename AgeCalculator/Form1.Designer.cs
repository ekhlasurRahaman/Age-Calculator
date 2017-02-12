namespace AgeCalculator
{
    partial class AgeCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgeCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TodayDateBox = new System.Windows.Forms.ComboBox();
            this.TodayMonthBox = new System.Windows.Forms.ComboBox();
            this.TodayYearBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.YourYearBox = new System.Windows.Forms.ComboBox();
            this.YourMonthBox = new System.Windows.Forms.ComboBox();
            this.YourDateBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Done = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ageYDH = new System.Windows.Forms.TextBox();
            this.ageInDays = new System.Windows.Forms.TextBox();
            this.ageInHours = new System.Windows.Forms.TextBox();
            this.ageInMinutes = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.remainingDays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today\'s Date is :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 62);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(0, 0);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Month :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(405, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Year :";
            // 
            // TodayDateBox
            // 
            this.TodayDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayDateBox.FormattingEnabled = true;
            this.TodayDateBox.Location = new System.Drawing.Point(210, 71);
            this.TodayDateBox.Name = "TodayDateBox";
            this.TodayDateBox.Size = new System.Drawing.Size(151, 28);
            this.TodayDateBox.TabIndex = 7;
            this.TodayDateBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkDate);
            this.TodayDateBox.Leave += new System.EventHandler(this.emptyCheck);
            this.TodayDateBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpdateDate);
            // 
            // TodayMonthBox
            // 
            this.TodayMonthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayMonthBox.FormattingEnabled = true;
            this.TodayMonthBox.Location = new System.Drawing.Point(12, 71);
            this.TodayMonthBox.Name = "TodayMonthBox";
            this.TodayMonthBox.Size = new System.Drawing.Size(151, 28);
            this.TodayMonthBox.TabIndex = 8;
            this.TodayMonthBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkMonth);
            this.TodayMonthBox.Leave += new System.EventHandler(this.emptyCheck);
            // 
            // TodayYearBox
            // 
            this.TodayYearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayYearBox.FormattingEnabled = true;
            this.TodayYearBox.Location = new System.Drawing.Point(409, 71);
            this.TodayYearBox.Name = "TodayYearBox";
            this.TodayYearBox.Size = new System.Drawing.Size(151, 28);
            this.TodayYearBox.TabIndex = 9;
            this.TodayYearBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkYear);
            this.TodayYearBox.Leave += new System.EventHandler(this.emptyCheck);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Your Date of Birth :";
            // 
            // YourYearBox
            // 
            this.YourYearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourYearBox.FormattingEnabled = true;
            this.YourYearBox.Location = new System.Drawing.Point(409, 192);
            this.YourYearBox.Name = "YourYearBox";
            this.YourYearBox.Size = new System.Drawing.Size(151, 28);
            this.YourYearBox.TabIndex = 16;
            this.YourYearBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkYear);
            this.YourYearBox.Leave += new System.EventHandler(this.emptyCheck);
            // 
            // YourMonthBox
            // 
            this.YourMonthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourMonthBox.FormattingEnabled = true;
            this.YourMonthBox.Location = new System.Drawing.Point(12, 192);
            this.YourMonthBox.Name = "YourMonthBox";
            this.YourMonthBox.Size = new System.Drawing.Size(151, 28);
            this.YourMonthBox.TabIndex = 15;
            this.YourMonthBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkMonth);
            this.YourMonthBox.Leave += new System.EventHandler(this.emptyCheck);
            // 
            // YourDateBox
            // 
            this.YourDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourDateBox.FormattingEnabled = true;
            this.YourDateBox.Location = new System.Drawing.Point(210, 192);
            this.YourDateBox.Name = "YourDateBox";
            this.YourDateBox.Size = new System.Drawing.Size(151, 28);
            this.YourDateBox.TabIndex = 14;
            this.YourDateBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkDate);
            this.YourDateBox.Leave += new System.EventHandler(this.emptyCheck);
            this.YourDateBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpdateDate);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(405, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Year :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Month :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(209, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Date :";
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.Color.LightBlue;
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.ForeColor = System.Drawing.Color.Black;
            this.Done.Location = new System.Drawing.Point(9, 246);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(270, 39);
            this.Done.TabIndex = 17;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.ageCalculate);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(290, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(270, 39);
            this.button2.TabIndex = 18;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Form1_Load);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(-1, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 24);
            this.label9.TabIndex = 19;
            this.label9.Text = "Your Age is ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(-1, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "Your Age in Days";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-1, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "Your Age in Hours";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-1, 438);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(200, 24);
            this.label12.TabIndex = 22;
            this.label12.Text = "Your Age in Minutes";
            // 
            // ageYDH
            // 
            this.ageYDH.BackColor = System.Drawing.Color.Lavender;
            this.ageYDH.Location = new System.Drawing.Point(227, 317);
            this.ageYDH.Multiline = true;
            this.ageYDH.Name = "ageYDH";
            this.ageYDH.ReadOnly = true;
            this.ageYDH.Size = new System.Drawing.Size(333, 24);
            this.ageYDH.TabIndex = 23;
            this.ageYDH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ageInDays
            // 
            this.ageInDays.BackColor = System.Drawing.Color.Lavender;
            this.ageInDays.Location = new System.Drawing.Point(227, 358);
            this.ageInDays.Multiline = true;
            this.ageInDays.Name = "ageInDays";
            this.ageInDays.ReadOnly = true;
            this.ageInDays.Size = new System.Drawing.Size(333, 24);
            this.ageInDays.TabIndex = 24;
            this.ageInDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ageInHours
            // 
            this.ageInHours.BackColor = System.Drawing.Color.Lavender;
            this.ageInHours.Location = new System.Drawing.Point(227, 398);
            this.ageInHours.Multiline = true;
            this.ageInHours.Name = "ageInHours";
            this.ageInHours.ReadOnly = true;
            this.ageInHours.Size = new System.Drawing.Size(333, 24);
            this.ageInHours.TabIndex = 25;
            this.ageInHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ageInMinutes
            // 
            this.ageInMinutes.BackColor = System.Drawing.Color.Lavender;
            this.ageInMinutes.Location = new System.Drawing.Point(227, 438);
            this.ageInMinutes.Multiline = true;
            this.ageInMinutes.Name = "ageInMinutes";
            this.ageInMinutes.ReadOnly = true;
            this.ageInMinutes.Size = new System.Drawing.Size(333, 24);
            this.ageInMinutes.TabIndex = 26;
            this.ageInMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.progressBar.Location = new System.Drawing.Point(3, 482);
            this.progressBar.Maximum = 365;
            this.progressBar.Name = "progressBar";
            this.progressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar.Size = new System.Drawing.Size(557, 33);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 27;
            // 
            // remainingDays
            // 
            this.remainingDays.BackColor = System.Drawing.Color.Lavender;
            this.remainingDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingDays.Location = new System.Drawing.Point(104, 528);
            this.remainingDays.Margin = new System.Windows.Forms.Padding(0);
            this.remainingDays.Name = "remainingDays";
            this.remainingDays.ReadOnly = true;
            this.remainingDays.Size = new System.Drawing.Size(352, 24);
            this.remainingDays.TabIndex = 28;
            this.remainingDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AgeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 560);
            this.Controls.Add(this.remainingDays);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ageInMinutes);
            this.Controls.Add(this.ageInHours);
            this.Controls.Add(this.ageInDays);
            this.Controls.Add(this.ageYDH);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.YourYearBox);
            this.Controls.Add(this.YourMonthBox);
            this.Controls.Add(this.YourDateBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TodayYearBox);
            this.Controls.Add(this.TodayMonthBox);
            this.Controls.Add(this.TodayDateBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgeCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Age Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TodayDateBox;
        private System.Windows.Forms.ComboBox TodayMonthBox;
        private System.Windows.Forms.ComboBox TodayYearBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox YourYearBox;
        private System.Windows.Forms.ComboBox YourMonthBox;
        private System.Windows.Forms.ComboBox YourDateBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ageYDH;
        private System.Windows.Forms.TextBox ageInDays;
        private System.Windows.Forms.TextBox ageInHours;
        private System.Windows.Forms.TextBox ageInMinutes;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox remainingDays;
    }
}

