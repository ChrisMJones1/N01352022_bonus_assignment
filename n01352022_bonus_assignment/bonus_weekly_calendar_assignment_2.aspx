<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bonus_weekly_calendar_assignment_2.aspx.cs" Inherits="n01352022_bonus_assignment.bonus_weekly_calendar_assignment_2" %>

<!DOCTYPE html>

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
                    <h3>Please select which days of the week you will work/study:</h3>
                    <%-- Have the user select the days of the week they are busy, and set the value as the values for the index location of a list to hold the 7 days --%>
                    <asp:CheckBoxList runat="server" ID="weekly_schedule_busy_days">
                        <asp:ListItem Text="Monday" Value="0"></asp:ListItem>
                        <asp:ListItem Text="Tuesday" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Wednesday" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Thursday" Value="3"></asp:ListItem>
                        <asp:ListItem Text="Friday" Value="4"></asp:ListItem>
                        <asp:ListItem Text="Saturday" Value="5"></asp:ListItem>
                        <asp:ListItem Text="Sunday" Value="6"></asp:ListItem>
                    </asp:CheckBoxList>
                </section>
                <section>
                    <div>
                        <asp:Button runat="server" Text="Submit" />
                    </div>
                </section>
            </div>
            <div runat="server" id="weekly_schedule_display_box">

            </div>
        </main>
        
    </form>
</body>
</html>
