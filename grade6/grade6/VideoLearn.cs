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
    public partial class VideoLearn : UserControl
    {
        public VideoLearn()
        {
            InitializeComponent();
        }

        private void VideoLearn_Load(object sender, EventArgs e)
        {
            
        }
        public static bool foodChain = false;
        public static bool foodweb = false;
        public static bool herbivoreAnimals = false;
        public static bool carnivoreAnimals = false;
        public static bool omnivoreAnimals = false;
        public static bool producer = false;
        public static bool decomposer = false;

        private void doneButton_Click(object sender, EventArgs e)
        {
            if (titleLabel.Text == "Food Chain")
            {
                if (foodChain == false)
                    foodChain = true;
                else
                    foodChain = false;
            }
            else if (titleLabel.Text == "Food Web")
            {
                if (foodweb == false)
                    foodweb = true;
                else
                    foodweb = false;
            }
            else if (titleLabel.Text == "Producer and Consumer")
            {
                if (producer == false)
                    producer = true;
                else
                    producer = false;
            }
            else if (titleLabel.Text == "Decomposer")
            {
                if (decomposer == false)
                    decomposer = true;
                else
                    decomposer = false;
            }
            
        }

        public bool isPlay = false;
        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            if (isPlay == false)
            {
                player.Ctlcontrols.play();
                gunaCircleButton1.Image = Properties.Resources.pause_button_100px;
                isPlay = true;
            }
            else if (isPlay)
            {
                player.Ctlcontrols.pause();
                gunaCircleButton1.Image = Properties.Resources.play_button_circled_96px;
                isPlay = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            gunaCircleButton1.Image = Properties.Resources.play_button_circled_96px;
            isPlay = false;
            this.SendToBack();
            player.Ctlcontrols.stop();
        }

        public void fullButton_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.fullScreen = true;
            }
        }

        private void player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                gunaCircleButton1.Image = Properties.Resources.play_button_circled_96px;
                isPlay = false;
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                gunaCircleButton1.Image = Properties.Resources.pause_button_100px;
                isPlay = true;
                label.Visible = false;
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                gunaCircleButton1.Image = Properties.Resources.play_button_circled_96px;
                isPlay = false;
                label.Visible = true;
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
            }
        }

        private void titleLabel_TextChanged(object sender, EventArgs e)
        {
            //label.Text = titleLabel.Text;
            Learn learn = new Learn();
            if (titleLabel.Text == "Food Chain")
            {
                if (foodChain == false)
                    doneButton.Checked = false;
                else if (foodChain == true)
                    doneButton.Checked = true;
            }
            else if (titleLabel.Text == "Food Web")
            {
                if (foodweb == false)
                    doneButton.Checked = false;
                else if (foodweb == true)
                    doneButton.Checked = true;
            }
            else if (titleLabel.Text == "Producer and Consumer")
            {
                if (producer == false)
                    doneButton.Checked = false;
                else if (producer == true)
                    doneButton.Checked = true;
            }
            else if (titleLabel.Text == "Decomposer")
            {
                if (decomposer == false)
                    doneButton.Checked = false;
                else if (decomposer == true)
                    doneButton.Checked = true;
            }
            Refresh();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying || player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                player.Ctlcontrols.stop(); ;
                gunaCircleButton1.Image = Properties.Resources.play_button_circled_96px;
                isPlay = false;
                label.Visible = true;
            }
        }

        private void doneButton_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
