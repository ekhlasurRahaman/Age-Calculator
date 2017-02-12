using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class AgeCalculator : Form
    {
        public AgeCalculator()
        {
            InitializeComponent();
        }
        private int YEARS;
        private int MONTHS;
        private int DAYS;

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            int dd = now.Day;
            int mm = now.Month;
            int yyyy = now.Year;

            //Today's Date Initialize
            TodayDateBox.Text = dd.ToString();
            TodayMonthBox.Text = mm.ToString();
            TodayYearBox.Text = yyyy.ToString();

            monthInitialize(TodayMonthBox);
            dateInitialize(TodayDateBox, mm);
            yearInitialize(TodayYearBox);

            //Your Date of Birth Initialize

            YourDateBox.Text = 1.ToString();
            YourMonthBox.Text = 1.ToString();
            YourYearBox.Text = 1900.ToString();

            monthInitialize(YourMonthBox);
            dateInitialize(YourDateBox, mm);
            yearInitialize(YourYearBox);

            ageYDH.Text = "";
            ageInDays.Text = "";
            ageInHours.Text = "";
            ageInMinutes.Text="";
            progressBar.Value = 0;
            remainingDays.Text = "";

        }

        private void dateInitialize(ComboBox dateBox,int month)
        {
            dateBox.Items.Clear();
            if (month == 2)
            {
                for (int i = 0; i < 28; i++)
                {
                    dateBox.Items.Insert(i, i + 1);
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                for (int i = 0; i < 30; i++)
                {
                    dateBox.Items.Insert(i, i + 1);
                }
            }
            else
            {
                for (int i = 0; i < 31; i++)
                {
                    dateBox.Items.Insert(i, i + 1);
                }
            }
        }

        private void monthInitialize(ComboBox monthBox)
        {
            for (int i = 0; i < 12; i++)
            {
                monthBox.Items.Insert(i, i + 1);
                //YourMonthBox.Items.Insert(i, i + 1);
            }
        }

        private void yearInitialize(ComboBox yearBox)
        {
            int j=0;
            for (int i = 1900; i < 2101; i++)
            {
                yearBox.Items.Insert(j, i + 1);
                //YourMonthBox.Items.Insert(j, i + 1);
                j = j + 1;
            }
        }
        //--------------------------------------------------+

        private void checkDate(object sender, KeyEventArgs e)
        {
            int result;
            int numOfDay = 0;
            string MonthBoxText;
            ComboBox dateBox = (ComboBox)sender;
            string dateBoxName = dateBox.Name;
            if (dateBoxName == "TodayDateBox")
            {
                MonthBoxText = TodayMonthBox.Text;
            }
            else
            {
                MonthBoxText = YourMonthBox.Text;
            }
            int numOfMonth = int.Parse(MonthBoxText);
            if (MonthBoxText != "")
            {
                if (numOfMonth == 2)
                {
                    numOfDay = 28;
                }
                else if (numOfMonth == 4 || numOfMonth == 6 || numOfMonth == 9 || numOfMonth == 11)
                {
                    numOfDay = 30;
                }
                else
                {
                    numOfDay = 31;
                }
            }else
            {
                MessageBox.Show("Month Cann't be Empty", "Age Calculator",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string DateBoxText = dateBox.Text;//TodayDateBox.Text;
            
            if (int.TryParse(DateBoxText, out result))
            {
                if (int.Parse(DateBoxText) <= numOfDay && int.Parse(DateBoxText) > 0)
                {
                    return;
                }
                else
                {
                    dateBox.Text = "";
                }
            }
            else
            {
                dateBox.Text = "";
            }
        }

        private void checkMonth(object sender, KeyEventArgs e)
        {
            int result;
            ComboBox monthBox = (ComboBox)sender;
            string MonthBoxText = monthBox.Text;
            if (int.TryParse(MonthBoxText, out result))
            {
                if (int.Parse(MonthBoxText) <= 12 && int.Parse(MonthBoxText) > 0)
                {
                    return;
                }
                else
                {
                    monthBox.Text = "";
                }
            }
            else
            {
                monthBox.Text = "";
            }
        }
        
        private void UpdateDate(object sender, MouseEventArgs e)
        {
            string MonthBoxText;
            ComboBox dateBox = (ComboBox)sender;
            string dateBoxName = dateBox.Name;

            if (dateBoxName == "YourDateBox")
            {
                MonthBoxText = YourMonthBox.Text;
            }
            else
            {
                MonthBoxText = TodayMonthBox.Text;
            }
            
            if (MonthBoxText == "")
            {
                //message hare//plz give the month first
            }
            else
            {
                dateBox.Text = "";
                int month = int.Parse(MonthBoxText);
                dateInitialize(dateBox, month);
            }
        }
        //logic problem
        private void checkYear(object sender, KeyEventArgs e)
        {
            int result;
            ComboBox yearBox = (ComboBox)sender;
            string YearBoxText = yearBox.Text;
            
            if (int.TryParse(YearBoxText, out result))
            {
                if (YearBoxText.Length >= 4)
                {
                    int year = int.Parse(YearBoxText);

                    if (year > 1899 && year < 2100)
                    {
                        return;
                    }
                    else
                    {
                        yearBox.Text = "";
                    }
                }            
            }
            else
            {
                yearBox.Text = "";
            }
        }

        private void emptyCheck(object sender, EventArgs e)
        {
            string message;
            ComboBox ddmmyyyy = (ComboBox)sender;
            if (ddmmyyyy.Text == ""  && ddmmyyyy.Name == "TodayDateBox")
            {
                message = "Today's Date Cann't be Empty !";
                messagePrint(message);
                int dd = DateTime.Now.Day;
                ddmmyyyy.Text = dd.ToString();

            }
            else if (ddmmyyyy.Text == ""  && ddmmyyyy.Name == "TodayMonthBox")   
            {
                message = "Today's Month Cann't be Empty !";
                messagePrint(message);
                int mm = DateTime.Now.Month;
                ddmmyyyy.Text = mm.ToString();
            }
            else if (ddmmyyyy.Text == "" && ddmmyyyy.Name == "TodayYearBox")
            {
                message = "Today's Year Cann't be Empty !";
                messagePrint(message);
                int yyyy = DateTime.Now.Year;
                ddmmyyyy.Text = yyyy.ToString();
            }
            else if (ddmmyyyy.Text == "" && ddmmyyyy.Name == "YourDateBox")
            {
                message = "Your Birthday Date Cann't be Empty !";
                messagePrint(message);;
                ddmmyyyy.Text = 1.ToString();

            }
            else if (ddmmyyyy.Text == "" && ddmmyyyy.Name == "YourMonthBox")
            {
                message = "Your Birthday Month Cann't be Empty !";
                messagePrint(message);
                ddmmyyyy.Text = 1.ToString();
            }
            else if (ddmmyyyy.Text == "" && ddmmyyyy.Name == "YourYearBox")
            {
                message = "Your Birthday Year Cann't be Empty !";
                messagePrint(message);
                ddmmyyyy.Text = 1900.ToString();
            }

        }

        private void messagePrint(string message)
        {
            MessageBox.Show(message, "Age Calculator",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ageCalculate(object sender, EventArgs e)
        {
            //Todays Date
            
           int tyear =  int.Parse(TodayYearBox.Text);
           int tmonth = int.Parse(TodayMonthBox.Text);
           int tdate =  int.Parse(TodayDateBox.Text);

           DateTime todaysDate = new DateTime(tyear, tmonth, tdate);

            //Your Date of Birth Initialize
            int year =  int.Parse(YourYearBox.Text);
            int month = int.Parse(YourMonthBox.Text);
            int date =  int.Parse(YourDateBox.Text);
            DateTime yourBirthDate = new DateTime(year, month, date);

            TimeSpan t = todaysDate - yourBirthDate;
            if (todaysDate > yourBirthDate)
            {
                //DateTime myAge  = 
                AgeCaluclation(yourBirthDate, todaysDate);
                double numOfDays = t.TotalDays;
                double numOfHours = t.TotalHours;
                double numOfMinutes = t.TotalMinutes;

                //ageYDH.Text = myAge.Year.ToString() + " Years, " + myAge.Month.ToString() + " Months and " +
                //myAge.Day.ToString() + " Days.";
                ageInDays.Text = numOfDays.ToString() + " days since your birth";
                ageInHours.Text = numOfHours.ToString() + " hours since your birth";
                ageInMinutes.Text = numOfMinutes.ToString() + " minutes since your birth";
                //ageYDH.Text = t.ToString();

                //For Progress Bar
                DateTime upcommingBirthday = new DateTime(year + (YEARS+1), month, date);
                TimeSpan leftDate = upcommingBirthday - yourBirthDate;
                double totalDays = leftDate.TotalDays; ;
                double daysLeft = totalDays - numOfDays;
                
                progressBar.Value = (int)daysLeft;
                if (daysLeft == 0)
                {
                    remainingDays.Text = "Happy Birthday to You!";
                }
                else
                {
                    remainingDays.Text = daysLeft + " Days Left for Your Next Birthday";
                }
            }
            else
            {
                messagePrint("Birthday date must be earlier than current date");
            }
        }

        private void AgeCaluclation(DateTime Bday, DateTime Cday)
        {
            
            if ((Cday.Year - Bday.Year) > 0 ||
               (((Cday.Year - Bday.Year) == 0) &&
               ((Bday.Month < Cday.Month) ||
               ((Bday.Month == Cday.Month) &&
               (Bday.Day <= Cday.Day)))))
            {

                int DaysInBdayMonth = DateTime.DaysInMonth(Bday.Year, Bday.Month);
                int DaysRemain = Cday.Day + (DaysInBdayMonth - Bday.Day);

                if (Cday.Month > Bday.Month)
                {
                    this.YEARS = Cday.Year - Bday.Year;
                    this.MONTHS = Cday.Month - (Bday.Month + 1) + Math.Abs(DaysRemain / DaysInBdayMonth);
                    this.DAYS = (DaysRemain % DaysInBdayMonth + DaysInBdayMonth) % DaysInBdayMonth;
                }
                else if (Cday.Month == Bday.Month)
                {
                    if (Cday.Day >= Bday.Day)
                    {
                        this.YEARS = Cday.Year - Bday.Year;
                        this.MONTHS = 0;
                        this.DAYS = Cday.Day - Bday.Day;
                    }
                    else
                    {
                        this.YEARS = (Cday.Year - 1) - Bday.Year;
                        this.MONTHS = 11;
                        this.DAYS = DateTime.DaysInMonth(Bday.Year, Bday.Month) - (Bday.Day - Cday.Day);

                    }
                }
                else
                {
                    this.YEARS = (Cday.Year - 1) - Bday.Year;
                    this.MONTHS = Cday.Month + (11 - Bday.Month) + Math.Abs(DaysRemain / DaysInBdayMonth);
                    this.DAYS = (DaysRemain % DaysInBdayMonth + DaysInBdayMonth) % DaysInBdayMonth;
                }
                ageYDH.Text = this.YEARS.ToString() + " Years, " + this.MONTHS.ToString() + " Months and " +
                            this.DAYS.ToString() + " Days.";
            }
            else
            {
                //throw new ArgumentException("Birthday date must be earlier than current date");
                messagePrint("Birthday date must be earlier than current date");
            }
            //DateTime myAge = new DateTime(this.YEARS, this.MONTHS, this.DAYS);   
            //return myAge;
        }
    }
}
