using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

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

        public SoundPlayer click = new SoundPlayer(Properties.Resources.click2);
        public void gunaShadowPanel1_Click(object sender, EventArgs e)
        {
            click.Play();
            flowLayoutPanel1.SendToBack();
            document1.SendToBack();
            videoLearn1.player.URL = Application.StartupPath + "\\Fabulous Food Chains- Crash Course Kids #7.1.mp4";
            videoLearn1.titleLabel.Text = "Food Chain";
            videoLearn1.label.Text = "Fabulous Food Chains- Crash Course Kids";

            switch (videoLearn1.titleLabel.Text)
            {
                case "Food Chain":
                    if (VideoLearn.foodChain == false)
                    {
                        videoLearn1.exit_Click(sender, e);
                        videoLearn1.learn.BringToFront();
                    }
                    else if (VideoLearn.foodChain)
                        videoLearn1.finishPanel.BringToFront();
                    break;
            }
        }

        public void gunaShadowPanel2_Click(object sender, EventArgs e)
        {
            click.Play();
            flowLayoutPanel1.SendToBack();
            document1.SendToBack();
            videoLearn1.player.URL = Application.StartupPath + "\\Food Webs- Crash Course Kids #21.2.mp4";
            videoLearn1.titleLabel.Text = "Food Web";
            videoLearn1.label.Text = "Food Webs- Crash Course Kids";
            switch (videoLearn1.titleLabel.Text)
            {
                case "Food Web":
                    if (VideoLearn.foodweb == false)
                    {
                        videoLearn1.exit_Click(sender, e);
                        videoLearn1.learn.BringToFront();
                    }
                    else if (VideoLearn.foodweb)
                        videoLearn1.finishPanel.BringToFront();
                    break;
            }
        }

        public void gunaShadowPanel3_Click(object sender, EventArgs e)
        {
            click.Play();
            flowLayoutPanel1.SendToBack();
            document1.SendToBack();
            videoLearn1.player.URL = Application.StartupPath + "\\Herbivorous Animals Pictures With Names - Educational Video for Kids - #KidsLearning.mp4";
            videoLearn1.titleLabel.Text = "Herbivore Animals";
            videoLearn1.label.Text = "Herbivorous Animals Pictures With Names";
            switch (videoLearn1.titleLabel.Text)
            {
                case "Herbivore Animals":
                    if (VideoLearn.herbivoreAnimals == false)
                    {
                        videoLearn1.exit_Click(sender, e);
                        videoLearn1.learn.BringToFront();
                    }
                    else if (VideoLearn.herbivoreAnimals)
                        videoLearn1.finishPanel.BringToFront();
                    break;
            }
        }

        public void gunaShadowPanel4_Click(object sender, EventArgs e)
        {
            click.Play();
            flowLayoutPanel1.SendToBack();
            document1.SendToBack();
            videoLearn1.player.URL = Application.StartupPath + "\\Carnivorous Animals Name For Kids With Picture - Carnivorous Animals List - Simba Tv.mp4";
            videoLearn1.titleLabel.Text = "Carnivore Animals";
            videoLearn1.label.Text = "Carnivorous Animals Name For Kids With Picture";
            switch (videoLearn1.titleLabel.Text)
            {
                case "Carnivore Animals":
                    if (VideoLearn.carnivoreAnimals == false)
                    {
                        videoLearn1.exit_Click(sender, e);
                        videoLearn1.learn.BringToFront();
                    }
                    else if (VideoLearn.carnivoreAnimals)
                        videoLearn1.finishPanel.BringToFront();
                    break;
            }
        }

        public void gunaShadowPanel12_Click(object sender, EventArgs e)
        {
            click.Play();
            flowLayoutPanel1.SendToBack();
            document1.SendToBack();
            videoLearn1.player.URL = Application.StartupPath + "\\Omnivorous Animals Names - Simba Tv - Omnivores Animals Names List - Educational Video.mp4";
            videoLearn1.titleLabel.Text = "Omnivore Animals";
            videoLearn1.label.Text = "Omnivorous Animals Names";
            switch (videoLearn1.titleLabel.Text)
            {
                case "Omnivore Animals":
                    if (VideoLearn.omnivoreAnimals == false)
                    {
                        videoLearn1.exit_Click(sender, e);
                        videoLearn1.learn.BringToFront();
                    }
                    else if (VideoLearn.omnivoreAnimals)
                        videoLearn1.finishPanel.BringToFront();
                    break;
            }
        }

        public void gunaShadowPanel11_Click(object sender, EventArgs e)
        {
            click.Play();
            flowLayoutPanel1.SendToBack();
            document1.SendToBack();
            videoLearn1.player.URL = Application.StartupPath + "\\What is consumer, Producer and Decomposer by Smart Study Club.mp4";
            videoLearn1.titleLabel.Text = "Producer and Consumer";
            videoLearn1.label.Text = "What is consumer, Producer and Decomposer";
            switch (videoLearn1.titleLabel.Text)
            {
                case "Producer and Consumer":
                    if (VideoLearn.producer == false)
                    {
                        videoLearn1.exit_Click(sender, e);
                        videoLearn1.learn.BringToFront();
                    }
                    else if (VideoLearn.producer)
                        videoLearn1.finishPanel.BringToFront();
                    break;
            }
        }

        public void gunaShadowPanel10_Click(object sender, EventArgs e)
        {
            click.Play();
            flowLayoutPanel1.SendToBack();
            document1.SendToBack();
            videoLearn1.player.URL = Application.StartupPath + "\\The Dirt on Decomposers- Crash Course Kids #7.2.mp4";
            videoLearn1.titleLabel.Text = "Decomposer";
            videoLearn1.label.Text = "The Dirt on Decomposers- Crash Course Kids";
            switch (videoLearn1.titleLabel.Text)
            {
                case "Decomposer":
                    if (VideoLearn.decomposer == false)
                    {
                        videoLearn1.exit_Click(sender, e);
                        videoLearn1.learn.BringToFront();
                    }
                    else if (VideoLearn.decomposer)
                        videoLearn1.finishPanel.BringToFront();
                    break;
            }
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
