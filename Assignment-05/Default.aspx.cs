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
        public static string maxi;
        public static int randomNum;
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
            welcome.InnerHtml = playerName + ", choose a maximum guessing number.";
        }

        protected void submitGuess_Click(object sender, EventArgs e)
        {
            max.Visible = false;
            userGuesses.Visible = true;
            maxi = maxGuess.Text;
            MaxGuessNumber = Int32.Parse(maxGuess.Text);
            ranger.MinimumValue = "1";
            ranger.MaximumValue = maxi;
            update.InnerHtml = "Your guessing number is between " + min + " and " + MaxGuessNumber;
            Random rndm = new Random();
            int random = rndm.Next(min, MaxGuessNumber);
            randomNum = random;
            rand.InnerText = random.ToString();
        }

        protected void makeGuess_Click(object sender, EventArgs e)
        {
            int userGuess = int.Parse(guesses.Text);
            if(userGuess < randomNum)
            {
                
                userGuesses.Visible = true;
                //update.InnerText = "try again";
                newMin = userGuess + 1;
                if (newMin > userGuess)
                {
                    update.InnerHtml = "Your allowable range is between " + newMin + " and " + newMax;
                }
                else
                {
                    update.InnerHtml = "Your guessing number is between " + newMin + " and " + MaxGuessNumber;
                }
            }
            else if(userGuess > randomNum)
            {
                userGuesses.Visible = true;
                //update.InnerText = "try again";
                newMax = userGuess - 1;
                update.InnerHtml = "Your guessing number is between " + newMin + " and " + newMax;
            }
            else if(userGuess == randomNum)
            {
                winPage.Visible = true;
            }
            
        }

        protected void win_Click(object sender, EventArgs e)
        {
            max.Visible = true;
        }
    }
}