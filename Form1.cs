using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrunkManGame
{
    public partial class Form1 : Form
    {
        Card card = new Card(Card.Values52[6], Card.Suits["spades"], 6);
        Timer myTimer = new Timer();
        int counter = 1;

        public Form1()
        {
            InitializeComponent();
            var card = new PictureBox();
            card.BackgroundImage = Properties.Resources._2_of_spades;
            card.Width = 100;
            card.Height = 250;
            card.BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(card);
            myTimer.Interval = 100;
            myTimer.Tick += (object sender, EventArgs e) => { card.Location = new Point(counter++, counter++);}; 
            myTimer.Start();
        }

    }
}
