<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bonus_coordinate_assignment_1.aspx.cs" Inherits="n01352022_bonus_assignment.bonus_coordinate_assignment_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bonus Assignment 1: Coordinate</title>
</head>
<body>
    <header>
        <h1>Cartesian Coordinate Quadrant Calculator</h1>
    </header>
    <form id="cartesian_coordinate_quadrant_determination_form" runat="server">
        <main>
            <div class="user_coordinate_input_section">
                <section>
                    <h2>Coordinate inputs</h2>
                    <label for="coordinate_x_value_input">Please enter an non-zero whole x value:</label>
                    <div>
                        <%-- Gather the x input --%>
                        <asp:TextBox runat="server" ID="coordinate_x_value_input" placeholder="enter your x value"></asp:TextBox>
                        <%-- Ensure the input box isn't left blank --%>
                        <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="coordinate_x_value_input" Display="Dynamic" ErrorMessage="Please enter a x value"></asp:RequiredFieldValidator>
                        <%-- Ensure that the value inputted is an integer that is not zero --%>
                        <asp:CompareValidator runat="server" EnableClientScript="true" ControlToValidate="coordinate_x_value_input" ValueToCompare="0" Type="Integer" Operator="NotEqual" Display="Dynamic" ErrorMessage="Please enter a non-zero whole x number"></asp:CompareValidator>
                    </div>
                </section>
                <section>
                    <label for="coordinate_y_value_input">Please enter a non-zero whole y value:</label>
                    <div>
                        <%-- Do the exact same input gathering and validation as above for the y value --%>
                        <asp:TextBox runat="server" ID="coordinate_y_value_input" placeholder="enter your y value"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="coordinate_y_value_input" Display="Dynamic" ErrorMessage="Please enter a y value"></asp:RequiredFieldValidator>
                        <asp:CompareValidator runat="server" EnableClientScript="true" ControlToValidate="coordinate_y_value_input" ValueToCompare="0" Type="Integer" Operator="NotEqual" Display="Dynamic" ErrorMessage="Please enter a non-zero whole y number"></asp:CompareValidator>
                    </div>
                </section>
            </div>
            <%-- Print the validation summary --%>
            <div class="coordinate_validation_summary">
                <section>
                    <asp:ValidationSummary runat="server" ShowSummary="true" />
                </section>
            </div>
            <%-- Set aside a div to print the coordinate quadrant to. --%>
            <div id="coordinate_quadrant_location_box" runat="server">
                
            </div>
            <%-- Set a button to send the form to determine the quadrant once the inputs are valid. --%>
            <section>
                <div>
                    <asp:Button runat="server" Text="Submit" />
                </div>
            </section>
        </main>
    </form>
</body>
</html>
