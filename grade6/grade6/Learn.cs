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
    public partial class Learn : UserControl
    {
        public Learn()
        {
            InitializeComponent();
        }

        private void Learn_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.BringToFront();

        }
        
        public bool foodChain = false;
        public bool foodweb = false;
        public bool herbivoreAnimals = false;
        public bool carnivoreAnimals = false;
        public bool omnivoreAnimals = false;
        public bool producer = false;
        public bool decomposer = false;
        
        public void gunaShadowPanel1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SendToBack();
            document1.SendToBack();
            videoLearn1.player.URL = Application.StartupPath + "\\Fabulous Food Chains- Crash Course Kids #7.1.mp4";
            videoLearn1.titleLabel.Text = "Food Chain";
            videoLearn1.label.Text = "Fabulous Food Chains- Crash Course Kids";
        }

        public void gunaShadowPanel2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SendToBack();
            document1.SendToBack();
            videoLearn1.player.URL = Application.StartupPath + "\\Food Webs- Crash Course Kids #21.2.mp4";
            videoLearn1.titleLabel.Text = "Food Web";
            videoLearn1.label.Text = "Food Webs- Crash Course Kids";
        }

        public void gunaShadowPanel3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SendToBack();
            videoLearn1.SendToBack();
            document1.BringToFront();
            document1.aboutLabel.Text = "A herbivore is an animal anatomically and physiologically adapted to eating plant material, for example foliage or marine algae, for the main component of its diet. As a result of their plant diet, herbivorous animals typically have mouthparts adapted to rasping or grinding. Horses and other herbivores have wide flat teeth that are adapted to grinding grass, tree bark, and other tough plant material.";
            document1.gameTitleLabel.Text = "Swipe to go away!";
            document1.titleLabel.Text = "Herbivore Animals";
            document1.titleLabe.Text = document1.titleLabel.Text;
        }

        public void gunaShadowPanel4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SendToBack();
            videoLearn1.SendToBack();
            document1.BringToFront();
            document1.aboutLabel.Text = "A carnivore, meaning \"meat eater\" (Latin, caro, genitive carnis, meaning \"meat\" or \"flesh\" and vorare meaning \"to devour\"), is an organism that derives its energy and nutrient requirements from a diet consisting mainly or exclusively of animal tissue, whether through predation or scavenging. Animals that depend solely on animal flesh for their nutrient requirements are called obligate carnivores while those that also consume non-animal food are called facultative carnivores. Omnivores also consume both animal and non-animal food, and, apart from the more general definition, there is no clearly defined ratio of plant to animal material that would distinguish a facultative carnivore from an omnivore. A carnivore at the top of the food chain, not preyed upon by other animals, is termed an apex predator.";
            document1.gameTitleLabel.Text = "Catch the egg";
            document1.titleLabel.Text = "Carnivore Animals";
            document1.titleLabe.Text = document1.titleLabel.Text;
        }

        public void gunaShadowPanel12_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SendToBack();
            videoLearn1.SendToBack();
            document1.BringToFront();
            document1.aboutLabel.Text = "An omnivore is an animal that has the ability to eat and survive on both plant and animal matter. Obtaining energy and nutrients from plant and animal matter, omnivores digest carbohydrates, protein, fat, and fiber, and metabolize the nutrients and energy of the sources absorbed. Often, they have the ability to incorporate food sources such as algae, fungi, and bacteria into their diet.";
            document1.gameTitleLabel.Text = "Identify me!";
            document1.titleLabel.Text = "Omnivore Animals";
            document1.titleLabe.Text = document1.titleLabel.Text;
        }

        public void gunaShadowPanel11_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SendToBack();
            videoLearn1.SendToBack();
            document1.BringToFront();
            videoLearn1.player.URL = Application.StartupPath + "\\";
            videoLearn1.titleLabel.Text = "Producer and Consumer";
        }

        public void gunaShadowPanel10_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SendToBack();
            document1.SendToBack();
            videoLearn1.player.URL = Application.StartupPath + "\\The Dirt on Decomposers- Crash Course Kids #7.2.mp4";
            videoLearn1.titleLabel.Text = "Decomposer";
            videoLearn1.label.Text = "The Dirt on Decomposers- Crash Course Kids";
        }

        Guna.UI.WinForms.GunaShadowPanel panels;
        void Back(Guna.UI.WinForms.GunaShadowPanel panelss)
        {
            panelss.Height = 196;
            panelss.Width = 120;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (panels.Height <= 206)
                {
                    panels.Height += 1;
                    panels.Width += 1;
                    if (panels.Height == 206 || panels.Width == 130)
                    {
                        timer1.Stop();
                    }
                }
            }
        }

        private void comingSPanel_MouseHover(object sender, EventArgs e)
        {
            panels = comingSPanel;
            timer1.Start();
        }

        private void comingSPanel_MouseLeave(object sender, EventArgs e)
        {
            Back(comingSPanel);
        }

        private void gunaShadowPanel10_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel10;
            timer1.Start();
        }

        private void gunaShadowPanel10_MouseLeave(object sender, EventArgs e)
        {
            Back(gunaShadowPanel10);
        }

        private void foodwebPanel_MouseHover(object sender, EventArgs e)
        {
            panels = foodwebPanel;
            timer1.Start();
        }

        private void foodwebPanel_MouseLeave(object sender, EventArgs e)
        {
            Back(foodwebPanel);
        }

        private void gunaShadowPanel3_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel3;
            timer1.Start();
        }

        private void gunaShadowPanel3_MouseLeave(object sender, EventArgs e)
        {
            Back(gunaShadowPanel3);
        }

        private void gunaShadowPanel1_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel1;
            timer1.Start();
        }

        private void gunaShadowPanel1_MouseLeave(object sender, EventArgs e)
        {
            Back(gunaShadowPanel1);
        }

        private void gunaShadowPanel4_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel4;
            timer1.Start();
        }

        private void gunaShadowPanel4_MouseLeave(object sender, EventArgs e)
        {
            Back(gunaShadowPanel4);
        }

        private void gunaShadowPanel11_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel11;
            timer1.Start();
        }

        private void gunaShadowPanel11_MouseLeave(object sender, EventArgs e)
        {
            Back(gunaShadowPanel11);
        }

        private void gunaShadowPanel12_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel12;
            timer1.Start();
        }

        private void gunaShadowPanel12_MouseLeave(object sender, EventArgs e)
        {
            Back(gunaShadowPanel12);
        }
    }
}
