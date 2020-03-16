using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grade6
{
    public partial class Games : UserControl
    {
        public Games()
        {
            InitializeComponent();
        }

        public void Games_Load(object sender, EventArgs e)
        {
            listGames.BackColor = Color.FromArgb(100, Color.FromArgb(103, 83, 187));
            listGames.BringToFront();
            gunaVScrollBar1.BringToFront();
            topTab.BringToFront();
            noGames.BringToFront();
            RefreshGamesForm();
        }

        private void producerConsumer_Click(object sender, EventArgs e)
        {
            gProducerCnsumer1.BringToFront();
        }

        private void foodChain_Click(object sender, EventArgs e)
        {
            gPlayer1.flashPlayer.Movie = Application.StartupPath + @"\\foodchaingame.swf";
            gPlayer1.BringToFront();
        }

        private void gunaVScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            listGames.AutoScrollPosition = new Point(0, gunaVScrollBar1.Value);
            topTab.RefreshImage();
        }

        private void foodwebPanel_Click(object sender, EventArgs e)
        {
            gPlayer1.flashPlayer.Movie = Application.StartupPath + @"\\animaldietgame.swf";
            gPlayer1.BringToFront();
        }

        private void herbivorePanel_Click(object sender, EventArgs e)
        {
            gPlayer1.flashPlayer.Movie = Application.StartupPath + @"\\memoryHerbivores.swf";
            gPlayer1.BringToFront();
        }

        private void omnivorePanel_Click(object sender, EventArgs e)
        {
            gPlayer1.flashPlayer.Movie = Application.StartupPath + @"\\memoryOmnivores.swf";
            gPlayer1.BringToFront();
        }

        private void producerPanel_Click(object sender, EventArgs e)
        {
            gPlayer1.flashPlayer.Movie = Application.StartupPath + @"\\producersconsumersgame.swf";
            gPlayer1.BringToFront();
        }

        private void start1_Click(object sender, EventArgs e)
        {
            foodChain_Click(sender, e);
        }

        private void start1_MouseDown(object sender, MouseEventArgs e)
        {
            start1.BaseColor = Color.FromArgb(72, 170, 123);
            play.BaseColor = Color.FromArgb(85, 198, 144);
        }

        private void start1_MouseUp(object sender, MouseEventArgs e)
        {
            play.BaseColor = Color.FromArgb(72, 170, 123);
            start1.BaseColor = Color.FromArgb(85, 198, 144);
        }

        private void Games_Scroll(object sender, ScrollEventArgs e)
        {
            topTab.RefreshImage();
        }

        private void listGames_LocationChanged(object sender, EventArgs e)
        {
            topTab.RefreshImage();
        }

        public void RefreshGamesForm()
        {
            if (VideoLearn.foodChain == false)
            {
                foodChain.BaseColor = Color.FromArgb(148, 130, 219);
                foodChain.Visible = false;
            }
            else if (VideoLearn.foodChain == true)
            {
                foodChain.Visible = true;
            }
            if (VideoLearn.foodweb == false)
            {
                foodwebPanel.BaseColor = Color.FromArgb(148, 130, 219);
                foodwebPanel.Visible = false;
            }
            else if (VideoLearn.foodweb == true)
            {
                foodwebPanel.Visible = true;
            }
            if (Document.herbivoreAnimals == false)
            {
                herbivorePanel.BaseColor = Color.FromArgb(148, 130, 219);
                herbivorePanel.Visible = false;
            }
            else if (Document.herbivoreAnimals == true)
            {
                herbivorePanel.Visible = true;
            }
            if (Document.carnivoreAnimals == false)
            {
                carnivorePanel.BaseColor = Color.FromArgb(148, 130, 219);
                carnivorePanel.Visible = false;
            }
            else if (Document.carnivoreAnimals == true)
            {
                carnivorePanel.Visible = true;
            }
            if (Document.omnivoreAnimals == false)
            {
                omnivorePanel.BaseColor = Color.FromArgb(148, 130, 219);
                omnivorePanel.Visible = false;
            }
            else if (Document.omnivoreAnimals == true)
            {
                omnivorePanel.Visible = true;
            }
            if (VideoLearn.producer == false)
            {
                producerConsumer.BaseColor = Color.FromArgb(148, 130, 219);
                producerConsumer.Visible = false;
            }
            else if (VideoLearn.producer == true)
            {
                producerConsumer.Visible = true;
            }
            if (VideoLearn.decomposer == false)
            {
                decomposerPanel.BaseColor = Color.FromArgb(148, 130, 219);
                decomposerPanel.Visible = false;
            }
            else if (VideoLearn.decomposer == true)
            {
                decomposerPanel.Visible = true;
            }

            if (foodChain.Visible == false && foodwebPanel.Visible == false && herbivorePanel.Visible == false
                && carnivorePanel.Visible == false && omnivorePanel.Visible == false && producerConsumer.Visible == false
                && decomposerPanel.Visible == false)
            {
                noGames.Visible = true;
                gunaVScrollBar1.Visible = false;
            }
            else
            {
                noGames.Visible = false;
            }
            if (foodChain.Visible == true && foodwebPanel.Visible == true && herbivorePanel.Visible == true
                && carnivorePanel.Visible == true && omnivorePanel.Visible == true && producerConsumer.Visible == true
                || decomposerPanel.Visible == true)
            {
                gunaVScrollBar1.Visible = true;
            }
        }

        private void Games_VisibleChanged(object sender, EventArgs e)
        {
            RefreshGamesForm();
        }
    }
}
