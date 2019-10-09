using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01352022_bonus_assignment
{
    public partial class bonus_coordinate_assignment_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ensure that the quadrant detemination is not run when the page is initially loaded
            if (Page.IsPostBack)
            {
                //Revalidate the code on the server side
                Page.Validate();
                //If the validation is successful, proceed with the quadrant determination
                if (Page.IsValid)
                {
                    //Set a string to store the message for outputting the quadrant where the coordinates are located
                    string Coordinate_Quadrant_Location_Message = "Your coordinate is located in Quadrant ";
                    //collect the inputted x value as an integer
                    int Coordinate_X_Value_Input = Convert.ToInt32(coordinate_x_value_input.Text);
                    //collect the inputted y value as an integer
                    int Coordinate_Y_Value_Input = Convert.ToInt32(coordinate_y_value_input.Text);
                    //determine which quadrant the inputted coordinates are located in, starting with quadrants 1 and 2
                    if (Coordinate_X_Value_Input > 0 )
                    {
                        //determine which quadrant it is based on the Y value
                        if (Coordinate_Y_Value_Input > 0 )
                        {
                            coordinate_quadrant_location_box.InnerHtml = Coordinate_Quadrant_Location_Message + "I";
                        }
                        else
                        {
                            coordinate_quadrant_location_box.InnerHtml = Coordinate_Quadrant_Location_Message + "II";
                        }
                    }
                    //if x is negative, determine if it's in quadrant III or IV based on its Y value
                    else
                    {
                        if (Coordinate_Y_Value_Input > 0 )
                        {
                            coordinate_quadrant_location_box.InnerHtml = Coordinate_Quadrant_Location_Message + "IV";
                        }
                        else
                        {
                            coordinate_quadrant_location_box.InnerHtml = Coordinate_Quadrant_Location_Message + "III";
                        }
                    }
                }
            }

        }
    }
}