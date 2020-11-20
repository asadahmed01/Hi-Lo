using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_05
{
    public partial class _Default : Page
    {
        public static string player;
        public static int MaxGuessNumber;
        public static int newMax;
        public static int newMin;
        public static int min = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            max.Visible = false;
            userGuesses.Visible = false;
        }

        protected void submitName_Click(object sender, EventArgs e)
        {
            intro.Visible = false;
            string playerName = name.Text;
            player = playerName;
            max.Visible = true;
            welcome.InnerHtml = playerName + ", Choose a maximum guessing number.";
        }

        protected void submitGuess_Click(object sender, EventArgs e)
        {
            max.Visible = false;
            userGuesses.Visible = true;
            MaxGuessNumber = Int32.Parse(maxGuess.Text);
            update.InnerHtml = "Your guessing number is between " + min + " and " + MaxGuessNumber;
        }

        protected void makeGuess_Click(object sender, EventArgs e)
        {

        }
    }
}