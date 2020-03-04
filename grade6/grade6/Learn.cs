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

        public void gunaShadowPanel1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SendToBack();
            document1.SendToBack();
            videoLearn1.player.URL = Application.StartupPath + "\\Fabulous Food Chains- Crash Course Kids #7.1.mp4";
            videoLearn1.titleLabel.Text = "Food Chain";
        }

        public void gunaShadowPanel2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SendToBack();
            document1.SendToBack();
            videoLearn1.player.URL = Application.StartupPath + "\\Food Webs- Crash Course Kids #21.2.mp4";
            videoLearn1.titleLabel.Text = "Food Web";
        }

        public void gunaShadowPanel3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SendToBack();
            videoLearn1.SendToBack();
            document1.BringToFront();
            //
            document1.titleLabel.Text = "Herbivore Animals";
        }

        public void gunaShadowPanel4_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SendToBack();
            videoLearn1.SendToBack();
            document1.BringToFront();
            //
            document1.titleLabel.Text = "Carnivore Animals";
        }

        public void gunaShadowPanel12_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.SendToBack();
            videoLearn1.SendToBack();
            document1.BringToFront();
            //
            document1.titleLabel.Text = "Omnivore Animals";
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
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
