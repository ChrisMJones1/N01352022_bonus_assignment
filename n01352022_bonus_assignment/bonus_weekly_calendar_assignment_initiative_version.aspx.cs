using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01352022_bonus_assignment
{
    public partial class bonus_weekly_calendar_assignment_initiative_version : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ensure that the following doesn't run on the initial load of the webform
            if (Page.IsPostBack)
            {
                //Validate the page on the server side
                Page.Validate();
                //If the page is valid, then proceed
                if (Page.IsValid)
                {
                    //Using the C# DateTime type, the day of the week tracker and List containing the names of the days of the week are no longer needed
                    //Import the year and month inputs into a DateTime format set for the first day of the given month and year for the weekly schedule
                    DateTime Schedule_Date_Input = new DateTime(Convert.ToInt32(weekly_schedule_year_input.Text), Convert.ToInt32(weekly_schedule_month_input.Text), 1);
                    //debug check to check that date was imported correctly
                    //System.Diagnostics.Debug.WriteLine(Schedule_Date_Input);
                    //Set the string message for when it's a busy day
                    string Busy_Day_Message = "! Time to work...<br>";
                    //set the string message for when it's not a busy day
                    string Free_Day_Message = "! Time to have fun!<br>";
                    //set a list of 7 boolean values that correspond to the days of the week the user is busy, with false meaning that the user is not busy that day, and index 0 starting with Sunday to correspond with the DateTime format.
                    List<bool> Weekly_Schedule_Busy_Days = new List<bool>();
                    //run a for loop to set all the days of the week in the list to free by default
                    for (int i = 0; i < 7; i++)
                    {
                        Weekly_Schedule_Busy_Days.Add(false);
                    }
                    //run a foreach to append the user's choices of their busy days to the weekly schedule list
                    foreach (ListItem weekly_schedule_busy_days in weekly_schedule_busy_days.Items)
                    {
                        if (weekly_schedule_busy_days.Selected == true)
                        {
                            Weekly_Schedule_Busy_Days[Convert.ToInt32(weekly_schedule_busy_days.Value)] = true;
                        }
                    }
                    //Set the opening message of the schedule display, this will also reset the schedule display if the user resubmits the page.
                    weekly_schedule_display_box.InnerHtml = "Here is your schedule:<br>";
                    //Set the month to an integer as a length indicator for the while loop
                    int Schedule_Month = (int)Schedule_Date_Input.Month;
                    //Set a while loop using the stored Schedule_Month to indicate when to end the while loop
                    while((int)Schedule_Date_Input.Month == Schedule_Month)
                    {
                        //output date and the day of the week
                        weekly_schedule_display_box.InnerHtml += Schedule_Date_Input.ToString("MMMM dd yyy") + " is a " + Schedule_Date_Input.DayOfWeek;
                        //if the day of the week is a busy day, display the busy message. Wrap the int in rounded brackets to call the DayOfWeek as an int
                        if (Weekly_Schedule_Busy_Days[(int)Schedule_Date_Input.DayOfWeek] == true)
                        {
                            weekly_schedule_display_box.InnerHtml += Busy_Day_Message;
                        }
                        //If it's not, display the free day message
                        else
                        {
                            weekly_schedule_display_box.InnerHtml += Free_Day_Message;
                        }
                        Schedule_Date_Input = Schedule_Date_Input.AddDays(1);
                    }
                }
            }

        }
    }
}