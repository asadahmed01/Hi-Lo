<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment_05._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" runat="server" media="screen" href="/Styles.css" />
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@700&display=swap" rel="stylesheet">
    <div>
        <h1 class="opening"> Welcome to the Hi-Lo Game</h1>
    </div>
    
    <div ID="intro" runat="server">
        <h4 class="direction">Enter Your name to continue</h4>
        <asp:TextBox ID="name" runat="server" CssClass="name"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="requiredfield" ControlToValidate="name" Text="Name field cannot be BLANK" ForeColor="Red" runat="server" display="Dynamic"/>
        <asp:Button ID="submitName" runat="server" Text="Continue" OnClick="submitName_Click" CssClass="name-button"/>
    </div>
        <h2 id="message" runat="server"></h2>
        
    <div ID="max" runat="server">
        <h3 ID="welcome" runat="server"></h3>
        <asp:TextBox ID="maxGuess" runat="server" CssClass="name"></asp:TextBox>

        <asp:CompareValidator ID="compare" ControlToValidate="maxGuess" ErrorMessage="guessing number must be an integer and greater than 1" ForeColor="Red" runat="server" display="Dynamic" Operator="GreaterThan" ValueToCompare="1" Type="Integer"/>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="maxGuess" Text="field cannot be BLANK" ForeColor="Red" runat="server" display="Dynamic"/>
        <br />
        <asp:Button ID="submitGuess" runat="server" Text="Continue" OnClick="submitGuess_Click" CssClass="name-button"/>
    </div>

    <div id="userGuesses" runat="server">
        <h3 id="update" runat="server"></h3>
        <p id="rand" runat="server"></p>
        <asp:TextBox ID="guesses" runat="server" CssClass="name"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="guesses" Text="guess field cannot be BLANK" ForeColor="Red" runat="server" display="Dynamic"/>

        

            <asp:RegularExpressionValidator id="RegularExp" 
            ControlToValidate="guesses"
            ValidationExpression="^[0-9]+$"
            Display="Dynamic"
            ErrorMessage="Input must be an integer only"
            ForeColor="red"
            runat="server"/>
           
        <asp:RangeValidator ID="ranger" runat="server" ErrorMessage="Outside allowable range" ControlToValidate="guesses" Display="Dynamic" ForeColor="Red" Type="Integer"></asp:RangeValidator>
        <br />
        <asp:Button ID="makeGuess" runat="server" Text="Make Guess" OnClick="makeGuess_Click" CssClass="name-button"/>
    </div>
    
    <div id="winPage" runat="server">
        <h1>You Won!!!</h1>

        <asp:Button ID="win" runat="server" Text="Play Again" OnClick="win_Click" CssClass="win-button"/>
    </div>

</asp:Content>
