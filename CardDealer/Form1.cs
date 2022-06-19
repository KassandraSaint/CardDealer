using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardDealer
{
    public partial class Form1 : Form
    {
        // Creating dictionary deck to hold all cards
        private Dictionary<string, int> deck = new Dictionary<string, int>()
        {
            // Spades
            {"Ace of Spades",1}, {"2 of Spades",2}, {"3 of Spades",3},
            {"4 of Spades",4}, {"5 of Spades",5}, {"6 of Spades",6},
            {"7 of Spades",7}, {"8 of Spades",8}, {"9 of Spades",9},
            {"10 of Spades",10}, {"Jack of Spades",10}, {"Queen of Spades",10}, {"King of Spades",10},

            // Hearts
            {"Ace of Hearts",1}, {"2 of Hearts",2}, {"3 of Hearts",3},
            {"4 of Hearts",4}, {"5 of Hearts",5}, {"6 of Hearts",6},
            {"7 of Hearts",7}, {"8 of Hearts",8}, {"9 of Hearts",9},
            {"10 of Hearts",10}, {"Jack of Hearts",10}, {"Queen of Hearts",10}, {"King of Hearts",10},

            // Clubs
            {"Ace of Clubs",1}, {"2 of Clubs",2}, {"3 of Clubs",3},
            {"4 of Clubs",4}, {"5 of Clubs",5}, {"6 of Clubs",6},
            {"7 of Clubs",7}, {"8 of Clubs",8}, {"9 of Clubs",9},
            {"10 of Clubs",10}, {"Jack of Clubs",10}, {"Queen of Clubs",10}, {"King of Clubs",10},

            // Diamonds
            {"Ace of Diamonds",1}, {"2 of Diamonds",2}, {"3 of Diamonds",3},
            {"4 of Diamonds",4}, {"5 of Diamonds",5}, {"6 of Diamonds",6},
            {"7 of Diamonds",7}, {"8 of Diamonds",8}, {"9 of Diamonds",9},
            {"10 of Diamonds",10}, {"Jack of Diamonds",10}, {"Queen of Diamonds",10}, {"King of Diamonds",10}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Updating number of cards in the deck
            cardsLeftLabel.Text = deck.Count.ToString();
        }

        private void dealBtn_Click(object sender, EventArgs e)
        {
            // Initializing some variables to hold number of cards to deal and dealt
            int toDeal = 0;
            int cardsVal = 0;
            // Initializing Random Object
            Random rand = new Random();

            // Clearing content of a List Box
            dealtCardsBox.Items.Clear();

            // Clearing value of cards on hand
            valueLabel.Text = "";

            // Checking if user entered right input for cards to deal
            if (int.TryParse(numCardsBox.Text, out toDeal))
            {
                // Checking of entered number is greater than 0 but less than # of cards in a deck
                if (toDeal > 0 && toDeal <= deck.Count)
                {
                    // Dealing card randomly
                    for (int count = 0; count < toDeal; count++)
                    {
                        // Get random number to select a card
                        int randNum = rand.Next(deck.Count);

                        // Getting a card at a random position and storing in the card variable
                        var card = deck.ElementAt(randNum);
                        // Displaying the picked card in the List Box
                        dealtCardsBox.Items.Add(card.Key);

                        // Updating and displaying value of cards on hand
                        cardsVal += card.Value;
                        valueLabel.Text = cardsVal.ToString();

                        // Removing picked card from the deck
                        deck.Remove(card.Key);
                        // Updating number of card in a deck
                        cardsLeftLabel.Text = deck.Count.ToString();
                    }
                }
                else
                {
                    // If deck has no more cards showing the message
                    if (deck.Count == 0)
                    {
                        MessageBox.Show("The deck is empty!");
                    }
                    else
                    {
                        // Showing a message if user entered a number which is out of the range of deck cards
                        MessageBox.Show("Enter a number in the range of 1 through " + deck.Count.ToString());
                    }
                }
            }
            else
            {
                // Showing a message if user's input was invalid
                MessageBox.Show("Enter an integer!");
            }
        }
    }
}
