using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01352022_bonus_assignment
{
    public partial class bonus_raffle_bundle_assignment_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //make sure that the following does not run when the page is first displayed
            if (Page.IsPostBack)
            {
                //have the server validate the page
                Page.Validate();
                //If the page is valid, then proceed
                if (Page.IsValid)
                {
                    //set a int list to store the different possible ticket bundle increments that can be used
                    List<int> Raffle_Ticket_Bundle_Increments = new List<int>();
                    Raffle_Ticket_Bundle_Increments.Add(1);
                    Raffle_Ticket_Bundle_Increments.Add(2);
                    Raffle_Ticket_Bundle_Increments.Add(3);
                    Raffle_Ticket_Bundle_Increments.Add(5);
                    //set an int to store which increment of tickets to use, and set it on the smallest by default
                    int Raffle_Ticket_Bundle_Increment_Amount = 0;
                    //set an double to store the overall cost of the tickets
                    double Raffle_Ticket_Bundle_Overall_Cost = 0.25;
                    //set an int to track the number of bundle's being purchased
                    int Raffle_Ticket_Number_Of_Bundles = 0;
                    //import the user's validated input of the amount of ticket's they wish to purchase
                    int Raffle_Ticket_Purchase_Amount_Input = Convert.ToInt32(raffle_ticket_purchase_amount_input.Text);
                    //determine and set the correct bundle amount to use
                    if (Raffle_Ticket_Purchase_Amount_Input >= 301)
                    {
                        Raffle_Ticket_Bundle_Increment_Amount = 3;
                    }
                    else if (Raffle_Ticket_Purchase_Amount_Input >= 151)
                    {
                        Raffle_Ticket_Bundle_Increment_Amount = 2;
                    }
                    else if (Raffle_Ticket_Purchase_Amount_Input >= 51)
                    {
                        Raffle_Ticket_Bundle_Increment_Amount = 1;
                    }
                    //set the display box as an empty string, so that if the form is resubmitted, the output text is reset
                    raffle_bundle_purchase_display_box.InnerHtml = "";
                    //begin the for loop that will display the amount of tickets purchased by bundle
                    for (int i = Raffle_Ticket_Bundle_Increments[Raffle_Ticket_Bundle_Increment_Amount]; i<=Raffle_Ticket_Purchase_Amount_Input;i = i + Raffle_Ticket_Bundle_Increments[Raffle_Ticket_Bundle_Increment_Amount])
                    {
                        raffle_bundle_purchase_display_box.InnerHtml += "You recieved a bundle of " + Raffle_Ticket_Bundle_Increments[Raffle_Ticket_Bundle_Increment_Amount] + "! That's " + i + " ticket(s)!<br>";
                        //increment the bundle count
                        Raffle_Ticket_Number_Of_Bundles++;
                    }
                    //set a condition for where the the increments don't divide evenly into the amount of tickets purchased
                    if ((Raffle_Ticket_Purchase_Amount_Input % Raffle_Ticket_Bundle_Increments[Raffle_Ticket_Bundle_Increment_Amount]) != 0)
                    {
                        raffle_bundle_purchase_display_box.InnerHtml += "Your leftover is " + ((Raffle_Ticket_Purchase_Amount_Input) - (Raffle_Ticket_Number_Of_Bundles * Raffle_Ticket_Bundle_Increments[Raffle_Ticket_Bundle_Increment_Amount])) + " ticket(s). That's " + Raffle_Ticket_Purchase_Amount_Input + " ticket(s)!<br>";
                    }
                    //display the overall amount of tickets and the price of all the tickets.
                    raffle_bundle_purchase_display_box.InnerHtml += "<br> Your total ticket(s) is " + Raffle_Ticket_Purchase_Amount_Input + " and your cost is $" + Math.Round((Raffle_Ticket_Bundle_Overall_Cost * Raffle_Ticket_Purchase_Amount_Input), 2) + " CAD";

                }
            }
        }
    }
}