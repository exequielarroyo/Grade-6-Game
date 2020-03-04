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

        private void fullButton_Click(object sender, EventArgs e)
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
            }
            else if (player.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                gunaCircleButton1.Image = Properties.Resources.play_button_circled_96px;
                isPlay = false;
            }
        }
    }
}
