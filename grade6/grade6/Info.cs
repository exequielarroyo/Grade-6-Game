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
    public partial class Info : UserControl
    {
        public Info()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panels.BringToFront();
            for (int i = 0; i < 3; i++)
            {
                if (panels.Height <= 200)
                {
                    panels.Height += 5;
                    panels.Width += 20;
                    if (panels.Height <= 200 && panels.Height >= 130)
                    {
                        timer1.Stop();
                    }
                }
            }
        }

        Guna.UI.WinForms.GunaShadowPanel panels;
        void Back(Guna.UI.WinForms.GunaShadowPanel panelss)
        {
            panelss.Height = 66;
            panelss.Width = 183;
        }
        private void exit_MouseHover(object sender, EventArgs e)
        {
            panels = exit;
            timer1.Start();
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            Back(exit);
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

        private void gunaShadowPanel2_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel2;
            timer1.Start();
        }

        private void gunaShadowPanel2_MouseLeave(object sender, EventArgs e)
        {
            Back(gunaShadowPanel2);
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

        private void gunaShadowPanel4_MouseHover(object sender, EventArgs e)
        {
            panels = gunaShadowPanel4;
            timer1.Start();
        }

        private void gunaShadowPanel4_MouseLeave(object sender, EventArgs e)
        {
            Back(gunaShadowPanel4);
        }
    }
}
