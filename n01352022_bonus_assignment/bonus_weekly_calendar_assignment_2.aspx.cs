using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01352022_bonus_assignment
{
    public partial class bonus_weekly_calendar_assignment_2 : System.Web.UI.Page
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
                    //Set a list to store the names of the 7 days of the week
                    List<String> Days_Of_The_Week = new List<string>();
                    //set the days of the week to the list
                    Days_Of_The_Week.Add("Monday");
                    Days_Of_The_Week.Add("Tuesday");
                    Days_Of_The_Week.Add("Wednesday");
                    Days_Of_The_Week.Add("Thursday");
                    Days_Of_The_Week.Add("Friday");
                    Days_Of_The_Week.Add("Saturday");
                    Days_Of_The_Week.Add("Sunday");
                    //Set a counter that will track the day of the week when rendering the schedule, with a value 1 because October 1st is a Tuesday, and index[1] is tuesday
                    int Day_Of_The_Week_Tracker = 1;
                    //Set a string to hold the name of the month, so that the schedule can be easily converted to other months as well
                    string Weekly_Schedule_Month_Name = "Oct ";
                    //Set an int to store the number of days in the month for the same reasons as the Month name
                    int Weekly_Schedule_Month_Number_Of_Days = 31;
                    //Set the string message for when it's a busy day
                    string Busy_Day_Message = "! Time to work...<br>";
                    //set the string message for when it's not a busy day
                    string Free_Day_Message = "! Time to have fun!<br>";
                    //set a list of 7 boolean values that correspond to the days of the week the user is busy, with false meaning that the user is not busy that day, and index 0 starting with monday.
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
                    /*
                    Testing to see if foreach loop successfully appended values into schedule list.
                    weekly_schedule_display_box.InnerHtml = "Test of schedule list: ";
                    for (int i = 0; i < Weekly_Schedule_Busy_Days.Count; i++)
                    {
                        weekly_schedule_display_box.InnerHtml += Convert.ToString(Weekly_Schedule_Busy_Days[i]);
                    }
                    */
                    //Set the opening message of the schedule display, this will also reset the schedule display if the user resubmits the page.
                    weekly_schedule_display_box.InnerHtml = "Here is your schedule:<br>";
                    //Begin the loop which will render the schedule
                    for (int i = 1; i <= Weekly_Schedule_Month_Number_Of_Days; i++)
                    {
                        weekly_schedule_display_box.InnerHtml += Weekly_Schedule_Month_Name + i + " is a " + Days_Of_The_Week[Day_Of_The_Week_Tracker];
                        //if the day of the week is a busy day, display the busy message.
                        if (Weekly_Schedule_Busy_Days[Day_Of_The_Week_Tracker] == true)
                        {
                            weekly_schedule_display_box.InnerHtml += Busy_Day_Message;
                        }
                        //If it's not, display the free day message
                        else
                        {
                            weekly_schedule_display_box.InnerHtml += Free_Day_Message;
                        }
                        //increment the day of the week tracker before beginning the next cycle of the loop
                        Day_Of_The_Week_Tracker++;
                        //Once the day of the week tracker increments past sunday (6), reset the counter to monday (0)
                        if (Day_Of_The_Week_Tracker > 6)
                        {
                            Day_Of_The_Week_Tracker = 0;
                        }
                    }
                }
            }
        }
    }
}