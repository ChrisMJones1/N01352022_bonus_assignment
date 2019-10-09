<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bonus_raffle_bundle_assignment_3.aspx.cs" Inherits="n01352022_bonus_assignment.bonus_raffle_bundle_assignment_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Raffle Bundle</title>
</head>
<body>
    <header>
        <h1>HTTP Raffle Bundle Sale</h1>
    </header>
    <form id="raffle_bundle_purchasing_form" runat="server">
        <main>
            <div class="ticket_purchasing_amount_section">
                <section>
                    <label for="raffle_ticket_purchase_amount_input">Please enter how many tickets you'd like to purchase</label>
                    <asp:TextBox runat="server" id="raffle_ticket_purchase_amount_input" placeholder="Enter how many raffle tickets"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="raffle_ticket_purchase_amount_input" ErrorMessage="Please enter the amount of tickets you'd like to purchase" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CompareValidator runat="server" EnableClientScript="true" ControlToValidate="raffle_ticket_purchase_amount_input" Type="Integer" ValueToCompare="0" Operator="GreaterThan" ErrorMessage="Enter a valid number greater than 0" Display="Dynamic"></asp:CompareValidator>
                </section>
            </div>
            <div id="raffle_ticket_validation_summary">
                <section>
                    <asp:ValidationSummary runat="server" ShowSummary="true" />
                </section>
            </div>
            <div>
                <asp:Button runat="server" Text="Submit" />
            </div>
            <div runat="server" id="raffle_bundle_purchase_display_box">

            </div>
        </main>
    </form>
</body>
</html>
