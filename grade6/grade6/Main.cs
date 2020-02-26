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

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
