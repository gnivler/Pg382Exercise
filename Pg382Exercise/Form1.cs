using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pg382Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        Random random = new Random();
        Deck deck1, deck2;

        private void resetDeck2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void moveToDeck1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                if (deck2.Count > 0)
                {
                    deck1.Add(deck2.Deal(listBox2.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void resetDeck1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void shuffleDeck1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffleDeck2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void moveToDeck2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                if (deck1.Count > 0)
                {
                    deck2.Add(deck1.Deal(listBox1.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void RedrawDeck(int deck)
        {
            if (deck == 1)
            {
                listBox1.Items.Clear();
                foreach (var card in deck1.GetCardNames())
                {
                    listBox1.Items.Add(card);
                }
                label1.Text = $"Deck #1 ({deck1.Count} cards)";
            }
            if (deck == 2)
            {
                listBox2.Items.Clear();
                foreach (var card in deck2.GetCardNames())
                {
                    listBox2.Items.Add(card);
                }
                label2.Text = $"Deck #2 ({deck2.Count} cards)";
            }
        }

        private void ResetDeck(int deck)
        {
            if (deck == 1)
            {
                List<Card> initialCards = new List<Card>();
                int numberOfCards = random.Next(1, 11);
                for (int i = 1; i <= numberOfCards; i++)
                {
                    Card newCard = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
                    bool exists = false;
                    foreach (var card in initialCards)
                    {
                        if (card.Name == newCard.Name)
                        {
                            exists = true;
                            i--;
                        }
                    }
                    if (!exists)
                    {
                        initialCards.Add(newCard);
                    }
                }
                deck1 = new Deck(initialCards);
                deck1.Sort();
            }
            if (deck == 2)
            {
                deck2 = new Deck();
            }
        }
    }
}