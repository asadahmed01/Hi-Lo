<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment_05._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>Hi-Lo Game</h1>
    </div>
    
    <div ID="intro" runat="server">
        <h3>Enter Your name to continue</h3>
        <asp:TextBox ID="name" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:RequiredFieldValidator ID="requiredfield" ControlToValidate="name" Text="Name field cannot be BLANK" ForeColor="Red" runat="server" display="Dynamic"/>
        <asp:Button ID="submitName" runat="server" Text="Continue" OnClick="submitName_Click"/>
    </div>
        <h2 id="message" runat="server"></h2>
        
    <div ID="max" runat="server">
        <h3 ID="welcome" runat="server"></h3>
        <asp:TextBox ID="maxGuess" runat="server" CssClass="auto-style2"></asp:TextBox>
        <asp:CompareValidator ID="compare" ControlToValidate="maxGuess" ErrorMessage="guessing number must be an integer and greater than 1" ForeColor="Red" runat="server" display="Dynamic" Operator="GreaterThan" ValueToCompare="1" Type="Integer"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="maxGuess" Text="field cannot be BLANK" ForeColor="Red" runat="server" display="Dynamic"/>
        <asp:Button ID="submitGuess" runat="server" Text="Continue" OnClick="submitGuess_Click"/>
    </div>

    <div id="userGuesses" runat="server">
        <h3 id="update" runat="server"></h3>
        <asp:TextBox ID="guesses" runat="server" CssClass="auto-style2"></asp:TextBox>

        <asp:Button ID="makeGuess" runat="server" Text="Make Guess" OnClick="makeGuess_Click"/>
    </div>
    

</asp:Content>
