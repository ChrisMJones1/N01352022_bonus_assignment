<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bonus_weekly_calendar_assignment_initiative_version.aspx.cs" Inherits="n01352022_bonus_assignment.bonus_weekly_calendar_assignment_initiative_version" %>

<!DOCTYPE html>
<%-- Copy layout from original weekly calendar, but add input for month and year --%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Weekly Calendar</title>
</head>
<body>
    <header>
        <h1>Weekly Calendar</h1>
    </header>

    <form id="weekly_calendar" runat="server">
        <main>
            <div class="schedule_input_section">
                <section>
                    <h2>Schedule Input</h2>
                    <%-- Ask the user for what month they want the schedule for --%>
                    <label for="weekly_schedule_month_input">Please enter what month (1-12) you wish to create a calendar for:</label>
                    <div>
                        <asp:TextBox runat="server" ID="weekly_schedule_month_input" placeholder="e.g. 1, 10, 4"></asp:TextBox>
                        <%-- Validate that the user doesn't leave this section blank --%>
                        <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="weekly_schedule_month_input" ErrorMessage="Please enter which month you wish schedule" Display="Dynamic"></asp:RequiredFieldValidator>
                        <%-- Validate that the user inputs an integer between 1-12 --%>
                        <asp:RangeValidator runat="server" ControlToValidate="weekly_schedule_month_input" Type="Integer" MinimumValue="1" MaximumValue="12" ErrorMessage="Please enter the month number (1-12)" Display="Dynamic"></asp:RangeValidator>
                    </div>
                    <%-- Do the same as above for inputting the year --%>
                    <label for="weekly_schedule_year_input">Please enter what year (1-9999) you wish to create a calendar for:</label>
                    <div>
                        <asp:TextBox runat="server" ID="weekly_schedule_year_input" placeholder="e.g. 2018"></asp:TextBox>
                        <%-- Validate that the user didn't leave the input blank --%>
                        <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="weekly_schedule_year_input" ErrorMessage="Please enter a year" Display="Dynamic"></asp:RequiredFieldValidator>
                        <%-- Validate that the user inputs an integer that fits into the year range that can be handled by DateTime (1-9999), which will allow for users to create a calendar for a future year as well --%>
                        <asp:RangeValidator runat="server" ControlToValidate="weekly_schedule_year_input" Type="Integer" MinimumValue="1" MaximumValue="9999" ErrorMessage="Please enter the year in number format (1-9999)" Display="Dynamic"></asp:RangeValidator>
                    </div>
                    <h3>Please select which days of the week you will work/study:</h3>
                    <%-- Have the user select the days of the week they are busy, and set the value as the values for the index location of a list to hold the 7 days, changed to match the convention used by DateTime.DayOfWeek --%>
                    <asp:CheckBoxList runat="server" ID="weekly_schedule_busy_days">
                        <asp:ListItem Text="Sunday" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Monday" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Tuesday" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Wednesday" Value="3"></asp:ListItem>
                        <asp:ListItem Text="Thursday" Value="4"></asp:ListItem>
                        <asp:ListItem Text="Friday" Value="5"></asp:ListItem>
                        <asp:ListItem Text="Saturday" Value="6"></asp:ListItem>
                    </asp:CheckBoxList>
                </section>
                <%-- Show a validation summary --%>
                <div class="weekly_calendar_validation_summary">
                    <section>
                        <asp:ValidationSummary runat="server" ShowSummary="true" />
                    </section>
                </div>
                <section>
                    <div>
                        <asp:Button runat="server" Text="Submit" />
                    </div>
                </section>
            </div>
            <%-- Set aside a display area to output the schedule to --%>
            <div runat="server" id="weekly_schedule_display_box">

            </div>
        </main>
        
    </form>
</body>
</html>
