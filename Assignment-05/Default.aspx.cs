/*
 * Authors: Asad Ahmed & mohamed Abusultan
 * Date: Nov 20, 2020
 * Description: This program simulates the famous Hi-Lo game. In the game, the user is first asked
 * to provide their name. without providing their name, the player will not proceed to the next 
 * stage. Once the name is provided, the player is prompted to provide a maximum guessing number
 * and after that they will be prompted to guess the random number generated from the maximum
 * guessing number provided by them
 */

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
        //global variables
        public static string player;
        public static int MaxGuessNumber;
        public static int newMax;
        public static int newMin;
        public static int min = 1;
        public static string maxi;
        public static int randomNum;

        /*
         * Method Name: Page_Load
         * params: object sender, EventArgs e
         * Description: This method is called when the page is loaded and any code inside it is
         * executed first before doing rendering the rest of the page
         * return value: void
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            //when the page loads, hide other parts of the page except the name input field
            max.Visible = false;
            userGuesses.Visible = false;
            winPage.Visible = false;
        }

        /*
         * Method Name: submitName_Click
         * params: object sender, EventArgs e
         * Description: This method or event handler is fired when the palyer submits the name.
         * Once clicked and after validation, it hides the name input field and renders the 
         * next page of the game
         * return value: void
         */
        protected void submitName_Click(object sender, EventArgs e)
        {
            //hide the name input form
            intro.Visible = false;
            //grab the name provided by the player
            string playerName = name.Text;
            player = playerName;
            //render the max guessing number input field
            max.Visible = true;
            //addressing the player by their name, direct them on what to do
            welcome.InnerHtml = playerName + ", choose a maximum guessing number.";
            //after submitting their max guess number, clear the input field
            name.Text = "";
        }

        /*
         * Method Name: submitGuess_Click()
         * params: object sender, EventArgs e
         * Description: This method or event handler is fired when the palyer submits the max
         * guessing number
         * Once clicked and after validation, it hides the max  input field and 
         * renders the 
         * next page of the game
         * return value: void
         */
        protected void submitGuess_Click(object sender, EventArgs e)
        {
            //hide the max guessing input field
            max.Visible = false;
            //display the user guessing form
            userGuesses.Visible = true;
            //grab and store the maximum guessing number
            maxi = maxGuess.Text;
            //convert the user input into Int
            MaxGuessNumber = Int32.Parse(maxGuess.Text);
            //set the max and min for the range validator on the form
            ranger.MinimumValue = "1";
            ranger.MaximumValue = maxi;
            //notify the user of their range
            update.InnerHtml = "Your guessing number is between " + min + " and " + MaxGuessNumber;
            //generate the random number 
            Random rndm = new Random();
            int random = rndm.Next(min, MaxGuessNumber);
            randomNum = random;
            //rand.InnerText = random.ToString();

            //clear the input field after submission
            maxGuess.Text = "";
        }


        /*
         * Method Name: makeGuess_Click()
         * params: object sender, EventArgs e
         * Description: This method or event handler is fired when the palyer submits the 
         * guessing number to guess the generated random number
         * Once clicked and after validation, it hides the max  input field and 
         * renders the 
         * next page of the game
         * return value: void
         */
        protected void makeGuess_Click(object sender, EventArgs e)
        {
            //convert the user input into integer
            int userGuess = int.Parse(guesses.Text);
            //if user guess is below the random number
            if(userGuess < randomNum)
            {
                //keep showing them the form for guesses
                userGuesses.Visible = true;
                //set the new minimum
                newMin = userGuess + 1;
                
                //update the user for their new range
                update.InnerHtml = "Your guessing number is between " + newMin + " and " + MaxGuessNumber;
                
            }
            //if user guess is above the random number
            else if(userGuess > randomNum)
            {
                //keep showing them the input form
                userGuesses.Visible = true;
                //set the new max as the user input
                newMax = userGuess - 1;
                //notify them of their new range
                update.InnerHtml = "Your guessing number is between " + newMin + " and " + newMax;
            }
            //if the user wins
            else if(userGuess == randomNum)
            {
                //show them the winning page
                winPage.Visible = true;
                opening.InnerHtml = "";
            }
            //reset the input field
            guesses.Text = "";
        }

        /*
         * Method Name: win_Click()
         * params: object sender, EventArgs e
         * Description: This method or event handler is fired when the palyer wins the game.
         * Once the player wins, the winning page is show and the player is given the chance to
         * play again
         * return value: void
         */
        protected void win_Click(object sender, EventArgs e)
        {
            //show the winning page
            max.Visible = true;
            //reset the newMin and newMax value
            newMin = 1;
            newMax = 0;
        }
    }
}