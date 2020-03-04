using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grade6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void gunaShadowPanel1_MouseHover(object sender, EventArgs e)
        {
            gunaShadowPanel1.ShadowDepth = 0;
            gunaShadowPanel1.ShadowShift = 2;
            gunaElipse1.Radius = 15;
            gunaShadowPanel1.Width = 114;
            gunaShadowPanel1.Height = 160;
        }

        private void gunaShadowPanel1_MouseLeave(object sender, EventArgs e)
        {
            gunaShadowPanel1.ShadowDepth = 50;
            gunaShadowPanel1.ShadowShift = 5;
            gunaElipse1.Radius = 8;
            gunaShadowPanel1.Width = 110;
            gunaShadowPanel1.Height = 154;
        }

        private void gunaHScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScrollPosition = new Point(gunaHScrollBar1.Value, 0);
            //flowLayoutPanel1.ScrollControlIntoView(gunaHScrollBar1);
        }



        private void gunaShadowPanel2_MouseHover(object sender, EventArgs e)
        {
            gunaShadowPanel2.ShadowDepth = 0;
            gunaShadowPanel2.ShadowShift = 2;
            gunaElipse2.Radius = 15;
            gunaShadowPanel2.Width = 114;
            gunaShadowPanel2.Height = 160;
        }

        private void gunaShadowPanel2_MouseLeave(object sender, EventArgs e)
        {
            gunaShadowPanel2.ShadowDepth = 50;
            gunaShadowPanel2.ShadowShift = 5;
            gunaElipse2.Radius = 8;
            gunaShadowPanel2.Width = 110;
            gunaShadowPanel2.Height = 154;
        }

        private void gunaShadowPanel3_MouseHover(object sender, EventArgs e)
        {
            gunaShadowPanel3.ShadowDepth = 0;
            gunaShadowPanel3.ShadowShift = 2;
            gunaElipse3.Radius = 15;
            gunaShadowPanel3.Width = 114;
            gunaShadowPanel3.Height = 160;
        }

        private void gunaShadowPanel3_MouseLeave(object sender, EventArgs e)
        {
            gunaShadowPanel3.ShadowDepth = 50;
            gunaShadowPanel3.ShadowShift = 5;
            gunaElipse3.Radius = 8;
            gunaShadowPanel3.Width = 110;
            gunaShadowPanel3.Height = 154;
        }

        private void gunaShadowPanel4_MouseHover(object sender, EventArgs e)
        {
            gunaShadowPanel4.ShadowDepth = 0;
            gunaShadowPanel4.ShadowShift = 2;
            gunaElipse4.Radius = 15;
            gunaShadowPanel4.Width = 114;
            gunaShadowPanel4.Height = 160;
        }

        private void gunaShadowPanel4_MouseLeave(object sender, EventArgs e)
        {
            gunaShadowPanel4.ShadowDepth = 50;
            gunaShadowPanel4.ShadowShift = 5;
            gunaElipse4.Radius = 8;
            gunaShadowPanel4.Width = 110;
            gunaShadowPanel4.Height = 154;
        }

        private void infoVideo_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            infoVideo.Ctlcontrols.play();
        }

        private void gunaShadowPanel8_MouseHover(object sender, EventArgs e)
        {
            gunaShadowPanel8.Width = 156;
            gunaShadowPanel8.Height = 87;
        }

        private void gunaShadowPanel8_MouseLeave(object sender, EventArgs e)
        {
            gunaShadowPanel8.Width = 146;
            gunaShadowPanel8.Height = 77;
        }

        private void chat1_MouseHover(object sender, EventArgs e)
        {
            chat1.Width = 156;
            chat1.Height = 87;
        }

        private void chat1_MouseLeave(object sender, EventArgs e)
        {
            chat1.Width = 146;
            chat1.Height = 77;
        }

        private void gunaShadowPanel10_MouseHover(object sender, EventArgs e)
        {
            gunaShadowPanel10.ShadowDepth = 0;
            gunaShadowPanel10.ShadowShift = 2;
            gunaElipse5.Radius = 15;
            gunaShadowPanel10.Width = 114;
            gunaShadowPanel10.Height = 160;
        }

        private void gunaShadowPanel10_MouseLeave(object sender, EventArgs e)
        {
            gunaShadowPanel10.ShadowDepth = 50;
            gunaShadowPanel10.ShadowShift = 5;
            gunaElipse5.Radius = 8;
            gunaShadowPanel10.Width = 110;
            gunaShadowPanel10.Height = 154;
        }
        

        private void gunaShadowPanel11_MouseHover(object sender, EventArgs e)
        {
            gunaShadowPanel11.ShadowDepth = 0;
            gunaShadowPanel11.ShadowShift = 2;
            gunaElipse6.Radius = 15;
            gunaShadowPanel11.Width = 114;
            gunaShadowPanel11.Height = 160;
        }

        private void gunaShadowPanel11_MouseLeave(object sender, EventArgs e)
        {
            gunaShadowPanel11.ShadowDepth = 50;
            gunaShadowPanel11.ShadowShift = 5;
            gunaElipse6.Radius = 8;
            gunaShadowPanel11.Width = 110;
            gunaShadowPanel11.Height = 154;
        }

        private void gunaShadowPanel12_MouseHover(object sender, EventArgs e)
        {
            gunaShadowPanel12.ShadowDepth = 0;
            gunaShadowPanel12.ShadowShift = 2;
            gunaElipse7.Radius = 15;
            gunaShadowPanel12.Width = 114;
            gunaShadowPanel12.Height = 160;
        }

        private void gunaShadowPanel12_MouseLeave(object sender, EventArgs e)
        {
            gunaShadowPanel12.ShadowDepth = 50;
            gunaShadowPanel12.ShadowShift = 5;
            gunaElipse7.Radius = 8;
            gunaShadowPanel12.Width = 110;
            gunaShadowPanel12.Height = 154;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadingScreen1.BringToFront();
            loadingScreen1.timer1.Start();
            learn1.Hide();
            MainMenu.Show();
            Feedback.Show();
            games1.Hide();
            MainMenu.Dock = DockStyle.Fill;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            learn1.Hide();
            MainMenu.Show();
            Feedback.Show();
            games1.Hide();
            MainMenu.SetColumnSpan(MAINPANEL, 1);
        }
        private void gamesButton_Click(object sender, EventArgs e)
        {
            learn1.Hide();
            MainMenu.Hide();
            Feedback.Hide();
            games1.Show();
            MainMenu.SetColumnSpan(MAINPANEL, 2);
        }
        private void learnButton_Click(object sender, EventArgs e)
        {
            learn1.Show();
            MainMenu.Hide();
            Feedback.Hide();
            games1.Hide();
            MainMenu.SetColumnSpan(MAINPANEL, 2);
        }

        private void playVideoButton_MouseHover(object sender, EventArgs e)
        {
            playVideoButton.Image = Properties.Resources.play_button_circled_100px;
            playVideoButton.Height = 40;
            playVideoButton.Width = 40;
        }

        private void playVideoButton_MouseLeave(object sender, EventArgs e)
        {
            playVideoButton.Image = Properties.Resources.play_button_circled_96px;
            playVideoButton.Height = 40;
            playVideoButton.Width = 40;
        }

        private void playVideoButton_Click(object sender, EventArgs e)
        {
            learnButton_Click(sender, e);
            learn1.gunaShadowPanel2_Click(sender, e);
            learnButton.Checked = true;
        }

        private void gunaShadowPanel1_Click(object sender, EventArgs e)
        {
            learnButton_Click(sender, e);
            learn1.gunaShadowPanel1_Click(sender, e);
            learnButton.Checked = true;
        }

        private void gunaShadowPanel2_Click(object sender, EventArgs e)
        {
            learnButton_Click(sender, e);
            learn1.gunaShadowPanel2_Click(sender, e);
            learnButton.Checked = true;
        }

        private void gunaShadowPanel3_Click(object sender, EventArgs e)
        {
            learnButton_Click(sender, e);
            learn1.gunaShadowPanel3_Click(sender, e);
            learnButton.Checked = true;
        }

        private void gunaShadowPanel4_Click(object sender, EventArgs e)
        {
            learnButton_Click(sender, e);
            learn1.gunaShadowPanel4_Click(sender, e);
            learnButton.Checked = true;
        }

        private void gunaShadowPanel12_Click(object sender, EventArgs e)
        {
            learnButton_Click(sender, e);
            learn1.gunaShadowPanel12_Click(sender, e);
            learnButton.Checked = true;
        }

        private void gunaShadowPanel11_Click(object sender, EventArgs e)
        {
            learnButton_Click(sender, e);
            learn1.gunaShadowPanel11_Click(sender, e);
            learnButton.Checked = true;
        }

        private void gunaShadowPanel10_Click(object sender, EventArgs e)
        {
            learnButton_Click(sender, e);
            learn1.gunaShadowPanel10_Click(sender, e);
            learnButton.Checked = true;
        }

        private void exit_MouseHover(object sender, EventArgs e)
        {
            exitLabel.Visible = true;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exitLabel.Visible = false;
        }
    }
}
