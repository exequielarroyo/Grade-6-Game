using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grade6
{
    public partial class Form1 : Form
    {
        public SoundPlayer unlock = new SoundPlayer(Properties.Resources.unlock);

        public Form1()
        {
            InitializeComponent();
            //unlock = new SoundPlayer(Properties.Resources.unlock);
        }

        public void Alert(string msg, Notification.enmType type)
        {
            Notification frm = new Notification();
            frm.showAlert(msg, type);
        }

        private void gunaShadowPanel1_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel1;
            elips = gunaElipse1;
            animation.Start();
        }

        private void gunaShadowPanel1_MouseLeave(object sender, EventArgs e)
        {
            elips = gunaElipse1;
            Back(gunaShadowPanel1);
        }

        private void gunaHScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.AutoScrollPosition = new Point(gunaHScrollBar1.Value, 0);
            //flowLayoutPanel1.ScrollControlIntoView(gunaHScrollBar1);
        }

        private void gunaShadowPanel2_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel2;
            elips = gunaElipse2;
            animation.Start();
        }

        private void gunaShadowPanel2_MouseLeave(object sender, EventArgs e)
        {
            elips = gunaElipse2;
            Back(gunaShadowPanel2);
        }

        private void gunaShadowPanel3_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel3;
            elips = gunaElipse3;
            animation.Start();
        }

        private void gunaShadowPanel3_MouseLeave(object sender, EventArgs e)
        {
            elips = gunaElipse3;
            Back(gunaShadowPanel3);
        }

        private void gunaShadowPanel4_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel4;
            elips = gunaElipse4;
            animation.Start();
        }

        private void gunaShadowPanel4_MouseLeave(object sender, EventArgs e)
        {
            elips = gunaElipse4;
            Back(gunaShadowPanel4);
        }

        private void gunaShadowPanel10_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel10;
            elips = gunaElipse5;
            animation.Start();
        }

        private void gunaShadowPanel10_MouseLeave(object sender, EventArgs e)
        {
            elips = gunaElipse5;
            Back(gunaShadowPanel10);
        }

        private void gunaShadowPanel11_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel11;
            elips = gunaElipse6;
            animation.Start();
        }

        private void gunaShadowPanel11_MouseLeave(object sender, EventArgs e)
        {
            elips = gunaElipse6;
            Back(gunaShadowPanel11);
        }

        private void gunaShadowPanel12_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel12;
            elips = gunaElipse7;
            animation.Start();
        }

        private void gunaShadowPanel12_MouseLeave(object sender, EventArgs e)
        {
            elips = gunaElipse7;
            Back(gunaShadowPanel12);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //loadingScreen1.BringToFront();
            //loadingScreen1.timer1.Start();
            learn1.Hide();
            MainMenu.Show();
            Feedback.Show();
            games1.Hide();
            info.Hide();
            MainMenu.Dock = DockStyle.Fill;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            mainTableLayout.BackColor = Color.FromArgb(247, 247, 255);
            learn1.Hide();
            MainMenu.Show();
            Feedback.Show();
            games1.Hide();
            MainMenu.SetColumnSpan(MAINPANEL, 1);
            info.Hide();
        }
        
        private void gamesButton_Click(object sender, EventArgs e)
        {

            mainTableLayout.BackColor = Color.FromArgb(103, 83, 187);
            learn1.Hide();
            MainMenu.Hide();
            Feedback.Hide();
            games1.Show();
            MainMenu.SetColumnSpan(MAINPANEL, 2);
            info.Hide();
        }
        private void learnButton_Click(object sender, EventArgs e)
        {
            mainTableLayout.BackColor = Color.FromArgb(247, 247, 255);
            MainMenu.Hide();
            Feedback.Hide();
            games1.Hide();
            MainMenu.SetColumnSpan(MAINPANEL, 2);
            learn1.Show();
            info.Hide();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            mainTableLayout.BackColor = Color.FromArgb(247, 247, 255);
            MainMenu.Hide();
            Feedback.Hide();
            games1.Hide();
            MainMenu.SetColumnSpan(MAINPANEL, 2);
            learn1.Show();
            info.Show();
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

        private void readLabel_Click(object sender, EventArgs e)
        {
            learnButton_Click(sender, e);
            learn1.gunaShadowPanel4_Click(sender, e);
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

        private void exit_Click(object sender, EventArgs e)
        {
            AskPermissionBeforeQuite(sender, e as FormClosingEventArgs);

        }
        private void AskPermissionBeforeQuite(object sender, FormClosingEventArgs e)
        {
            DialogResult YesOrNO = MessageBox.Show("Are You Sure To Quit ?", "Thesis GA[]\\/[]ER", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sender as Guna.UI.WinForms.GunaShadowPanel != exit && YesOrNO == DialogResult.No) e.Cancel = true;
            if (sender as Guna.UI.WinForms.GunaShadowPanel == exit && YesOrNO == DialogResult.Yes) Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            learnButton_Click(sender, e);
            homeButton.Checked = false;
            learnButton.Checked = false;
            gamesButton.Checked = false;
            infoButton.Checked = false;
            learn1.videoLearn1.player.URL = Application.StartupPath + "\\Why Meat is the Best Worst Thing in the World 🍔.mp4";
            learn1.videoLearn1.titleLabel.Text = "Why Meat is the Best Worst Thing in the World 🍔";
            learn1.videoLearn1.BringToFront();
            learn1.videoLearn1.player.Ctlcontrols.play();

            this.Alert("you unlock a hidden video", Notification.enmType.Success);

        }

        Guna.UI.WinForms.GunaShadowPanel panels;
        Guna.UI.WinForms.GunaElipse elips;
        void Back(Guna.UI.WinForms.GunaShadowPanel panelss)
        {
            panelss.Height = 154;
            panelss.Width = 110;
            panelss.ShadowDepth = 50;
            panelss.ShadowShift = 5;
            elips.Radius = 8;
        }
        private void animation_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (panels.Height <= 160)
                {
                    panels.Height += 1;
                    panels.Width += 1;
                    panels.ShadowDepth = 0;
                    panels.ShadowShift = 2;
                    elips.Radius = 10;
                    if (panels.Height == 160 || panels.Width == 114)
                    {
                        animation.Stop();
                    }
                }
            }
        }

        private void animation2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (panels.Height <= 87)
                {
                    panels.Height += 1;
                    panels.Width += 1;
                    if (panels.Height == 87 || panels.Width == 156)
                    {
                        animation2.Stop();
                    }
                }
            }
        }
        void Back2(Guna.UI.WinForms.GunaShadowPanel panelss)
        {
            panelss.Height = 77;
            panelss.Width = 146;
        }
        private void gunaShadowPanel8_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel8;
            animation2.Start();
        }

        private void gunaShadowPanel8_MouseLeave(object sender, EventArgs e)
        {
            Back2(gunaShadowPanel8);
        }

        private void chat1_MouseHover(object sender, EventArgs e)
        {
            panels = chat1;
            animation2.Start();
        }

        private void chat1_MouseLeave(object sender, EventArgs e)
        {
            Back2(chat1);
        }

    }
}
